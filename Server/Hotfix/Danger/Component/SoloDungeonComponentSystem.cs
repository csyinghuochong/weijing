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

            Unit u1 = self.DomainScene().GetComponent<UnitComponent>().Get(self.PlayerUnit_1);
            Unit u2 = self.DomainScene().GetComponent<UnitComponent>().Get(self.PlayerUnit_2);
            List<Unit> entities = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            self.TestKill(self.PlayerUnit_1); //临时测试
            self.WinAddIntegral(self.PlayerUnit_1);
        }

        public static void OnKillEvent(this SoloDungeonComponent self, Unit defend)
        {
            Log.Debug($"solo场击杀事件 {defend.Type}");
        }

        public static void TestKill(this SoloDungeonComponent self, long failUnit)
        {

            //Log.Debug($"TestKill场击杀事件 {failUnit.Type}");

            List<RewardItem> rewardList = new List<RewardItem>();
            RewardItem reward = new RewardItem();
            reward.ItemID = 1;
            reward.ItemNum = 999;
            rewardList.Add(reward);

            //ActorLocationSenderComponent.Instance.Call(failUnit, new M2C_SoloDungeon() { RewardItem = rewardList, SoloResult = 1 });
            //MessageHelper.SendToClient(failUnit, new M2C_SoloDungeon() { RewardItem = rewardList,SoloResult = 1 });

        }

        //胜利者增加积分
        public static void WinAddIntegral(this SoloDungeonComponent self, long winUnitId)
        {
            Log.Debug($"增加积分 {winUnitId}");

            SoloSceneComponent soloSceneComponent = self.DomainScene().GetComponent<SoloSceneComponent>();
            if (soloSceneComponent.PlayerIntegralList.ContainsKey(winUnitId))
            {
                int value = soloSceneComponent.PlayerIntegralList[winUnitId];
                soloSceneComponent.PlayerIntegralList[winUnitId] += 3;          //每次胜利获得3点积分
            }
        }
    }
}
