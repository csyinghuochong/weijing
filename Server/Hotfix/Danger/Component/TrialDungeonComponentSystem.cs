using System.Collections.Generic;

namespace ET
{
    public static class TrialDungeonComponentSystem
    {

        public static void OnKillEvent(this TrialDungeonComponent self, Unit defend)
        {
            List<Unit> players = FubenHelp.GetUnitList(self.DomainScene(), UnitType.Player);
            if (defend.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == players[0].Id)
            {
                return;
            }
            if (defend.Type != UnitType.Monster)
            {
                return;
            }

            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = CombatResultEnum.Win;
            
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            players[0].GetComponent<NumericComponent>().ApplyValue(NumericType.TrialDungeonId, mapComponent.SonSceneId);
            MessageHelper.SendToClient(players[0], m2C_FubenSettlement);
        }

        public static void GenerateFuben(this TrialDungeonComponent self, int towerId)
        {
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);
            FubenHelp.CreateMonsterList(self.DomainScene(), towerConfig.MonsterSet);
        }

    }
}
