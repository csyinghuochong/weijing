using System;
using System.Collections.Generic;

namespace ET
{
    [MessageHandler]
    public class C2Center_RegisterHandler : AMRpcHandler<C2Center_Register, Center2C_Register>
    {

        protected override async ETTask Run(Session session, C2Center_Register request, Center2C_Register response, Action reply)
        {
            if (session.DomainScene().SceneType != SceneType.AccountCenter)
            {
                Log.Error($"请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
                session.Dispose();
                return;
            }
            session.RemoveComponent<SessionAcceptTimeoutComponent>();

            if (session.GetComponent<SessionLockingComponent>() != null)
            {
                response.Error = ErrorCore.ERR_RequestRepeatedly;
                reply();
                session.Disconnect().Coroutine();
                return;
            }

            if (string.IsNullOrEmpty(request.Account) || !StringHelper.IsSafeSqlString(request.Account))
            {
                response.Error = ErrorCore.ERR_UnSafeSqlString;
                reply();
                session.Disconnect().Coroutine();
                return;
            }

            using (session.AddComponent<SessionLockingComponent>())
            {
                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Register, request.Account.Trim().GetHashCode()))
                {
                    List<DBCenterAccountInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(session.DomainZone(), _account => _account.Account == request.Account);

                    //如果查询数据不为空,表示当前账号已经被注册
                    if (result.Count > 0)
                    {
                        response.Error = ErrorCore.ERR_AccountAlreadyRegister;
                        reply();
                        session.Disconnect().Coroutine();
                        return;
                    }

                    //创建一条数据库信息,创建账号信息
                    DBCenterAccountInfo newAccount = session.AddChild<DBCenterAccountInfo>();
                    newAccount.Account = request.Account;
                    newAccount.Password = request.Password;
                    newAccount.PlayerInfo = new PlayerInfo();

                    if (request.Password == ComHelp.RobotPassWord)
                    {
                        newAccount.PlayerInfo.RealName = 1;
                        newAccount.PlayerInfo.Name = request.Account;
                        newAccount.PlayerInfo.IdCardNo = "429001198010232399";
                    }


                    Log.Debug($"Save<DBCenterAccountInfo>55555: { session.DomainZone()}");
                    await Game.Scene.GetComponent<DBComponent>().Save(session.DomainZone(), newAccount);
                    //发送创建回执
                    reply();
                }
            }
        }
    }
}
