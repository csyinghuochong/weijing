using System.Collections.Generic;

namespace ET
{
    public static class SoloDungeonComponentSystem
    {

        public class SoloDungeonComponentAwakeSystem : AwakeSystem<SoloDungeonComponent>
        {
            public override void Awake(SoloDungeonComponent self)
            {

            }
        }

        public static void Init(this SoloDungeonComponent self) {
            /*
            Unit u1 = self.DomainScene().GetComponent<UnitComponent>().Get(self.PlayerUnit_1);
            Unit u2 = self.DomainScene().GetComponent<UnitComponent>().Get(self.PlayerUnit_2);
            List<Unit> entities = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            self.TestKill(self.PlayerUnit_1); //临时测试
            self.WinAddIntegral(self.PlayerUnit_1);
            */
        }

        public static void OnKillEvent(this SoloDungeonComponent self, Unit attackUnit, Unit defendUnit)
        {
            Log.Debug($"solo场击杀事件 {defendUnit.Type}");

            //后面需要加入
            if (attackUnit.Type == UnitType.Player&& defendUnit.Type == UnitType.Player|| defendUnit.Type == UnitType.Monster) {
                //发送输/赢奖励
                self.SendReward(attackUnit, defendUnit);
                //增加积分记录
                self.WinAddIntegral(attackUnit.Id, defendUnit.Id);
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
            if (defendUnit.Type == UnitType.Player)
            {
                MessageHelper.SendToClient(defendUnit, new M2C_SoloDungeon() { RewardItem = null, SoloResult = 0 });
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
            if (soloSceneComponent.AllPlayerDateList.ContainsKey(failUnitId))
            {
                soloSceneComponent.AllPlayerDateList[failUnitId].FailNum += 1;
            }
        }
    }
}
