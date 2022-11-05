using System;
using System.Collections.Generic;
using System.Net;

namespace ET
{
    public static class LoginHelper
    {

        public static async ETTask<int> Queue(Scene zoneScene, string address)
        {
            Q2C_EnterQueue q2C_EnterGame = null;
            Session queueSession = null;
            
            try
            {
                C2Q_EnterQueue c2Q_EnterQueue= new C2Q_EnterQueue()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId
                };
                queueSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                q2C_EnterGame = (Q2C_EnterQueue)await queueSession.Call(c2Q_EnterQueue);

            }
            catch (Exception e)
            {
                queueSession?.Dispose();
                Log.Error(e.ToString());
                return ErrorCore.ERR_NetWorkError;
            }

            queueSession.AddComponent<PingComponent>();

            return ErrorCore.ERR_Success;
        }

        public static async ETTask<int> Login(Scene zoneScene, string address, string account, string password, bool relink = false, string token = "", string thirdLogin = "")
        {
            AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
            if (TimeHelper.ClientNow() - playerComponent.LastTime < 1000)
            {
                Log.Error("TimeHelper.ClientNow() - LastTime < 1000");
                return ErrorCore.ERR_OperationOften;
            }
            playerComponent.LastTime = TimeHelper.ClientNow();
            A2C_LoginAccount a2CLoginAccount = null;
            Session accountSession = null;

            try
            {
                //password = MD5Helper.StringMD5(password);
                accountSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                a2CLoginAccount = (A2C_LoginAccount)await accountSession.Call(new C2A_LoginAccount() { AccountName = account, Password = password, Token = token, ThirdLogin = thirdLogin, Relink = relink });
            }
            catch (Exception e)
            {
                accountSession?.Dispose();
                Log.Error(e.ToString());
                return ErrorCore.ERR_NetWorkError;
            }

            if (a2CLoginAccount.Error == ErrorCore.ERR_EnterQueue)
            {
                playerComponent.AccountId = a2CLoginAccount.AccountId;
                accountSession?.Dispose();
                Queue(zoneScene, a2CLoginAccount.QueueAddres).Coroutine();
                EventType.LoginError.Instance.ErrorCore = a2CLoginAccount.Error;
                EventType.LoginError.Instance.AccountId = a2CLoginAccount.AccountId;
                EventType.LoginError.Instance.ZoneScene = zoneScene;
                EventType.LoginError.Instance.Value = a2CLoginAccount.QueueNumber.ToString();
                Game.EventSystem.PublishClass(EventType.LoginError.Instance);
                return a2CLoginAccount.Error;
            }
            if (a2CLoginAccount.Error == ErrorCore.ERR_NotRealName
                || a2CLoginAccount.Error == ErrorCore.ERR_FangChengMi_Tip1 
                || a2CLoginAccount.Error == ErrorCore.ERR_FangChengMi_Tip6
                || a2CLoginAccount.Error == ErrorCore.ERR_FangChengMi_Tip7)
            {
                accountSession?.Dispose();
                EventType.LoginError.Instance.ErrorCore = a2CLoginAccount.Error;
                EventType.LoginError.Instance.AccountId = a2CLoginAccount.AccountId;
                EventType.LoginError.Instance.ZoneScene = zoneScene;
                EventType.LoginError.Instance.Value = "0";
                Game.EventSystem.PublishClass(EventType.LoginError.Instance);
                return a2CLoginAccount.Error;
            }

            if (a2CLoginAccount.Error != ErrorCore.ERR_Success)
            {
                accountSession?.Dispose();
                return a2CLoginAccount.Error;
            }

            playerComponent.AccountId = a2CLoginAccount.AccountId;
            playerComponent.Password = password;
            playerComponent.PlayerInfo = a2CLoginAccount.PlayerInfo;
            playerComponent.CreateRoleList = a2CLoginAccount.RoleLists;
            playerComponent.Token = a2CLoginAccount.Token;
            zoneScene.GetComponent<SessionComponent>().Session = accountSession;
            accountSession.AddComponent<PingComponent>();

            if (!relink)
            {
                EventType.LoginFinish.Instance.ZoneScene = zoneScene;
                Game.EventSystem.PublishClass(EventType.LoginFinish.Instance);
            }
            return ErrorCore.ERR_Success;
        }

