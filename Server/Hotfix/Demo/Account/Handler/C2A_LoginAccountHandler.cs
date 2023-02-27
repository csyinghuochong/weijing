using System;
using System.Collections.Generic;

namespace ET
{
    public class C2A_LoginAccountHandler : AMRpcHandler<C2A_LoginAccount, A2C_LoginAccount>
    {
        public int CanLogin(string identityCard, bool isHoliday)
        {
            int age = ComHelp.GetBirthdayAgeSex(identityCard);
            if (age >= 18)
            {
                return ErrorCore.ERR_Success;
            }
            if (age < 12)
            {
                return ErrorCore.ERR_FangChengMi_Tip6;
            }
            DateTime dateTime = TimeHelper.DateTimeNow();
            if (isHoliday)
            {
                if (dateTime.Hour == 20)
                {
                    return ErrorCore.ERR_Success;           //允许登录
                }
                else
                {
                    return ErrorCore.ERR_FangChengMi_Tip7;
                }
            }
            else
            {
                return ErrorCore.ERR_FangChengMi_Tip7;
            }
        }

        protected override async ETTask Run(Session session, C2A_LoginAccount request, A2C_LoginAccount response, Action reply)
        {
            Log.Debug($"LoginTest request.AccountName:{request.AccountName} {request.Password} {session.RemoteAddress}");
            if (session.DomainScene().SceneType != SceneType.Account)
            {
                Log.Error($"LoginTest C2A_LoginAccount请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
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
            if (session.DomainScene().GetComponent<FangChenMiComponent>().StopServer && !GMHelp.GmAccount.Contains(request.AccountName))
            {
                response.Error = ErrorCore.ERR_StopServer;
                reply();
                session.Disconnect().Coroutine();
                return;
            }
            if (string.IsNullOrEmpty(request.AccountName) || string.IsNullOrEmpty(request.Password))
            {
                response.Error = ErrorCore.ERR_LoginInfoIsNull;
                reply();
                session.Disconnect().Coroutine();
                return;
            }

            //密码要md5
            //if (!Regex.IsMatch(request.AccountName.Trim(),@"^(?=.*[0-9].*)(?=.*[A-Z].*)(?=.*[a-z].*).{6,15}$"))
            //{
            //    response.Error = ErrorCode.ERR_AccountNameFormError;
            //    reply();
            //    session.Disconnect().Coroutine();
            //    return;
            //}

            //if (!Regex.IsMatch(request.Password.Trim(),@"^[A-Za-z0-9]+$"))
            //{
            //    response.Error = ErrorCode.ERR_PasswordFormError;
            //    reply();
            //    session.Disconnect().Coroutine();
            //    return;
            //}
            //先检测一下QQ和微信登录
            long AccountId = 0;
            if (!string.IsNullOrEmpty(request.ThirdLogin) && request.ThirdLogin.Length > 0)
            {
                using (session.AddComponent<SessionLockingComponent>())
                {
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginAccount, request.AccountName.Trim().GetHashCode()))
                    {
                        long accountZone = DBHelper.GetAccountCenter();
                        Center2A_CheckAccount centerAccount = (Center2A_CheckAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_CheckAccount() {
                            AccountName = request.AccountName, 
                            Password = request.Password,
                            ThirdLogin = request.ThirdLogin });
                        PlayerInfo playerInfo = centerAccount.PlayerInfo != null ? centerAccount.PlayerInfo : null;

                        if (centerAccount.PlayerInfo == null)
                        {
                            Center2A_RegisterAccount saveAccount = (Center2A_RegisterAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_RegisterAccount()
                            {
                                AccountName = request.AccountName,
                                Password = request.Password
                            });
                            //AccountId = saveAccount.AccountId;
                            AccountId = long.Parse(saveAccount.Message);
                        }
                        else
                        {
                            AccountId = centerAccount.AccountId;
                        }
                    }
                }
            }
            
            using (session.AddComponent<SessionLockingComponent>())
            {
                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginAccount, request.AccountName.Trim().GetHashCode()))
                {
                    List<DBAccountInfo> accountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(session.DomainZone(), d => d.Account == request.AccountName && d.Password == request.Password); ;
                    if (accountInfoList.Count == 0 && AccountId > 0)
                    {
                        accountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(session.DomainZone(), d => d.Id == AccountId);
                    }

                    DBAccountInfo account = accountInfoList != null && accountInfoList.Count > 0 ? accountInfoList[0] : null;
                    long accountZone = DBHelper.GetAccountCenter();
                    Center2A_CheckAccount centerAccount = (Center2A_CheckAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_CheckAccount() {
                        AccountName = request.AccountName,
                        Password = request.Password,
                        ThirdLogin = request.ThirdLogin
                    });
                    PlayerInfo centerPlayerInfo = centerAccount.PlayerInfo;

                    if (centerPlayerInfo == null)
                    {
                        response.Error = ErrorCore.ERR_LoginInfoIsNull;
                        reply();
                        session.Disconnect().Coroutine();
                        return;
                    }
                    if (account == null)
                    {
                        //在该区创建账号信息
                        account = session.AddChildWithId<DBAccountInfo>(centerAccount.AccountId);
                        account.Account = request.AccountName;
                        account.Password = request.Password;
                        await Game.Scene.GetComponent<DBComponent>().Save<DBAccountInfo>(session.DomainZone(), account);
                    }

                    if (account.AccountType == 2) //黑名单
                    {
                        response.Error = ErrorCore.ERR_AccountInBlackListError;
                        response.AccountId = account.Id;
                        reply();
                        session.Disconnect().Coroutine();
                        account?.Dispose();
                        return;
                    }
                    if (centerPlayerInfo.RealName == 0 )
                    {
                        response.Error = ErrorCore.ERR_NotRealName;
                        response.AccountId = account.Id;
                        reply();
                        session.Disconnect().Coroutine();
                        account?.Dispose();
                        return;
                    }

                    //if (!account.Password.Equals(request.Password))
                    //{
                    //    response.Error = ErrorCore.ERR_AccountOrPasswordError;
                    //    reply();
                    //    session.Disconnect().Coroutine();
                    //    account?.Dispose();
                    //    return;
                    //}
                    //防沉迷相关
                    string idCardNo = centerPlayerInfo.IdCardNo;
                    int canLogin = CanLogin(idCardNo, session.DomainScene().GetComponent<FangChenMiComponent>().IsHoliday);
                    if (canLogin != ErrorCode.ERR_Success)
                    {
                        response.Error = canLogin;
                        reply();
                        session.Disconnect().Coroutine();
                        account?.Dispose();
                        return;
                    }

                    string queueToken = session.DomainScene().GetComponent<TokenComponent>().Get(account.Id);

                    //在线人数判断有问题。[获取的是在保存在账号服的玩家数量]
                    long onlineNumber = session.DomainScene().GetComponent<AccountSessionsComponent>().GetAll().Values.Count;
                    int maxNumber = int.Parse( GlobalValueConfigCategory.Instance.Get(25).Value);
                    if (session.DomainScene().GetComponent<AccountSessionsComponent>().Get(account.Id) == 0 &&
                        onlineNumber >= maxNumber && (string.IsNullOrEmpty(queueToken) || queueToken != request.Token) )
                    {
                        queueToken = TimeHelper.ServerNow().ToString() + RandomHelper.RandomNumber(int.MinValue, int.MaxValue).ToString();
                        session.DomainScene().GetComponent<TokenComponent>().Remove(account.Id);
                        session.DomainScene().GetComponent<TokenComponent>().Add(account.Id, queueToken, true);

                        long queueServerId = DBHelper.GetQueueServerId(session.DomainZone());
                        Q2A_EnterQueue d2GGetUnit = (Q2A_EnterQueue)await ActorMessageSenderComponent.Instance.Call(queueServerId, new A2Q_EnterQueue()
                        {
                            AccountId = account.Id,
                            Token = queueToken
                        });

                        //进入排队
                        response.Error = ErrorCore.ERR_EnterQueue;
                        response.AccountId = account.Id;
                        response.QueueNumber = d2GGetUnit.QueueNumber;
                        response.QueueAddres = StartSceneConfigCategory.Instance.Queues[session.DomainZone()].OuterIPPort.ToString();
                        reply();
                        session.Disconnect().Coroutine();
                        account?.Dispose();
                        return;
                    }

                    //请求登录中心服查询有没有同账号玩家登录[uwa]
                    //StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), "LoginCenter");
                    //long loginCenterInstanceId = startSceneConfig.InstanceId;
                    long loginCenterInstanceId = StartSceneConfigCategory.Instance.LoginCenterConfig.InstanceId;//踢掉进入gate的玩家
                    var loginAccountResponse = (L2A_LoginAccountResponse)await ActorMessageSenderComponent.Instance.Call(loginCenterInstanceId, new A2L_LoginAccountRequest() { AccountId = account.Id, Relink = request.Relink });

                    if (loginAccountResponse.Error != ErrorCode.ERR_Success)
                    {
                        response.Error = loginAccountResponse.Error;

                        reply();
                        session?.Disconnect().Coroutine();
                        account?.Dispose();
                        return;
                    }
                    //AccountSessionsComponent.Remove 需要在适当的时候移除
                    long accountSessionInstanceId = session.DomainScene().GetComponent<AccountSessionsComponent>().Get(account.Id);
                    Session otherSession = Game.EventSystem.Get(accountSessionInstanceId) as Session;
                    if (otherSession != null)
                    {
                        Log.Debug($"LoginTest C2A_LoginAccount.ERR_OtherAccountLogin1 account.Id: {account.Id}");
                    } 
                    otherSession?.Send(new A2C_Disconnect() { Error = ErrorCore.ERR_OtherAccountLogin });                 //踢accout服的玩家下线
                    otherSession?.Disconnect().Coroutine();
                    session.DomainScene().GetComponent<AccountSessionsComponent>().Add(account.Id, session.InstanceId);
                    session.AddComponent<AccountCheckOutTimeComponent, long>(account.Id);   //自己在账号服只能停留600秒

                    string Token = TimeHelper.ServerNow().ToString() + RandomHelper.RandomNumber(int.MinValue, int.MaxValue).ToString();
                    session.DomainScene().GetComponent<TokenComponent>().Remove(account.Id);    //Token也是保留十分钟
                    session.DomainScene().GetComponent<TokenComponent>().Add(account.Id, Token);
                   
                    long dbCacheId = DBHelper.GetDbCacheId(session.DomainZone());
                    for (int i = 0; i < account.UserList.Count; i++)
                    {
                        D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = account.UserList[i], Component = DBHelper.UserInfoComponent });
                        UserInfoComponent userinfo = d2GGetUnit.Component as UserInfoComponent;
                        CreateRoleListInfo roleList = Function_Role.GetInstance().GetRoleListInfo(userinfo.UserInfo, i, account.UserList[i]);

                        d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = account.UserList[i], Component = DBHelper.NumericComponent });
                        NumericComponent numericComponent = d2GGetUnit.Component as NumericComponent;
                        roleList.WeaponId = numericComponent.GetAsInt(NumericType.Now_Weapon);
                        response.RoleLists.Add(roleList);
                    }
                    response.PlayerInfo = centerPlayerInfo;
                    response.AccountId = account.Id;
                    response.Token = Token;
                    reply();
                    account?.Dispose();

                }
            }

        }
    }
}