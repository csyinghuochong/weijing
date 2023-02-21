using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [Timer(TimerType.ArenaTimer)]
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
            self.OnZeroClockUpdate();
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
            self.ArenaSceneClose = false;
            self.ArenaSceneOver = false;
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = 0;
            self.OnArenaOver().Coroutine();
            self.BeginTimer();
        }

        public static void BeginTimer(this ArenaSceneComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();

            int curTime = dateTime.Hour * 60 + dateTime.Minute;

            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1031);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime = int.Parse(openTimes[0].Split(';')[0]) * 60 + int.Parse(openTimes[0].Split(';')[1]);
            
            int closeTime = int.Parse(openTimes[1].Split(';')[0]) * 60 + int.Parse(openTimes[1].Split(';')[1]);
            if (curTime < closeTime)
            {
                self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow()+ TimeHelper.Minute * (closeTime- curTime), TimerType.ArenaTimer,self);
                return;
            }

            int overTime = int.Parse(openTimes[2].Split(';')[0]) * 60 + int.Parse(openTimes[2].Split(';')[1]);
            if (curTime < overTime)
            {
                self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Minute * (overTime - curTime), TimerType.ArenaTimer, self);
            }
        }

        public static void OnCheck(this ArenaSceneComponent self)
        {
            if (!self.ArenaSceneClose)
            {
                self.ArenaSceneClose = true;
                self.OnArenaClose();
            }
            if (!self.ArenaSceneOver)
            {
                self.ArenaSceneOver = true;
                self.OnArenaOver().Coroutine();
            }
        }

        public static void OnArenaClose(this ArenaSceneComponent self)
        {
            Log.Debug($"OnArenaClose： {self.DomainZone()}");
            foreach (var item in self.Children)
            {
                Scene scene = item.Value as Scene;
                scene.GetComponent<ArenaDungeonComponent>().OnArenaClose();
            }
        }

        public static async ETTask OnArenaOver(this ArenaSceneComponent self)
        {
            Log.Debug($"OnArenaClose： {self.OnArenaOver()}");
            foreach (var item in self.Children)
            {
                Scene scene = item.Value as Scene;
                await scene.GetComponent<ArenaDungeonComponent>().OnArenaOver();
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
        }

        public static long GetArenaInstanceId(this ArenaSceneComponent self, long unitId, int sceneId)
        {
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
                    battleInfo.PlayerList.Add(unitId, new ArenaPlayerStatu() {  });
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
            battleInfo.PlayerList.Add(unitId, new ArenaPlayerStatu() { });
            battleInfo.FubenInstanceId = fubenInstanceId;
            battleInfo.SceneId = sceneId;
            return battleInfo.FubenInstanceId;
        }

    }
}