        public static async ETTask<int> GetRealmKey(Scene zoneScene)
        {
            A2C_GetRealmKey a2CGetRealmKey = null;
            try
            {
                a2CGetRealmKey = (A2C_GetRealmKey)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_GetRealmKey()
                {
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token,
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    ServerId = zoneScene.GetComponent<AccountInfoComponent>().CurrentServerId
                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCore.ERR_NetWorkError;
            }

            if (a2CGetRealmKey.Error != ErrorCore.ERR_Success)
            {
                Log.Error(a2CGetRealmKey.Error.ToString());
                return a2CGetRealmKey.Error;
            }

            zoneScene.GetComponent<AccountInfoComponent>().RealmKey = a2CGetRealmKey.RealmKey;
            zoneScene.GetComponent<AccountInfoComponent>().RealmAddress = a2CGetRealmKey.RealmAddress;
            zoneScene.GetComponent<SessionComponent>().Session.GetComponent<PingComponent>().DisconnectType = 1;
            zoneScene.GetComponent<SessionComponent>().Session.Dispose();
            return ErrorCore.ERR_Success;
        }

        public static async ETTask<int> EnterGame(Scene zoneScene, bool relink = false )
        {
            string realmAddress = zoneScene.GetComponent<AccountInfoComponent>().RealmAddress;
            // 1. 连接Realm，获取分配的Gate
            R2C_LoginRealm r2CLogin;
            
            Session session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(realmAddress));
            try
            {
                r2CLogin = (R2C_LoginRealm)await session.Call(new C2R_LoginRealm()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    RealmTokenKey = zoneScene.GetComponent<AccountInfoComponent>().RealmKey
                });
            }
            catch (Exception e)
            {
                Log.Error(e);
                session?.Dispose();
                return ErrorCore.ERR_LoginRealm;
            }
            session?.Dispose();
            if (r2CLogin.Error != ErrorCore.ERR_Success)
            {
                return r2CLogin.Error;
            }

