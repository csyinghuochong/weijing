using System;
using System.Collections.Generic;

namespace ET
{


    [ObjectSystem]
    public class BattleSceneComponentAwakeSystem : AwakeSystem<BattleSceneComponent>
    {
        public override void Awake(BattleSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public class BattleSceneComponentDestroySystem : DestroySystem<BattleSceneComponent>
    {
        public override void Destroy(BattleSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public static class BattleSceneComponentSystem
    {
       
        public static void OnZeroClockUpdate(this BattleSceneComponent self)
        {
            LogHelper.LogWarning("Battle:  OnZeroClockUpdate", true);
        }

        public static void OnBattleOpen(this BattleSceneComponent self)
        {
            self.BattleOpen = true;
            self.RobotBattleOpenNotified = false;
            LogHelper.LogWarning($"OnBattleOpen : {self.DomainZone()}", true);
            // 机器人改到首个玩家进场、GenerateBattleInstanceId 创建战场 Scene 后再通知
        }

        public static async ETTask OnBattleOver(this BattleSceneComponent self)
        {
            self.BattleOpen = false;
            self.RobotBattleOpenNotified = false;
            LogHelper.LogDebug($"OnBattleOver : {self.DomainZone()}");
            //Console.WriteLine($"OnBattleOver : {self.DomainZone()}");
            long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
            MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.BattleOver });

            //await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber( 10000, 20000 )) ;
            for (int i = 0; i < self.BattleInfos.Count;i++)
            {
                try
                {
                    LocalDungeon2M_ExitResponse createUnit = (LocalDungeon2M_ExitResponse)await ActorMessageSenderComponent.Instance.Call(
                          self.BattleInfos[i].ProgressId, new M2LocalDungeon_ExitRequest()
                          {
                              SceneType = SceneTypeEnum.Battle,
                              FubenId = self.BattleInfos[i].FubenId,
                              Camp1Player = self.BattleInfos[i].Camp1Player,
                              Camp2Player = self.BattleInfos[i].Camp2Player,
                          });
                    if (createUnit.Error != ErrorCode.ERR_Success)
                    {
                        Console.WriteLine($"createUnit.Error: {self.BattleInfos[i].FubenId} {createUnit.Error}");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                }
               
            }
            self.BattleInfos.Clear();
        }
        
        public static KeyValuePairInt GetBattleInstanceId(this BattleSceneComponent self, long unitid, int sceneId)
        {
            KeyValuePairInt keyValuePairInt = new KeyValuePairInt();    
            if (!self.BattleOpen)
            {
                keyValuePairInt.KeyId = 0;
                keyValuePairInt.Value = 0; 
                return keyValuePairInt;
            }

            int camp = 0;
            BattleInfo battleInfo = null;
            for (int i = 0; i < self.BattleInfos.Count; i++)
            {
                battleInfo = self.BattleInfos[i];
                if (battleInfo.SceneId != sceneId)
                {
                    continue;
                }
                if (battleInfo.Camp1Player.Contains(unitid))
                {
                    keyValuePairInt.KeyId = 1;
                    keyValuePairInt.Value = battleInfo.FubenInstanceId;
                    return keyValuePairInt;
                }
                if (battleInfo.Camp2Player.Contains(unitid))
                {
                    keyValuePairInt.KeyId = 2;
                    keyValuePairInt.Value = battleInfo.FubenInstanceId;
                    return keyValuePairInt;
                }

                if (battleInfo.PlayerNumber < ComHelp.GetPlayerLimit(sceneId))
                {
                    battleInfo.PlayerNumber++;
                    camp = battleInfo.PlayerNumber % 2 + 1;
                    if (camp == 1)
                    {
                        battleInfo.Camp1Player.Add(unitid);
                    }
                    else
                    {
                        battleInfo.Camp2Player.Add(unitid);
                    }
                    keyValuePairInt.KeyId = camp;
                    keyValuePairInt.Value = battleInfo.FubenInstanceId;
                    return keyValuePairInt;
                }
            }

            return null;
        }

        public static async ETTask<KeyValuePairInt> GenerateBattleInstanceId(this BattleSceneComponent self, long unitid, int sceneId)
        {
            //动态创建副本
            List<StartSceneConfig> zonelocaldungeons = StartSceneConfigCategory.Instance.LocalDungeons[self.DomainZone()];
            int n = RandomHelper.RandomNumber(0, zonelocaldungeons.Count);
            StartSceneConfig startSceneConfig = zonelocaldungeons[n];

            LocalDungeon2M_EnterResponse createUnit = (LocalDungeon2M_EnterResponse)await ActorMessageSenderComponent.Instance.Call(
                      startSceneConfig.InstanceId, new M2LocalDungeon_EnterRequest()
                      {
                          UserID = unitid,
                          SceneType = SceneTypeEnum.Battle,
                          SceneId = sceneId,
                          TransferId = 0,
                          Difficulty = 0
                      });

            if (createUnit.Error != ErrorCode.ERR_Success)
            {
                return null;
            }

            BattleInfo battleInfo = self.AddChild<BattleInfo>();
            battleInfo.ProgressId = startSceneConfig.InstanceId;
            battleInfo.FubenId = createUnit.FubenId;
            battleInfo.PlayerNumber = 0;
            battleInfo.FubenInstanceId = createUnit.FubenInstanceId;
            battleInfo.SceneId = sceneId;

            battleInfo.PlayerNumber++;
            int camp = battleInfo.PlayerNumber % 2 + 1;
            if (camp == 1)
            {
                battleInfo.Camp1Player.Add(unitid);
            }
            else
            {
                battleInfo.Camp2Player.Add(unitid);
            }

            // 本区本轮只通知机器人一次：必须在 Add 前用标志位抢占，避免后续再建战场重复通知
            bool notifyRobotOnce = !self.RobotBattleOpenNotified;
            if (notifyRobotOnce)
            {
                self.RobotBattleOpenNotified = true;
            }

            self.BattleInfos.Add(battleInfo);

            if (notifyRobotOnce)
            {
                self.NotifyRobotBattleOpen();
            }

            return new KeyValuePairInt() { KeyId = camp, Value = battleInfo.FubenInstanceId };
        }

        /// <summary>
        /// 通知机器人进入本区。调用方已用 RobotBattleOpenNotified 保证每区每轮只进一次。
        /// </summary>
        private static void NotifyRobotBattleOpen(this BattleSceneComponent self)
        {
            if (DBHelper.GetOpenServerDay(self.DomainZone()) <= 0)
            {
                return;
            }

            int zone = self.DomainZone();
            long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
            MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest()
            {
                Zone = zone,
                MessageType = NoticeType.BattleOpen,
                Message = zone.ToString(),
            });
            LogHelper.LogWarning($"NotifyRobotBattleOpen zone={zone} (once)", true);
        }
    }
}
