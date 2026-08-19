using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ET
{

    [HttpHandler(SceneType.Robot, "/robotwjconsolecallback")]
    public class HttpRobotCallBackHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;
            RobotManagerComponent robotManager = entity.GetComponent<RobotManagerComponent>();      
            int param1 = int.Parse(queryString["param1"]);

            List<StartSceneConfig> processScenes = StartSceneConfigCategory.Instance.GetByProcess(1);
            StartSceneConfig startSceneConfig = processScenes[0];
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(startSceneConfig.Zone, startSceneConfig.Name).InstanceId;
            A2R_Broadcast createUnit = (A2R_Broadcast)await ActorMessageSenderComponent.Instance.Call(
                mapInstanceId, new R2A_Broadcast() { LoadType = param1 });

            await ETTask.CompletedTask;
        }
    }

    [ObjectSystem]
    public class RobotManagerComponentAwakeSystem : AwakeSystem<RobotManagerComponent>
    {
        public override void Awake(RobotManagerComponent self)
        {
            self.RobotNumber.Clear();
            self.ZoneIndex = Game.Options.Process * 10000;
        }
    }

    public static class RobotManagerComponentSystem
    {
        private static readonly object RobotNumberLock = new object();

        public static async ETTask RemoveRobot(this RobotManagerComponent self, Scene robotScene, string exitType)
        {
            //self.ZoneIndex--;
            if (self == null || robotScene.GetComponent<BehaviourComponent>() == null)
            {
                return;
            }
            int robotId = robotScene.GetComponent<BehaviourComponent>().RobotConfig.Id;
            lock (RobotNumberLock)
            {
                if (self.RobotNumber.TryGetValue(robotId, out int n))
                {
                    self.RobotNumber[robotId] = Math.Max(0, n - 1);
                }
            }
            Log.Debug($"机器人退出： {exitType}");
            Console.WriteLine($"机器人退出222 Account:  {robotScene.GetComponent<AccountInfoComponent>().Account}");
            robotScene.GetComponent<SessionComponent>().Session.Dispose();
            await TimerComponent.Instance.WaitAsync(200);
            robotScene.Dispose();
        }

        public static async ETTask RemoveRobot_2(this RobotManagerComponent self, Scene robotScene, string exitType)
        {
            //self.ZoneIndex--;
            //if (self == null || robotScene.GetComponent<BehaviourComponent>() == null)
            //{
            //    return;
            //}

            //Log.Debug($"机器人掉线退出：{robotScene.Id}");
            //robotScene.GetComponent<SessionComponent>().Session.Dispose();
            //await TimerComponent.Instance.WaitAsync(200);
            //robotScene.Dispose();
            await ETTask.CompletedTask;
        }

        public static async ETTask<Scene> NewRobot_2(this RobotManagerComponent self, int zone, int robotZone, int robotId, string account, string passward)
        {
            Scene zoneScene = null;
            try
            {
                //同一个进程robotZone是自增的
                zoneScene = SceneFactory.CreateZoneScene(robotZone, "Robot", self);
                bool innernet = ComHelp.IsInnerNet();
                int registerCode = await LoginHelper.Register(zoneScene, !innernet, VersionMode.Beta, account, passward, 0, zone);

                string adress = ServerHelper.GetServerIpList(innernet, zone);
                string[] serverdomain = adress.Split(':');
                if (!serverdomain[0].Contains("127.0.0.1")
                 && !serverdomain[0].Contains("192")
                 && !serverdomain[0].Contains("39")
                 && !serverdomain[0].Contains("8.221.119.18")
                 && !serverdomain[0].Contains("47.94.107.92"))
                {
                    IPAddress[] xxc = Dns.GetHostEntry(serverdomain[0]).AddressList;
                    adress = $"{xxc[0]}:{serverdomain[1]}";
                }

                Log.Console($"NewRobot:{adress} {robotZone}  {account}");
                int errorCode = await LoginHelper.Login(zoneScene, adress, account, passward, false, string.Empty, "0", string.Empty);
                Session session = zoneScene.GetComponent<SessionComponent>().Session;
                if (session == null)
                {
                    Log.Console($"session == null  {robotZone}  {account}");
                    return null;
                }
                if (registerCode == ErrorCode.ERR_Success)
                {
                    A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(zoneScene, 1, self.Parent.GetComponent<RandNameComponent>().GetRandomName(zone));
                    AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                    if (playerComponent == null || g2cCreateRole.createRoleInfo == null)
                    {
                        return null;
                    }
                    playerComponent.ServerId = zone;
                    playerComponent.CurrentRoleId = g2cCreateRole.createRoleInfo.UserID;
                    playerComponent.Account = account;

                    errorCode = await LoginHelper.GetRealmKey(zoneScene);
                    errorCode = await LoginHelper.EnterGame(zoneScene, "", false, 0); 
                    Log.Console($"create robot ok: {robotZone}");
                }
                else if (registerCode == ErrorCode.ERR_AccountAlreadyRegister)
                {
                    AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                    if (playerComponent.CreateRoleList.Count > 0)
                    {
                        playerComponent.ServerId = zone;
                        playerComponent.CurrentRoleId = playerComponent.CreateRoleList[0].UserID;

                        errorCode = await LoginHelper.GetRealmKey(zoneScene);
                        errorCode = await LoginHelper.EnterGame(zoneScene, "", false, 0);
                        Log.Debug($"create robot ok: {robotZone}");
                    }
                    else
                    {
                        Log.Debug($"{account}  {zone} 角色为空");

                        A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(zoneScene, 1, self.Parent.GetComponent<RandNameComponent>().GetRandomName(zone));
                        playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                        if (playerComponent == null || g2cCreateRole.createRoleInfo == null)
                        {
                            return null;
                        }
                        Log.Debug($"{account}  {zone} 创角成功");
                        playerComponent.ServerId = zone;
                        playerComponent.CurrentRoleId = g2cCreateRole.createRoleInfo.UserID;
                        playerComponent.Account = account;

                        errorCode = await LoginHelper.GetRealmKey(zoneScene);
                        errorCode = await LoginHelper.EnterGame(zoneScene, string.Empty, false, 0);
                        Log.Debug($"create robot ok: {robotZone}");
                    }
                }
                else
                {
                    Log.Debug($"create robot error: {robotZone}");
                }

                return errorCode == ErrorCode.ERR_Success ? zoneScene : null;
            }
            catch (Exception e)
            {
                zoneScene?.Dispose();
                throw new Exception($"RobotSceneManagerComponent create robot fail, zone: {robotZone}", e);
            }
        }

        public static async ETTask<Scene> NewRobotBatch(this RobotManagerComponent self, int zone, int robotZone, int robotId, int robotIndex)
        {
            int robotNumber = self.AllocRobotNumber(robotId);

            Log.Console($"NewRobotBatch robotNumber: {robotNumber}  robotIndex: {robotIndex}");

            robotNumber += robotIndex;

            string account = $"{robotId}_{zone}_{robotNumber}_0617";   //服务器

            Log.Console($"NewRobotBatch: {account}");

            Scene robotScene = await self.NewRobot_2(zone, robotZone, robotId, account, ComHelp.RobotPassWord);
            return robotScene;
        }

        public static int AllocRobotZoneIndex(this RobotManagerComponent self) => NextId(ref self.ZoneIndex);

        public static int AllocRobotNumber(this RobotManagerComponent self, int robotId)
        {
            lock (RobotNumberLock)
            {
                self.RobotNumber.TryGetValue(robotId, out int n);
                self.RobotNumber[robotId] = n + 1;
                return n;
            }
        }

        private static int NextId(ref int value)
        {
            lock (RobotNumberLock) { return value++; }
        }

        // Message 格式: "201,202,203,..." 全区轮询登录
        public static async ETTask RunBattleOpenRobots(this RobotManagerComponent self, string zonesMessage)
        {
            int robotId = BattleHelper.GetBattleRobotId(3, 0);
            if (robotId == 0)
            {
                Log.Warning("战场机器人配置缺失 behaviour=3");
                return;
            }

            if (string.IsNullOrEmpty(zonesMessage))
            {
                Log.Warning("战场机器人区列表为空");
                return;
            }

            lock (RobotNumberLock)
            {
                if (self.BattleOpenRunning)
                {
                    return;
                }

                self.BattleOpenOk.Clear();
                foreach (string part in zonesMessage.Split(','))
                {
                    if (int.TryParse(part, out int zone))
                    {
                        self.BattleOpenOk[zone] = 0;
                    }
                }

                if (self.BattleOpenOk.Count == 0)
                {
                    Log.Warning($"战场机器人区列表解析失败: {zonesMessage}");
                    return;
                }

                self.BattleOpenRunning = true;
                RunBattleOpenRoundRobin(self, robotId).Coroutine();
            }

            await ETTask.CompletedTask;
        }

        private static async ETTask RunBattleOpenRoundRobin(RobotManagerComponent self, int robotId)
        {
            const int maxRound = 12;
            const int targetOk = 2;

            List<int> zones;
            lock (RobotNumberLock)
            {
                zones = self.BattleOpenOk.Keys.OrderBy(z => z).ToList();
            }

            for (int round = 0; round < maxRound; round++)
            {
                foreach (int zone in zones)
                {
                    lock (RobotNumberLock)
                    {
                        if (self.BattleOpenOk[zone] >= targetOk)
                        {
                            continue;
                        }
                    }

                    if (await TryBattleOpenRobot(self, zone, robotId))
                    {
                        lock (RobotNumberLock)
                        {
                            self.BattleOpenOk[zone]++;
                        }
                    }

                    await TimerComponent.Instance.WaitAsync(500);
                }

                lock (RobotNumberLock)
                {
                    if (self.BattleOpenOk.Values.All(v => v >= targetOk))
                    {
                        break;
                    }
                }
            }

            lock (RobotNumberLock)
            {
                foreach (KeyValuePair<int, int> kv in self.BattleOpenOk)
                {
                    Log.Debug($"战场机器人 zone={kv.Key} success={kv.Value}");
                }

                self.BattleOpenOk.Clear();
                self.BattleOpenRunning = false;
            }
        }

        private static async ETTask<bool> TryBattleOpenRobot(RobotManagerComponent self, int zone, int robotId)
        {
            try
            {
                Scene scene = await self.NewRobot(zone, self.AllocRobotZoneIndex(), robotId);
                if (scene == null)
                {
                    await TimerComponent.Instance.WaitAsync(300);
                    return false;
                }

                scene.AddComponent<BehaviourComponent, int>(robotId);
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"战场机器人异常 zone={zone}: {e}");
                return false;
            }
        }

        public static async ETTask<Scene> NewRobot(this RobotManagerComponent self, int zone, int robotZone, int robotId)
        {
            int robotNumber = self.AllocRobotNumber(robotId);
            string account = $"{robotId}_{zone}_{robotNumber}_0617";   //服务器

            return await self.NewRobot_2(zone, robotZone, robotId, account, ComHelp.RobotPassWord);
            //同一个进程robotZone是自增的
            //zoneScene = SceneFactory.CreateZoneScene(robotZone, "Robot", self);
            //string account = $"{robotId}_{zone}_{robotNumber}_0221";    //本地
            //bool innernet = ComHelp.IsInnerNet();
            //VersionMode versionMode = VersionMode.BanHao;
            //VersionMode versionMode = VersionMode.Beta;
            //    int registerCode = await LoginHelper.Register(zoneScene, !innernet, versionMode, account, ComHelp.RobotPassWord);
            //    string adress = ServerHelper.GetServerIpList(innernet, zone);
            //    string[] serverdomain = adress.Split(':');
            //    if (!serverdomain[0].Contains("127.0.0.1")
            //     && !serverdomain[0].Contains("192")
            //     && !serverdomain[0].Contains("39")
            //     && !serverdomain[0].Contains("47.94.107.92"))
            //    {
            //        IPAddress[] xxc = Dns.GetHostEntry(serverdomain[0]).AddressList;
            //        adress = $"{xxc[0]}:{serverdomain[1]}";
            //    }

            //    Log.Console($"NewRobot:{adress} {robotZone}  {account}");
            //    int errorCode = await LoginHelper.Login(zoneScene, adress, account, ComHelp.RobotPassWord);
            //    Session session = zoneScene.GetComponent<SessionComponent>().Session;
            //    if (session == null)
            //    {
            //        Log.Console($"session == null  {robotZone}  {account}");
            //        return null;
            //    }
            //    if (registerCode == ErrorCode.ERR_Success)
            //    {
            //        A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(zoneScene, 1, self.Parent.GetComponent<RandNameComponent>().GetRandomName());
            //        AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
            //        if (playerComponent == null || g2cCreateRole.createRoleInfo == null)
            //        {
            //            return null;
            //        }
            //        playerComponent.ServerId = zone;
            //        playerComponent.CurrentRoleId = g2cCreateRole.createRoleInfo.UserID;

            //        errorCode = await LoginHelper.GetRealmKey(zoneScene);
            //        errorCode = await LoginHelper.EnterGame(zoneScene, "", false, 0);
            //        Log.Console($"create robot ok: {robotZone}");
            //    }
            //    else if (registerCode == ErrorCode.ERR_AccountAlreadyRegister)
            //    {
            //        AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
            //        if (playerComponent.CreateRoleList.Count > 0)
            //        {
            //            playerComponent.ServerId = zone;
            //            playerComponent.CurrentRoleId = playerComponent.CreateRoleList[0].UserID;

            //            errorCode = await LoginHelper.GetRealmKey(zoneScene);
            //            errorCode = await LoginHelper.EnterGame(zoneScene, "", false, 0 );
            //            Log.Debug($"create robot ok: {robotZone}");
            //        }
            //        else
            //        {
            //            Log.Debug($"{account}  {zone} 角色为空");
            //            //await TimerComponent.Instance.WaitAsync(200);
            //            //zoneScene?.Dispose();
            //            //return null;

            //            A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(zoneScene, 1, self.Parent.GetComponent<RandNameComponent>().GetRandomName());
            //            playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
            //            if (playerComponent == null || g2cCreateRole.createRoleInfo == null)
            //            {
            //                return null;
            //            }
            //            Log.Debug($"{account}  {zone} 创角成功");
            //            playerComponent.ServerId = zone;
            //            playerComponent.CurrentRoleId = g2cCreateRole.createRoleInfo.UserID;

            //            errorCode = await LoginHelper.GetRealmKey(zoneScene);
            //            errorCode = await LoginHelper.EnterGame(zoneScene, "", false, 0 );
            //            Log.Debug($"create robot ok: {robotZone}");
            //        }
            //    }
            //    else
            //    {
            //        Log.Debug($"create robot error: {robotZone}");
            //    }

            //    return errorCode == ErrorCode.ERR_Success ?  zoneScene : null;
            //}
            //catch (Exception e)
            //{
            //    zoneScene?.Dispose();
            //    throw new Exception($"RobotSceneManagerComponent create robot fail, zone: {robotZone}", e);
            //}
        }
        
        public static void RemoveAll(this RobotManagerComponent self)
        {
            foreach (Entity robot in self.Children.Values.ToArray())        
            {
                robot.Dispose();
            }
        }
        
        public static void Remove(this RobotManagerComponent self, long id)
        {
            self.GetChild<Scene>(id)?.Dispose();
        }

        public static void Clear(this RobotManagerComponent self)
        {
            foreach (Entity entity in self.Children.Values.ToArray())
            {
                entity.Dispose();
            }
        }
    }
}