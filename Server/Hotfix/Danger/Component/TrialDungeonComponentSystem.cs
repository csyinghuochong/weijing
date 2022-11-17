using System.Collections.Generic;

namespace ET
{
    public static class TrialDungeonComponentSystem
    {

        public static void OnKillEvent(this TrialDungeonComponent self, Unit defend)
        {
            if (defend.Type != UnitType.Monster)
            {
                return;
            }

            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = CombatResultEnum.Win;
            List<Unit> players = FubenHelp.GetUnitList(self.DomainScene(), UnitType.Player);
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            players[0].GetComponent<NumericComponent>().ApplyValue(NumericType.TrialDungeonId, mapComponent.SonSceneId);
            MessageHelper.SendToClient(players[0], m2C_FubenSettlement);
        }

        public static void GenerateFuben(this TrialDungeonComponent self)
        {
            int towerId = self.DomainScene().GetComponent<MapComponent>().SonSceneId;
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);
            FubenHelp.CreateMonsterList(self.DomainScene(), towerConfig.MonsterSet);
        }

    }
}
