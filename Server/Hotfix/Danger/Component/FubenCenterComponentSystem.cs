using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ObjectSystem]
    public class FubenCenterComponentAwakeSystem : AwakeSystem<FubenCenterComponent>
    {
        public override void Awake(FubenCenterComponent self)
        {
            self.FubenInstanceList.Clear();
            self.YeWaiFubenList.Clear();

            self.InitYeWaiScene().Coroutine();
        }
    }

    public static class FubenCenterComponentSystem
    {
        public static int GetScenePlayer(this FubenCenterComponent self, long instanced)
        { 
            foreach((long id, Entity Entity) in self.Children)
            {
                if (Entity.InstanceId != instanced)
                {
                    continue;
                }
                return UnitHelper.GetUnitList(Entity as Scene, UnitType.Player).Count;
            }
            return 0;
        }

        public static void OnActivityOpen(this FubenCenterComponent self, int functionId)
        {
            if (functionId == 1058)
            { 
                self.RunRaceOpen = true;
                self.RunRacePlayerList.Clear();
            }
            if (functionId == 1059)
            { 
                self.DemonOpen = true;  
                self.DemonPlayerList.Clear();   
            }
            //Log.Console($"OnActivityOpen: {functionId}");
        }

        public static void OnActivityClose(this FubenCenterComponent self, int functionId)
        {
            if (functionId == 1058)
            {
                self.RunRaceOpen = false;
            }
            if (functionId == 1059)
            {
                self.DemonOpen = false;
            }
            self.DisposeFuben(functionId).Coroutine();
            //Log.Console($"OnActivityClose: {functionId}");
        }

        public static long GetFunctionFubenId(this FubenCenterComponent self, int functionId, long unitId)
        {
            Dictionary<long, List<long>> playerList = null;
            if (functionId == 1058)
            {
                playerList = self.RunRacePlayerList;
            }
            if (functionId == 1059)
            {
                playerList = self.DemonPlayerList;
            }
            if (playerList == null)
            {
                return 0;
            }

            foreach ((long id, List<long> players) in playerList)
            {
                Scene scene = self.GetChild<Scene>(id);
                if (scene == null)
                {
                    Log.Error("scene == null");
                    continue;
                }

                if (players.Contains(unitId))
                {
                    return scene.InstanceId;
                }

                if (players.Count < 20)
                {
                    players.Add(unitId);
                    return scene.InstanceId;
                }
            }

            //动态创建副本.....RecastPathComponent.awake寻路
            int sceneid = 0;
            if (functionId == 1058)
            {
                sceneid = BattleHelper.GetSceneIdByType(SceneTypeEnum.RunRace);
            }
            if (functionId == 1059)
            {
                sceneid = BattleHelper.GetSceneIdByType(SceneTypeEnum.Demon);
            }
            if (sceneid == 0)
            {
                return 0;
            }

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneid);
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Log.Warning($"GenarateFuben2.{fubenInstanceId}");

            self.FubenInstanceList.Add(fubenInstanceId);
            //self.YeWaiFubenList.Add(sceneConfig.Id, fubenInstanceId);  可能有多个不能这样搞

            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "Fuben" + sceneConfig.Id.ToString(), SceneType.Map);
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo(sceneConfig.MapType, sceneConfig.Id, 0);
            mapComponent.NavMeshId = sceneConfig.MapID;
            Game.Scene.GetComponent<RecastPathComponent>().Update(mapComponent.NavMeshId);
            fubnescene.GetComponent<ServerInfoComponent>().ServerInfo = self.ServerInfo;
            YeWaiRefreshComponent yeWaiRefreshComponen = fubnescene.AddComponent<YeWaiRefreshComponent>();
            yeWaiRefreshComponen.SceneId = sceneConfig.Id;

            switch (sceneConfig.MapType)
            {
                case SceneTypeEnum.RunRace:
                    fubnescene.AddComponent<RunRaceDungeonComponent>();

                    fubnescene.GetComponent<RunRaceDungeonComponent>().OnBegin();
                    break;
                case SceneTypeEnum.Demon:
                    fubnescene.AddComponent<DemonDungeonComponent>();
                    fubnescene.GetComponent<DemonDungeonComponent>().OnBegin();
                    break;
                default:
                    break;
            }

            FubenHelp.CreateMonsterList(fubnescene, sceneConfig.CreateMonster);
            FubenHelp.CreateMonsterList(fubnescene, sceneConfig.CreateMonsterPosi);

            playerList.Add( fubenid, new List<long>() { unitId } );

            return fubenInstanceId;
        }


        /// <summary>
        /// 活动关闭 ，一段时间后销毁副本
        /// </summary>
        /// <param name="self"></param>
        /// <param name="functionId"></param>
        /// <returns></returns>
        public static async ETTask DisposeFuben(this FubenCenterComponent self, int functionId)
        {
            long waitDisposeTime = 0;

            Dictionary<long, List<long>> playerList = null;
            if (functionId == 1058)
            {
                playerList = self.RunRacePlayerList;
            }
            if (functionId == 1059)
            {
                playerList = self.DemonPlayerList;
            }
            if (playerList == null)
            {
                return;
            }

            switch (functionId)
            {
                case 1058:
                    Scene scene = null;
                    foreach ((long id, List<long> players) in playerList)
                    {
                        scene = self.GetChild<Scene>(id);
                        if (scene == null)
                        {
                            Log.Error($"scene == null");
                            break;
                        }
                        scene.GetComponent<RunRaceDungeonComponent>().OnClose();
                    }

                    FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1058);
                    string[] openTimes = funtionConfig.OpenTime.Split('@');

                    int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
                    int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
                    long closeTime = (closeTime_1 * 60 + closeTime_2) * 60;

                    int endTime_1 = int.Parse(openTimes[2].Split(';')[0]);
                    int endTime_2 = int.Parse(openTimes[2].Split(';')[1]);
                    long endTime = (endTime_1 * 60 + endTime_2) * 60;

                    waitDisposeTime = (endTime - closeTime) * 1000;
                    break;
                case 1059:
                    scene = null;
                    foreach ((long id, List<long> players) in playerList)
                    {
                        scene = self.GetChild<Scene>(id);
                        if (scene == null)
                        {
                            Log.Error($"scene == null");
                            break;
                        }
                        scene.GetComponent<DemonDungeonComponent>().OnClose();
                    }

                    funtionConfig = FuntionConfigCategory.Instance.Get(1059);
                    openTimes = funtionConfig.OpenTime.Split('@');

                     closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
                     closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
                     closeTime = (closeTime_1 * 60 + closeTime_2) * 60;

                     endTime_1 = int.Parse(openTimes[2].Split(';')[0]);
                     endTime_2 = int.Parse(openTimes[2].Split(';')[1]);
                     endTime = (endTime_1 * 60 + endTime_2) * 60;

                    waitDisposeTime = (endTime - closeTime) * 1000;
                    break;
            }

            await TimerComponent.Instance.WaitAsync(waitDisposeTime);

            foreach ( (long id, Entity Entity) in self.Children)
            {
                if (Entity.GetComponent<MapComponent>()== null)
                {
                    continue;
                }
               
                if (!playerList.ContainsKey(  Entity.Id) )
                {
                    continue;
                }

                if (playerList.ContainsKey(Entity.Id))
                {
                    playerList.Remove(Entity.Id);
                    Log.Warning($"DisposeFubenId; {functionId} {Entity.Id}");
                }

                long instanceid = Entity.InstanceId;
                if (self.FubenInstanceList.Contains(instanceid))
                {
                    self.FubenInstanceList.Remove(instanceid);
                    Log.Warning($"DisposeFubenInstance; {functionId}  {instanceid}");
                }
              
                Scene scene = Entity as Scene;
                Actor_TransferRequest actor_Transfer = new Actor_TransferRequest()
                {
                    SceneType = SceneTypeEnum.MainCityScene,
                };
                List<Unit> units = scene.GetComponent<UnitComponent>().GetAll();
                for (int i = 0; i < units.Count; i++)
                {
                    if (units[i].Type != UnitType.Player)
                    {
                        continue;
                    }
                    if (units[i].IsDisposed || units[i].IsRobot())
                    {
                        continue;
                    }
                    TransferHelper.TransferUnit(units[i], actor_Transfer).Coroutine();
                }

                await TimerComponent.Instance.WaitAsync(60000 + RandomHelper.RandomNumber(0, 1000));
                scene.Dispose();
                break;
            }
        }

        public static async ETTask  InitYeWaiScene(this FubenCenterComponent self)
        {
            await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(0, 1000));
           
            List<SceneConfig> sceneConfigs =  SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != SceneTypeEnum.BaoZang 
                && sceneConfigs[i].MapType != SceneTypeEnum.MiJing )
                {
                    continue;
                }

                //动态创建副本.....RecastPathComponent.awake寻路
                long fubenid = IdGenerater.Instance.GenerateId();
                long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();

                self.FubenInstanceList.Add(fubenInstanceId);
                self.YeWaiFubenList.Add(sceneConfigs[i].Id, fubenInstanceId);

                Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "YeWai" + sceneConfigs[i].Id.ToString(), SceneType.Map);
                MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
                mapComponent.SetMapInfo(sceneConfigs[i].MapType, sceneConfigs[i].Id, 0);
                mapComponent.NavMeshId = sceneConfigs[i].MapID; 
                fubnescene.GetComponent<ServerInfoComponent>().ServerInfo = self.ServerInfo;
                YeWaiRefreshComponent yeWaiRefreshComponen = fubnescene.AddComponent<YeWaiRefreshComponent>();
                yeWaiRefreshComponen.SceneId = sceneConfigs[i].Id;
                
                switch (sceneConfigs[i].MapType)
                {
                    case SceneTypeEnum.MiJing:
                        fubnescene.AddComponent<MiJingComponent>();
                        break;
                    default:
                        break;
                }

                FubenHelp.CreateMonsterList(fubnescene, sceneConfigs[i].CreateMonster);
                FubenHelp.CreateMonsterList(fubnescene, sceneConfigs[i].CreateMonsterPosi);

                int openDay = DBHelper.GetOpenServerDay(self.DomainZone());
                yeWaiRefreshComponen.OnZeroClockUpdate(openDay);
            }
        }
    }
}
