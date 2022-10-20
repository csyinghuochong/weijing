using System;

namespace ET
{

    [ObjectSystem]
    public class RandomTowerComponentAwakeSystem : AwakeSystem<RandomTowerComponent>
    {
        public override void Awake(RandomTowerComponent self)
        {
            self.TowerId = 0;
        }
    }

    public static class RandomTowerComponentSystem
    {
        public static void OnKillEvent(this RandomTowerComponent self, Unit unitdefend)
        {
            bool allMonsterDead = FubenHelp.IsAllMonsterDead(self.DomainScene());
            bool mainUnitDead = unitdefend.Id == self.MainUnit.Id;
            if (!allMonsterDead && !mainUnitDead)
            {
                return;
            }
            if (allMonsterDead)
            {
                NumericComponent numericComponent = self.MainUnit.GetComponent<NumericComponent>();
                numericComponent.ApplyValue(NumericType.RandomTowerId, self.TowerId);
            }
            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = allMonsterDead ? 1 : 0;
            MessageHelper.SendToClient(self.MainUnit, m2C_FubenSettlement);
        }
    }
}
