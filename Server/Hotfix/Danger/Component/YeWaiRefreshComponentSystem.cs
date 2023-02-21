using System;
using System.Linq;
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
            self.LogTest = false;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.RefreshMonsterTimer, self);
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

        /// <summary>
        /// 起服或者零点刷新一次
        /// </summary>
        /// <param name="self"></param>
        /// <param name="openDay"></param>
        public static void OnZeroClockUpdate(this YeWaiRefreshComponent self, int openDay)
        {
            List<ServerDayConfig> serverDays = ServerDayConfigCategory.Instance.GetAll().Values.ToList();
            ServerDayConfig serverDayConfig = null;
            for (int i = 0; i < serverDays.Count; i++)
            {
                if (i == serverDays.Count - 1)
                {
                    serverDayConfig = serverDays[i];
                    break;
                }
                if (openDay >= serverDays[i].Day && openDay < serverDays[i+1].Day)
                {
                    serverDayConfig = serverDays[i];
                    break;
                }
            }
            int sceneId = self.DomainScene().GetComponent<MapComponent>().SceneId;
            string[] rewardItems = serverDayConfig.RewardItems.Split('@');
            for (int i = 0; i < rewardItems.Length;i++)
            {
                string[] monsterItem = rewardItems[i].Split(',');
                if (int.Parse(monsterItem[0])!=sceneId)
                {
                    continue;
                }
                int[] pistionId = new int[1] { int.Parse(monsterItem[1]) };
                FubenHelp.CreateMonsterList(self.DomainScene(), pistionId);
            }
        }

        public static void OnAddRefreshList(this YeWaiRefreshComponent self, Unit unit, long reTime)
        {
            Vector3 vector3 = unit.GetBornPostion();
            self.RefreshMonsters.Add(new RefreshMonster()
            {
                MonsterId = unit.ConfigId,
                NextTime = TimeHelper.ServerNow() + reTime,
                PositionX = vector3.x,
                PositionY = vector3.y,
                PositionZ = vector3.z,
                Number = 1,
                Range = 0,
                Interval = -1,
            });
        }

        /// <summary>
        /// 间隔时间刷新
        /// </summary>
        /// <param name="self"></param>
        /// <param name="createMonster"></param>
        /// <param name="fubenDifficulty"></param>
        public static void CreateMonsterList(this YeWaiRefreshComponent self, string createMonster)
        {
            if (ComHelp.IfNull(createMonster))
            {
                return;
            }
            string[] monsters = createMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (string.IsNullOrEmpty(monsters[i]))
                {
                    continue;
                }
                //3;-63.68,0.00,-19.01;71010001;1,1,100,600
                string[] mondels = monsters[i].Split(';');
                string[] position = mondels[1].Split(',');
                string monsterid = mondels[2];
                string[] mcount = mondels[3].Split(',');

                self.RefreshMonsters.Add(new RefreshMonster()
                {
                    MonsterId = int.Parse(monsterid),
                    NextTime = TimeHelper.ServerNow() + int.Parse(mcount[2]) * 1000,
                    PositionX = float.Parse(position[0]),
                    PositionY = float.Parse(position[1]),
                    PositionZ = float.Parse(position[2]),
                    Number = int.Parse(mcount[0]),
                    Range = int.Parse(mcount[1]),
                    Interval = int.Parse(mcount[3]) * 1000,
                });
            }
        }

        /// <summary>
        /// 间隔时间刷新
        /// </summary>
        /// <param name="self"></param>
        /// <param name="monsterPos"></param>
        /// <param name="fubenDifficulty"></param>
        public static void CreateMonsterByPos(this YeWaiRefreshComponent self, int monsterPos)
        {
            if (monsterPos == 0)
            {
                return;
            }
            //Id      NextID  Type Position             MonsterID CreateRange CreateNum Create    Par(3代表刷新时间)
            //10001   10002   2    - 71.46,0.34,-5.35   81000002       0           1       90    30,60
            MonsterPositionConfig monsterPosition = MonsterPositionConfigCategory.Instance.Get(monsterPos);
            int mtype = monsterPosition.Type;
            string[] position = monsterPosition.Position.Split(',');
            string[] refreshPar = monsterPosition.Par.Split(',');
            self.RefreshMonsters.Add(new RefreshMonster()
            {
                MonsterId = monsterPosition.MonsterID,
                NextTime = TimeHelper.ServerNow() + int.Parse(refreshPar[0]) * 1000,
                PositionX = float.Parse(position[0]),
                PositionY = float.Parse(position[1]),
                PositionZ = float.Parse(position[2]),
                Number = monsterPosition.CreateNum,
                Range = (float)monsterPosition.CreateRange,
                Interval = int.Parse(refreshPar[1]) * 1000,
                Rotation = monsterPosition.Create,
            });
        }

        /// <summary>
        /// 固定时间刷新
        /// </summary>
        /// <param name="self"></param>
        /// <param name="createMonster"></param>
        /// <param name="fubenDifficulty"></param>
        public static void CreateMonsterList_2(this YeWaiRefreshComponent self, string createMonster)
        {
            if (ComHelp.IfNull(createMonster))
            {
                return;
            }
            string[] monsters = createMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (string.IsNullOrEmpty(monsters[i]))
                {
                    continue;
                }
                //5;-50,0,2;80002001;10,25;1230,2030
                //5;-29,0,0;72009002;1,1;2015
                string[] mondels = monsters[i].Split(';');
                int mtype = int.Parse(mondels[0]);
                string[] position = mondels[1].Split(',');  //-50,0,2
                int monsterid = int.Parse(mondels[2]);              //80002001
                string[] mcount = mondels[3].Split(',');    //10,25
                string[] timers = mondels[4].Split(','); //1230,2030
                for (int t = 0; t < timers.Length; t++)
                {
                    long leftTime = self.LeftTime(timers[t]);
                    if (leftTime == 0)
                    {
                        continue;
                    }

                    self.RefreshMonsters.Add(new RefreshMonster()
                    {
                        MonsterId = monsterid,
                        NextTime = TimeHelper.ServerNow() + leftTime,
                        PositionX = float.Parse(position[0]),
                        PositionY = float.Parse(position[1]),
                        PositionZ = float.Parse(position[2]),
                        Number = int.Parse(mcount[0]),
                        Range = int.Parse(mcount[1]),
                        Interval = mtype == 5 ? TimeHelper.OneDay : -1,
                    });
                }
            }
        }

        /// <summary>
        /// 固定时间刷新
        /// </summary>
        /// <param name="self"></param>
        /// <param name="monsterPos"></param>
        /// <param name="fubenDifficulty"></param>
        public static void CreateMonsterByPos_2(this YeWaiRefreshComponent self, int monsterPos)
        {
            if (monsterPos == 0)
            {
                return;
            }
            //5;-50,0,2;80002001;10,25;1230,203060
            MonsterPositionConfig monsterPosition = MonsterPositionConfigCategory.Instance.Get(monsterPos);
            int mtype = monsterPosition.Type;
            string[] position = monsterPosition.Position.Split(',');

            string[] timers = monsterPosition.Par.Split(',');//1230,2030
            for (int t = 0; t < timers.Length; t++)
            {
                long leftTime = self.LeftTime(timers[t]);
                if (leftTime == 0)
                {
                    continue;
                }

                self.RefreshMonsters.Add(new RefreshMonster()
                {
                    MonsterId = monsterPosition.MonsterID,
                    NextTime = TimeHelper.ServerNow() + leftTime,
                    PositionX = float.Parse(position[0]),
                    PositionY = float.Parse(position[1]),
                    PositionZ = float.Parse(position[2]),
                    Number = monsterPosition.CreateNum,
                    Range = (float)monsterPosition.CreateRange,
                    Interval = mtype == 5 ? TimeHelper.OneDay : -1,
                    Rotation = monsterPosition.Create,
                }); ;
            }
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

        public static void Baozangzhixiufu(this YeWaiRefreshComponent self)
        {
            self.RefreshMonsters.Clear();

            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);

            FubenHelp.CreateMonsterList(self.DomainScene(), sceneConfig.CreateMonster);
            FubenHelp.CreateMonsterList(self.DomainScene(), sceneConfig.CreateMonsterPosi);
        }

        public static void OnTimer(this YeWaiRefreshComponent self)
        {
            long time = TimeHelper.ServerNow();
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();

            if (!self.LogTest && mapComponent.SceneTypeEnum == SceneTypeEnum.BaoZang)
            {
                self.LogTest = true;

                Log.Debug($"野外定时怪[数量]：{self.DomainZone()} {self.RefreshMonsters.Count}");

                for (int i = self.RefreshMonsters.Count - 1; i >= 0; i--)
                {
                    if (self.RefreshMonsters[i].MonsterId == 72009003)
                    {
                        Log.Debug($"野外定时怪[火龙]：{self.DomainZone()} {self.RefreshMonsters[i].NextTime - TimeHelper.ServerNow()}");
                    }
                }
            }

            for (int i = self.RefreshMonsters.Count - 1; i >= 0; i--)
            {
                RefreshMonster refreshMonster = self.RefreshMonsters[i];
             
                if (time < refreshMonster.NextTime)
                {
                    continue;
                }

                if (refreshMonster.Interval == -1)
                {
                    self.RefreshMonsters.RemoveAt(i);

                    if (mapComponent.SceneTypeEnum == SceneTypeEnum.BaoZang)
                    {
                        Log.Debug($" self.RefreshMonsters.RemoveAt : {i}");
                    }
                }
                else
                {
                    refreshMonster.NextTime = refreshMonster.NextTime + refreshMonster.Interval;
                    self.RefreshMonsters[i] = refreshMonster;
                }

                //DateTime dateTime =  TimeHelper.DateTimeNow();
                //根据refreshMonster.Time可以纠正时间
                self.CreateMonsters(refreshMonster);
            }
        }

        public static  void CreateMonsters(this YeWaiRefreshComponent self, RefreshMonster refreshMonster)
        {
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(refreshMonster.MonsterId);
            Vector3 form = new Vector3(refreshMonster.PositionX, refreshMonster.PositionY, refreshMonster.PositionZ);
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();


            if (mapComponent.SceneTypeEnum == SceneTypeEnum.MiJing && monsterConfig.MonsterType == MonsterTypeEnum.Boss)
            {
                self.DomainScene().GetComponent<MiJingComponent>().BossId = refreshMonster.MonsterId;

                if (!ComHelp.IsBanHaoZone(self.DomainZone()) && DBHelper.GetOpenServerDay(self.DomainZone()) > 0)
                {
                    long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                    MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest()
                    {
                        Zone = self.DomainZone(),
                        MessageType = NoticeType.YeWaiBoss,
                        Message = $"{mapComponent.SceneId}@{form.x};{form.y};{form.z}@{refreshMonster.MonsterId}"
                    });
                }
            }
           
            int monsterNumber = FubenHelp.GetUnitListByCamp(self.GetParent<Scene>(), UnitType.Monster, monsterConfig.MonsterCamp).Count;
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.Battle)
            {
                if (monsterConfig.MonsterSonType != 55 &&  monsterConfig.MonsterSonType != 56
                    && monsterNumber >= GlobalValueConfigCategory.Instance.Get(59).Value2)
                {
                    return;
                }
            }
            else
            {
                if (monsterNumber >= GlobalValueConfigCategory.Instance.Get(78).Value2)
                {
                    return;
                }
            }

            for (int i = 0; i < refreshMonster.Number; i++)
            {
                float range = refreshMonster.Range;
                Vector3 to = new Vector3(form.x + RandomHelper.RandomNumberFloat(-1 * range, range), form.y, form.z + RandomHelper.RandomNumberFloat(-1 * range, range));
                Vector3 vector3 = self.DomainScene().GetComponent<MapComponent>().GetCanReachPath(form, to);
               
                UnitFactory.CreateMonster(self.GetParent<Scene>(), refreshMonster.MonsterId, vector3, new CreateMonsterInfo()
                {  
                    Camp = monsterConfig.MonsterCamp,
                    Rotation = refreshMonster.Rotation, 
                });
            }
        }
    }
}
