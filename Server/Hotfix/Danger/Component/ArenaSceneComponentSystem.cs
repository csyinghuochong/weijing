using System;

namespace ET
{

    [Timer(TimerType.ArenaSceneTimer)]
    public class ArenaTimer : ATimer<ArenaSceneComponent>
    {
        public override void Run(ArenaSceneComponent self)
        {
            try
            {
                self.OnCheck();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }


    public class ArenaSceneComponentAwake : AwakeSystem<ArenaSceneComponent>
    {
        public override void Awake(ArenaSceneComponent self)
        {
            self.CheckTimer();
        }
    }

    public class ArenaSceneComponentDestroy : DestroySystem<ArenaSceneComponent>
    {
        public override void Destroy(ArenaSceneComponent self)
        {
        }
    }

    public static  class ArenaSceneComponentSystem
    {

        public static void OnZeroClockUpdate(this ArenaSceneComponent self)
        {
            LogHelper.LogDebug("Arena:  OnZeroClockUpdate");
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = 0;
            self.AreneSceneStatu = 0;
            self.BeginTimer();
        }

        public static void CheckTimer(this ArenaSceneComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            int curTime = dateTime.Hour * 60 + dateTime.Minute;

            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1031);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime = int.Parse(openTimes[0].Split(';')[0]) * 60 + int.Parse(openTimes[0].Split(';')[1]);
            int closeTime = int.Parse(openTimes[1].Split(';')[0]) * 60 + int.Parse(openTimes[1].Split(';')[1]);
            int overTime = int.Parse(openTimes[2].Split(';')[0]) * 60 + int.Parse(openTimes[2].Split(';')[1]);

            if (curTime < openTime)
            {
                self.AreneSceneStatu = 0;
            }
            else if (curTime < closeTime)
            {
                self.AreneSceneStatu = 1;
                self.CanEnter = true;
            }
            else if (curTime < overTime)
            {
                self.AreneSceneStatu = 2;
                self.CanEnter = false;
            }
            else
            {
                return;
            }
            TimerComponent.Instance.Remove(ref self.Timer);
            self.BeginTimer();
        }

        public static void BeginTimer(this ArenaSceneComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            int curTime = dateTime.Hour * 60 + dateTime.Minute;

            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1031);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime = int.Parse(openTimes[0].Split(';')[0]) * 60 + int.Parse(openTimes[0].Split(';')[1]);
            if (curTime < openTime && self.AreneSceneStatu== 0)
            {
                self.AreneSceneStatu = 1;
                self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Minute * (openTime - curTime), TimerType.ArenaSceneTimer, self);
                return;
            }

            int closeTime = int.Parse(openTimes[1].Split(';')[0]) * 60 + int.Parse(openTimes[1].Split(';')[1]);
            if (curTime < closeTime && self.AreneSceneStatu == 1)
            {
                self.AreneSceneStatu = 2;
                self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow()+ TimeHelper.Minute * (closeTime- curTime), TimerType.ArenaSceneTimer,self);
                return;
            }

            int overTime = int.Parse(openTimes[2].Split(';')[0]) * 60 + int.Parse(openTimes[2].Split(';')[1]);
            if (curTime < overTime && self.AreneSceneStatu == 2)
            {
                self.AreneSceneStatu = 3;
                self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Minute * (overTime - curTime), TimerType.ArenaSceneTimer, self);
            }
        }

        public static void OnArenaOpen(this ArenaSceneComponent self)
        {
            self.CanEnter = true;
            if (DBHelper.GetOpenServerDay(self.DomainZone()) > 0)
            {
                LogHelper.LogWarning($"OnArenaOpen：{self.DomainZone()}", true);
                //long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                //MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.ArenaOpen });
            }
            foreach (var item in self.Children)
            {
                Scene scene = item.Value as Scene;
                scene.GetComponent<ArenaDungeonComponent>().OnArenaOpen();
            }
        }

        public static void OnCheck(this ArenaSceneComponent self)
        {
            if (self.AreneSceneStatu == 1)
            { 
                self.OnArenaOpen();
            }
            if (self.AreneSceneStatu == 2)
            {
                self.OnArenaClose();
            }
            if (self.AreneSceneStatu == 3)
            {
                self.OnArenaOver().Coroutine();
            }

            self.BeginTimer();
        }

        public static void OnArenaClose(this ArenaSceneComponent self)
        {
            LogHelper.LogWarning($"OnArenaClose： {self.DomainZone()}", true);
            self.CanEnter = false;
            foreach (var item in self.Children)
            {
                Scene scene = item.Value as Scene;
                scene.GetComponent<ArenaDungeonComponent>().OnArenaClose();
            }
        }

        public static async ETTask OnArenaOver(this ArenaSceneComponent self)
        {
            LogHelper.LogWarning($"OnArenaOver：{self.DomainZone()}", true);
            foreach (var item in self.Children)
            {
                Scene scene = item.Value as Scene;
                await scene.GetComponent<ArenaDungeonComponent>().OnArenaOver();
                await TimerComponent.Instance.WaitAsync(60000);
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
        }

        public static long GetArenaInstanceId(this ArenaSceneComponent self, long unitId, int sceneId)
        {
            if (!self.CanEnter)
            { 
                return 0;
            }
            ArenaInfo battleInfo = null;
            foreach (var item in self.Children)
            {
                Scene scene = item.Value as Scene;
                battleInfo = scene.GetComponent<ArenaInfo>();
                if (battleInfo.SceneId != sceneId)
                {
                    continue;
                }

                if (battleInfo.PlayerList.ContainsKey(unitId))
                {
                    return battleInfo.FubenInstanceId;
                }

                if (battleInfo.PlayerList.Count < ComHelp.GetPlayerLimit(sceneId))
                {
                    battleInfo.PlayerList.Add(unitId, new ArenaPlayerStatu() { UnitId = unitId });
                    return battleInfo.FubenInstanceId;
                }
            }

            //动态创建副本
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "Battle" + fubenid.ToString(), SceneType.Fuben);
            fubnescene.AddComponent<ArenaDungeonComponent>();
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Arena, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            fubnescene.AddComponent<YeWaiRefreshComponent>().SceneId = sceneId;
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonster);
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonsterPosi);
            battleInfo = fubnescene.AddComponent<ArenaInfo>();
            battleInfo.FubenId = fubenid;
            battleInfo.PlayerList.Add(unitId, new ArenaPlayerStatu() { UnitId = unitId });
            battleInfo.FubenInstanceId = fubenInstanceId;
            battleInfo.SceneId = sceneId;
            return battleInfo.FubenInstanceId;
        }

    }
}
