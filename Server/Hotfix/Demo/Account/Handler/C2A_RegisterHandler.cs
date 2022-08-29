//using System;
//using System.Collections.Generic;

//namespace ET
//{
//    //游戏注册账号
//    [MessageHandler]
//    class C2A_RegisterHandler : AMRpcHandler<C2A_Register, A2C_Register>
//    {
//        protected override async ETTask Run(Session session, C2A_Register request, A2C_Register response, Action reply)
//        {

//            Log.ILog.Debug($"C2A_Register {session.DomainZone()}");

//            if (session.DomainScene().SceneType != SceneType.Account)
//            {
//                Log.Error($"请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
//                session.Dispose();
//                return;
//            }
//            session.RemoveComponent<SessionAcceptTimeoutComponent>();

//            if (session.GetComponent<SessionLockingComponent>() != null)
//            {
//                response.Error = ErrorCore.ERR_RequestRepeatedly;
//                reply();
//                session.Disconnect().Coroutine();
//                return;
//            }

//            if (string.IsNullOrEmpty(request.Account) || !StringHelper.IsSafeSqlString(request.Account))
//            {
//                response.Error = ErrorCore.ERR_UnSafeSqlString;
//                reply();
//                session.Disconnect().Coroutine();
//                return;
//            }

//            using (session.AddComponent<SessionLockingComponent>())
//            {
//                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Register, request.Account.Trim().GetHashCode()))
//                {
//                    long centerServerId = DBHelper.GetCenterServerId();
//                    List<DBAccountInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(session.DomainZone(), _account => _account.Account == request.Account);

//                    //如果查询数据不为空,表示当前账号已经被注册
//                    if (result.Count > 0)
//                    {
//                        Log.Info($"账号已注册:{request.Account}");
//                        response.Error = ErrorCore.ERR_AccountAlreadyRegister;
//                        reply();
//                        session.Disconnect().Coroutine();
//                        return;
//                    }

//                    //像中心服查询


//                    //创建一条数据库信息,创建账号信息
//                    DBAccountInfo newAccount = session.AddChild<DBAccountInfo>();
//                    newAccount.Account = request.Account;
//                    newAccount.Password = request.Password;
//                    newAccount.UserList = new List<long>();
//                    newAccount.PlayerInfo = new PlayerInfo();

//                    if (request.Password == ComHelp.RobotPassWord)
//                    {
//                        newAccount.PlayerInfo.RealName = 1;
//                        newAccount.PlayerInfo.Name = request.Account;
//                        newAccount.PlayerInfo.IdCardNo = "429001198010232399";
//                    }
//                    Log.Info($"注册新账号: {MongoHelper.ToJson(newAccount)}");
//                    long dbCacheId = DBHelper.GetDbCacheId(session.DomainZone());
//                    D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = newAccount.Id, Component = newAccount, ComponentType = DBHelper.DBAccountInfo });
//                    //发送创建回执
//                    reply();
//                }
//            }

//        }
//    }
//}
