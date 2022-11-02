using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.RefreshMonsterTimer)]
    public class YeWaiRefreshTimer : ATimer<YeWaiRefreshComponent>
    {
        public override void Run(YeWaiRefreshComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class YeWaiRefreshComponentAwakeSystem : AwakeSystem<YeWaiRefreshComponent>
    {
        public override void Awake(YeWaiRefreshComponent self)
        {
            
        }
    }

    [ObjectSystem]
    public class YeWaiRefreshComponentDestroySystem : DestroySystem<YeWaiRefreshComponent>
    {
        public override void Destroy(YeWaiRefreshComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class YeWaiRefreshComponentSystem
    {

        public static void OnAwake(this YeWaiRefreshComponent self, int sceneId)
        {
            if (sceneId == 0)
            {
                return;
            }
            Scene scene = self.GetParent<Scene>();
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
            string timingMonster = sceneConfig.CreateMonster;
            string[] monsters = timingMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (string.IsNullOrEmpty(monsters[i]))
                {
                    continue;
                }
                //3;-63.68,0.00,-19.01;71010001;1,1,100,600
                string[] mondels = monsters[i].Split(';');
                string mtype = mondels[0];
                string[] position = mondels[1].Split(',');
                string monsterid = mondels[2];
                string[] mcount = mondels[3].Split(',');
               
                if (mtype == "3")    //定时刷新
                {
                    //long leftTime = self.LeftTime(timers[t]);
                    //if (leftTime == 0)
                    //{
                    //    continue;
                    //}
                    self.RefreshMonsters.Add(new RefreshMonster()
                    {
                        MonsterId = int.Parse(monsterid),
                        NextTime = TimeHelper.ServerNow() + int.Parse(mcount[2])*1000,
                        PositionX = float.Parse(position[0]),
                        PositionY = float.Parse(position[1]),
                        PositionZ = float.Parse(position[2]),
                        Number = int.Parse(mcount[0]),
                        Range = int.Parse(mcount[1]),
                        Interval = int.Parse(mcount[3]) * 1000,
                    });
                }
            }
            FubenHelp.CreateMonsterList(scene, timingMonster, FubenDifficulty.Normal);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.RefreshMonsterTimer, self);
        }

        public static long LeftTime(this YeWaiRefreshComponent self, string targetTime)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;
            int time1 = huor * 3600 + minute * 60 + second;

            int targetHour = int.Parse(targetTime.Substring(0, 2));
            int targetMinute = int.Parse(targetTime.Substring(2, 2));
            int time2 = targetHour * 3600 + targetMinute * 60;
            if (time2 <= time1)
            {
                return 0;
            }
            return (time2 - time1) * 1000;
        }

        public static void OnTimer(this YeWaiRefreshComponent self)
        {
            long time = TimeHelper.ServerNow();
            for (int i = self.RefreshMonsters.Count - 1; i >= 0; i--)
            {
                RefreshMonster refreshMonster = self.RefreshMonsters[i];
                if (time < refreshMonster.NextTime)
                {
                    continue;
                }

                DateTime dateTime =  TimeHelper.DateTimeNow();
                Log.Info($"CreateMonsters: {dateTime.ToString()}");

                //根据refreshMonster.Time可以纠正时间
                refreshMonster.NextTime = refreshMonster.NextTime + refreshMonster.Interval;
                self.RefreshMonsters[i] = refreshMonster;

                self.CreateMonsters(refreshMonster);
            }
        }

        public static  void CreateMonsters(this YeWaiRefreshComponent self, RefreshMonster refreshMonster)
        {
            //防止无限刷宝箱
            int monsterNumber = 0;
            List<Unit>  entities = self.GetParent<Scene>().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Type == UnitType.Monster)
                {
                    monsterNumber++;
                }
            }
            if (monsterNumber >= 200)
            {
                return;
            }

            for (int i = 0; i < refreshMonster.Number; i++)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(refreshMonster.MonsterId);
                float range = refreshMonster.Range;
                Vector3 form = new Vector3(refreshMonster.PositionX, refreshMonster.PositionY, refreshMonster.PositionZ);
                Vector3 to = new Vector3(form.x + RandomHelper.RandomNumberFloat(-1 * range, range), form.y, form.z + RandomHelper.RandomNumberFloat(-1 * range, range));
                Vector3 vector3 = self.DomainScene().GetComponent<MapComponent>().GetCanReachPath(form, to);
                UnitFactory.CreateMonster(self.GetParent<Scene>(), refreshMonster.MonsterId, vector3, new CreateMonsterInfo()
                { Camp = monsterConfig.MonsterCamp, FubenDifficulty = FubenDifficulty.Normal });
            }
        }

        public static void OnKillEvent(this YeWaiRefreshComponent self, Unit defend)
        {
            if (defend.Type != UnitType.Monster)
            {
                return;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(defend.ConfigId);
            if (monsterConfig.ReviveTime == 0)
            {
                return;
            }
            //AIComponent aiComponent = defend.GetComponent<AIComponent>();
            //self.RefreshMonsters.Add(new RefreshMonster()
            //{
            //    MonsterId = unitInfoComponent.UnitCondigID,
            //    RefresType = 2,
            //    RefreshTime = TimeHelper.ServerNow() + monsterConfig.Resurrection * 1000,
            //    PositionX = aiComponent.InitVec3.x,
            //    PositionY = aiComponent.InitVec3.y,
            //    PositionZ = aiComponent.InitVec3.z, 
            //});
        }
    }
}
