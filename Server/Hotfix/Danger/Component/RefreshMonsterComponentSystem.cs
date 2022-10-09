using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.RefreshMonsterTimer)]
    public class RefreshMonsterTimer : ATimer<RefreshMonsterComponent>
    {
        public override void Run(RefreshMonsterComponent self)
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
    public class RefreshMonsterComponentAwakeSystem : AwakeSystem<RefreshMonsterComponent>
    {
        public override void Awake(RefreshMonsterComponent self)
        {
            int sceneId = SceneHelper.GetSceneId(self.GetParent<Scene>());
            self.OnAwake(sceneId);
        }
    }

    [ObjectSystem]
    public class RefreshMonsterComponentDestroySystem : DestroySystem<RefreshMonsterComponent>
    {
        public override void Destroy(RefreshMonsterComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class RefreshMonsterComponentSystem
    {

        public static void OnAwake(this RefreshMonsterComponent self, int sceneId)
        {
            if (sceneId == 0)
            {
                return;
            }
            Scene scene = self.GetParent<Scene>();
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
            if (sceneConfig.MapType != (int)SceneTypeEnum.YeWaiScene)
            {
                return;
            }
            string timingMonster = sceneConfig.CreateMonster;
            string[] monsters = timingMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (string.IsNullOrEmpty(monsters[i]))
                {
                    continue;
                }
                //3;-63.68,0.00,-19.01;71010001;1,1,1500
                string[] mondels = monsters[i].Split(';');
                string[] mtype = mondels[0].Split(',');
                string[] position = mondels[1].Split(',');
                string[] monsterid = mondels[2].Split(',');
                string[] mcount = mondels[3].Split(',');
               
                if (mtype[0] == "3")    //定时刷新
                {
                    string[] timers = mondels[4].Split(',');
                    for (int t = 0; t < timers.Length; t++)
                    {
                        long leftTime = self.LeftTime(timers[t]);
                        if (leftTime == 0)
                        {
                            continue;
                        }

                        self.RefreshMonsters.Add(new RefreshMonster()
                        {
                            MonsterId = int.Parse(monsterid[0]),
                            RefreshTime = TimeHelper.ServerNow() + leftTime,
                            PositionX = float.Parse(position[0]),
                            PositionY = float.Parse(position[1]),
                            PositionZ = float.Parse(position[2]),
                            Number = int.Parse(mcount[0]),
                            Range = int.Parse(mcount[1]),
                            Time = mondels[4],
                        });
                    }
                }
            }
            FubenHelp.CreateMonsterList(scene, timingMonster, FubenDifficulty.Normal);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.RefreshMonsterTimer, self);
        }

        public static long LeftTime(this RefreshMonsterComponent self, string targetTime)
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

        public static void OnTimer(this RefreshMonsterComponent self)
        {
            long time = TimeHelper.ServerNow();
            for (int i = self.RefreshMonsters.Count - 1; i >= 0; i--)
            {
                RefreshMonster refreshMonster = self.RefreshMonsters[i];
                if (time < refreshMonster.RefreshTime)
                {
                    continue;
                }

                DateTime dateTime =  TimeHelper.DateTimeNow();
                Log.Info($"CreateMonsters: {dateTime.ToString()}");

                //根据refreshMonster.Time可以纠正时间
                refreshMonster.RefreshTime = refreshMonster.RefreshTime + 24 * 60 * 60 * 1000;
                self.RefreshMonsters[i] = refreshMonster;

                self.CreateMonsters(refreshMonster).Coroutine() ;
            }
        }

        public static async ETTask CreateMonsters(this RefreshMonsterComponent self, RefreshMonster refreshMonster)
        {
            //防止无限刷宝箱
            int monsterNumber = 0;
            List<Unit>  entities = self.GetParent<Scene>().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].GetComponent<UnitInfoComponent>().Type == UnitType.Monster)
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
                await TimerComponent.Instance.WaitFrameAsync();
                float range = refreshMonster.Range;
                Vector3 form = new Vector3(refreshMonster.PositionX, refreshMonster.PositionY, refreshMonster.PositionZ);
                Vector3 to = new Vector3(form.x + RandomHelper.RandomNumberFloat(-1 * range, range), form.y, form.z + RandomHelper.RandomNumberFloat(-1 * range, range));
                Vector3 vector3 = self.DomainScene().GetComponent<MapComponent>().GetCanReachPath(form, to);
                UnitFactory.CreateMonster(self.GetParent<Scene>(), refreshMonster.MonsterId, vector3, new CreateMonsterInfo()
                { Camp = 2, FubenDifficulty = FubenDifficulty.Normal });
            }
        }

        public static void OnKillEvent(this RefreshMonsterComponent self, Unit defend)
        {
            UnitInfoComponent unitInfoComponent = defend.GetComponent<UnitInfoComponent>();
            if (!unitInfoComponent.IsMonster())
            {
                return;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitInfoComponent.UnitCondigID);
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