            Session gateSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(r2CLogin.GateAddress));
            gateSession.AddComponent<PingComponent>();
            zoneScene.GetComponent<SessionComponent>().Session = gateSession;
            // 2. 开始连接Gate
            long currentRoleId = zoneScene.GetComponent<AccountInfoComponent>().CurrentRoleId;
            G2C_LoginGameGate g2CLoginGate = null;
            try
            {
                long accountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId;
                g2CLoginGate = (G2C_LoginGameGate)await gateSession.Call(new C2G_LoginGameGate() { Key = r2CLogin.GateSessionKey, Account = accountId, RoleId = currentRoleId });

            }
            catch (Exception e)
            {
                Log.Error(e);
                zoneScene.GetComponent<SessionComponent>().Session.Dispose();
                return ErrorCore.ERR_NetWorkError;
            }
            if (g2CLoginGate.Error != ErrorCore.ERR_Success)
            {
                zoneScene.GetComponent<SessionComponent>().Session.Dispose();
                return g2CLoginGate.Error;
            }

            //3. 角色正式请求进入游戏逻辑服
            G2C_EnterGame g2CEnterGame = null;
            try
            {
                g2CEnterGame = (G2C_EnterGame)await gateSession.Call(new C2G_EnterGame() { 
                    MapId= 1,
                    Relink = relink,
                    UserID = currentRoleId
                });
            }
            catch (Exception e)
            {
                Log.Error(e);
                zoneScene.GetComponent<SessionComponent>().Session.Dispose();
                return ErrorCore.ERR_NetWorkError;
            }

            if (g2CEnterGame.Error != ErrorCore.ERR_Success)
            {
                Log.Error(g2CEnterGame.Error.ToString());
                return g2CEnterGame.Error;
            }

            if (!relink)
            {
                zoneScene.GetComponent<AccountInfoComponent>().MyId = g2CEnterGame.MyId;
                // 等待场景切换完成[创建了主Unit]
                await zoneScene.GetComponent<ObjectWait>().Wait<WaitType.Wait_SceneChangeFinish>();

                //请求角色数据
                await NetHelper.RequestUserInfo(zoneScene);
                //请求背包数据
                await NetHelper.RequestBagInfo(zoneScene);
                //请求宠物数据
                await NetHelper.RequestAllPets(zoneScene);
                //请求任务数据
                await NetHelper.RequestIniTask(zoneScene);
                //请求技能设置
                await NetHelper.RequestSkillSet(zoneScene);
                //请求好友数据
                await NetHelper.RequestFriendInfo(zoneScene);
                //请求活动数据
                await NetHelper.RequestActivityInfo(zoneScene);

                EventType.EnterMapFinish.Instance.ZoneScene = zoneScene;
                Game.EventSystem.PublishClass(EventType.EnterMapFinish.Instance);
            }

            return ErrorCore.ERR_Success;
        }

        public static async ETTask<bool> RealName(Scene zoneScene, string address, long accountId, string name, string idCardNO)
        {
            try
            {
                // 创建一个ETModel层的Session
                A2C_RealNameResponse r2CLogin;
                Session session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                {
                    r2CLogin = (A2C_RealNameResponse)await session.Call(new C2A_RealNameRequest() { AccountId = accountId, IdCardNO = idCardNO, Name = name });
                }
                session.Dispose();

                return r2CLogin.Error == 0;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return false;
            }
        }

        //创建角色
        public static async ETTask<A2C_CreateRoleData> CreateRole(Scene zoneScene, int createOcc, string createName)
        {
            A2C_CreateRoleData g2cCreateRole = null;
            try
            {
                g2cCreateRole = (A2C_CreateRoleData)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_CreateRoleData()
                {
                    CreateOcc = createOcc,
                    CreateName = createName,
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId
                });
                return g2cCreateRole;
            }
            catch (Exception ex)
            {
                Log.Info(ex.ToString());
                return g2cCreateRole;
            }
        }

        //注册账号
        public static async ETTask<int> Register(Scene zoneScene, bool outNet,  VersionMode versionCode, string account, string password)
        {
            try
            {
                // 创建一个ETModel层的Session
                Center2C_Register r2CRegister;
                IPAddress[] xxc = Dns.GetHostEntry("weijinggame.weijinggame.com").AddressList;
                //走的中心服
                string address = outNet ? $"{xxc[0]}:{GetAccountCenterPort(versionCode)}" : $"127.0.0.1:{GetAccountCenterPort(versionCode)}";
                Session session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                {
                    r2CRegister = (Center2C_Register)await session.Call(new C2Center_Register() { Account = account, Password = password });
                }
                session.Dispose();

                if (r2CRegister.Error == ErrorCore.ERR_AccountAlreadyRegister)
                {
                    Log.Info($"注册失败,账号已被注册: {account}");
                    return r2CRegister.Error;
                }

                return ErrorCore.ERR_Success;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_Error;
            }
        }


        //请求公告显示
        public static async ETTask OnNoticeAsync(Scene zoneScene, string address)
        {

            try
            {
                A2C_Notice r2CNotice;
                Session session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                {
                    r2CNotice = (A2C_Notice)await session.Call(new C2A_Notice() { });
                    zoneScene.GetComponent<AccountInfoComponent>().NoticeStr = r2CNotice.Message;
                }
                session.Dispose();

            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        /// <summary>
        /// 账号中心服
        /// </summary>
        /// <param name="versionMode"></param>
        /// <returns></returns>
        public static int GetAccountCenterPort(VersionMode versionMode)
        {
            if (versionMode == VersionMode.BanHao)
            {
                return 20104;
            }
            if (versionMode == VersionMode.Alpha)
            {
                return 20204;
            }
            return 20304;
        }

        //账号服
        public static int GetAccountPort(VersionMode versionMode)
        {
            if (versionMode == VersionMode.BanHao)
            {
                return 20105;
            }
            if (versionMode == VersionMode.Alpha)
            {
                return 20205;
            }
            return 20305;
        }

        //请求服务器列表【外网】
        public static async ETTask<int> OnServerListAsyncRelease(Scene zoneScene,VersionMode versionMode)
        {
            try
            {
                IPAddress[] xxc = Dns.GetHostEntry("weijinggame.weijinggame.com").AddressList;
                string address = $"{xxc[0]}:{GetAccountPort(versionMode)}";
                A2C_ServerList r2CSelectServer;
                Session session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                {
                    r2CSelectServer = (A2C_ServerList)await session.Call(new C2A_ServerList() { });
                    CheckServerList(r2CSelectServer.ServerItems, versionMode);

                    //存储列表
                    zoneScene.GetComponent<AccountInfoComponent>().MyServerList = r2CSelectServer.MyServers;
                    zoneScene.GetComponent<AccountInfoComponent>().AllServerList = r2CSelectServer.ServerItems;
                }
                session.Dispose();
                return r2CSelectServer.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static void CheckServerList(List<ServerItem> serverItems, VersionMode versionMode)
        {
            for (int i = serverItems.Count - 1; i >= 0; i--)
            {
                if (versionMode == VersionMode.BanHao)
                {
                    if (!ComHelp.IsBanHaoZone(serverItems[i].ServerId))
                    {
                        serverItems.RemoveAt(i);
                    }
                    continue;
                }
                if (versionMode == VersionMode.Alpha)
                {
                    if (!ComHelp.IsAlphaZone(serverItems[i].ServerId))
                    {
                        serverItems.RemoveAt(i);
                    }
                    continue;
                }
                if (versionMode == VersionMode.Beta)
                {
                    if (ComHelp.IsBanHaoZone(serverItems[i].ServerId)
                    || ComHelp.IsAlphaZone(serverItems[i].ServerId))
                    {
                        serverItems.RemoveAt(i);
                    }
                    continue;
                }
            }
        }

        public static async ETTask<int> OnServerListAsyncDebug(Scene zoneScene, VersionMode versionMode)
        {

            try
            {
                A2C_ServerList r2CSelectServer;
                string address = $"127.0.0.1:{GetAccountPort(versionMode)}";
                Session session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                {
                    r2CSelectServer = (A2C_ServerList)await session.Call(new C2A_ServerList() { });
                    CheckServerList(r2CSelectServer.ServerItems, versionMode);

                    //存储列表
                    zoneScene.GetComponent<AccountInfoComponent>().MyServerList = r2CSelectServer.MyServers;
                    zoneScene.GetComponent<AccountInfoComponent>().AllServerList = r2CSelectServer.ServerItems;
                }
                session.Dispose();
                return r2CSelectServer.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }

        }

    }
}