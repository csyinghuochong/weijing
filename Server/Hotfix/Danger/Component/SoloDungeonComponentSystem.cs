using System;
using System.Collections.Generic;

namespace ET
{
    //定时器
    [Timer(TimerType.SoloDungeonTimer)]
    public class SoloDungeonComponentTimer : ATimer<SoloDungeonComponent>
    {
        public override void Run(SoloDungeonComponent self)
        {
            try
            {
                self.PlayerCheck();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public static class SoloDungeonComponentSystem
    {

        public class SoloDungeonComponentAwakeSystem : AwakeSystem<SoloDungeonComponent>
        {
            public override void Awake(SoloDungeonComponent self)
            {

            }
        }

        public static void Init(this SoloDungeonComponent self) 
        {
            //记录开场时间设置计时器 没15秒检测一次
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(15000, TimerType.SoloDungeonTimer, self);
        }

        public static void PlayerCheck(this SoloDungeonComponent self) {

            List<Unit> playerUnitList = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);

            if (playerUnitList.Count <= 1) {
                if (playerUnitList[0] != null)
                {
                    //场景如果只进了1个人则那1个人获得胜利
                    self.OnKillEvent(playerUnitList[0],null);
                }
            }

        }

        public static void OnKillEvent(this SoloDungeonComponent self, Unit attackUnit, Unit defendUnit)
        {

            //获胜发送奖励
            if (attackUnit != null && defendUnit != null)
            {
                if (attackUnit.Type == UnitType.Player && defendUnit.Type == UnitType.Player)
                {
                    //发送输/赢奖励
                    self.SendReward(attackUnit, defendUnit);
                    //增加积分记录
                    self.WinAddIntegral(attackUnit.Id, defendUnit.Id);
                }
            }

            //场景只有1个人 另外一个人没进去的情况下
            if (attackUnit.Type == UnitType.Player && defendUnit == null)
            {

                //发送输/赢奖励
                self.SendReward(attackUnit, null);
                //增加积分记录
                self.WinAddIntegral(attackUnit.Id, 0);
            }
        }

        public static void SendReward(this SoloDungeonComponent self, Unit attackUnit, Unit defendUnit)
        {
            List<RewardItem> rewardList = new List<RewardItem>();
            //临时奖励
            RewardItem reward = new RewardItem();
            reward.ItemID = 1;
            reward.ItemNum = 999;
            rewardList.Add(reward);

            MessageHelper.SendToClient(attackUnit, new M2C_SoloDungeon() { RewardItem = rewardList,SoloResult = 1 });

            if (defendUnit != null)
            {
                if (defendUnit.Type == UnitType.Player)
                {
                    MessageHelper.SendToClient(defendUnit, new M2C_SoloDungeon() { RewardItem = null, SoloResult = 0 });
                }
            }
        }

        //胜利者增加积分
        public static void WinAddIntegral(this SoloDungeonComponent self, long winUnitId,long failUnitId)
        {
            Log.Debug($"增加积分 {winUnitId}");

            SoloSceneComponent soloSceneComponent = self.DomainScene().GetParent<SoloSceneComponent>();
            if (soloSceneComponent.PlayerIntegralList.ContainsKey(winUnitId))
            {
                int value = soloSceneComponent.PlayerIntegralList[winUnitId];
                soloSceneComponent.PlayerIntegralList[winUnitId] += 3;          //每次胜利获得3点积分
            }

            //记录战绩和积分
            if (soloSceneComponent.AllPlayerDateList.ContainsKey(winUnitId)) {
                soloSceneComponent.AllPlayerDateList[winUnitId].WinNum += 1;
                soloSceneComponent.AllPlayerDateList[winUnitId].Combat = soloSceneComponent.PlayerIntegralList[winUnitId];
            }
            if (failUnitId != 0) {
                if (soloSceneComponent.AllPlayerDateList.ContainsKey(failUnitId))
                {
                    soloSceneComponent.AllPlayerDateList[failUnitId].FailNum += 1;
                }
            }
        }
    }
}
