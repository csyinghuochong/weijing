using System;
using System.Collections.Generic;

namespace ET
{

    public class TrialDungeonComponentA : AwakeSystem<TrialDungeonComponent>
    {
        public override void Awake(TrialDungeonComponent self)
        {
            self.HurtValue = 0; 
        }
    }

    public static class TrialDungeonComponentSystem
    {

        public static void OnKillEvent(this TrialDungeonComponent self, Unit defend)
        {
            List<Unit> players = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            if (defend.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == players[0].Id)
            {
                return;
            }
            if (defend.Type != UnitType.Monster)
            {
                return;
            }

            self.UploadHurtValue().Coroutine();

            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = CombatResultEnum.Win;

            long lastDungeonId = players[0].GetComponent<NumericComponent>().GetAsLong(NumericType.TrialDungeonId);
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            if (lastDungeonId < mapComponent.SonSceneId)
            {
                players[0].GetComponent<NumericComponent>().ApplyValue(NumericType.TrialDungeonId, mapComponent.SonSceneId);
            }
            MessageHelper.SendToClient(players[0], m2C_FubenSettlement);

            players[0].GetComponent<TaskComponent>().TriggerTaskEvent( TaskTargetType.TrialTowerCeng_134, mapComponent.SonSceneId, 1);
        }

        public static async ETTask UploadHurtValue(this TrialDungeonComponent self)
        {
            List<Unit> players = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            if (players.Count == 0)
            {
                return;
            }
            long unitId = players[0].Id;
            long hurtValue = self.HurtValue;
            long usetime =  TimeHelper.ServerNow() - self.BeginTime;
            usetime = usetime / 1000;
            usetime = Math.Max(1, usetime);
            hurtValue = hurtValue / usetime;

            players[0].GetComponent<DataCollationComponent>().OnSceondHurt(hurtValue);
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            long mapInstanceId = DBHelper.GetRankServerId(self.DomainZone());
            R2M_RankTrialResponse Response = (R2M_RankTrialResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, new M2R_RankTrialRequest()
                     {
                         RankingInfo = new KeyValuePairLong() { KeyId = unitId, Value = hurtValue, Value2 = mapComponent.SonSceneId }
                     });
            self.HurtValue = 0;
            await ETTask.CompletedTask;
        }

        public static void OnUpdateDamage(this TrialDungeonComponent self, Unit attack, Unit defend, long damage)
        {
            if (defend.Type != UnitType.Monster)
            {
                return;
            }

            self.HurtValue += damage;
        }


        public static void GenerateFuben(this TrialDungeonComponent self, int towerId)
        {
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);
            FubenHelp.CreateMonsterList(self.DomainScene(), towerConfig.MonsterSet);
            self.HurtValue = 0;
            self.BeginTime = TimeHelper.ServerNow();
        }

    }
}
