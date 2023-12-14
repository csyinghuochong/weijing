using System;
using System.Collections.Generic;

namespace ET
{
    public static class SeasonTowerComponentSystem
    {

        public static void OnKillEvent(this SeasonTowerComponent self, Unit defend)
        {
            List<Unit> players = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);

            if (defend.Id == players[0].Id)
            {
                M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
                m2C_FubenSettlement.BattleResult = CombatResultEnum.Fail;
                MessageHelper.SendToClient(players[0], m2C_FubenSettlement);
                return;
            }
            if (FubenHelp.IsAllMonsterDead(self.DomainScene(), players[0]))
            {
                M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
                m2C_FubenSettlement.BattleResult = CombatResultEnum.Win;
                MessageHelper.SendToClient(players[0], m2C_FubenSettlement);

                self.UploadHurtValue(players[0]).Coroutine();
            }
        }

        public static async ETTask UploadHurtValue(this SeasonTowerComponent self, Unit unit)
        {
            long userTime = TimeHelper.ServerNow() - self.BeginTime;
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            KeyValuePairLong rankingInfo = new KeyValuePairLong()
            {
                KeyId = unit.Id,
                Value = userTime,
                Value2 = mapComponent.SonSceneId
            };
            long mapInstanceId = DBHelper.GetRankServerId(self.DomainZone());
            M2R_RankSeasonTowerRequest reuqest = new M2R_RankSeasonTowerRequest() {  RankingInfo = rankingInfo };
            R2M_RankSeasonTowerResponse Response = (R2M_RankSeasonTowerResponse)await ActorMessageSenderComponent.Instance.Call
                   (mapInstanceId, reuqest);
        }

        public static void GenerateFuben(this SeasonTowerComponent self, int towerId)
        {
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);
            FubenHelp.CreateMonsterList(self.DomainScene(), towerConfig.MonsterSet);
            self.BeginTime = TimeHelper.ServerNow();
        }
    }
}
