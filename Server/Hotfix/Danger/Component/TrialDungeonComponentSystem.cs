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
            if (defend.Type != UnitType.Monster)
            {
                return;
            }

            List<Unit> players = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            if (defend.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == players[0].Id)
            {
                return;
            }

            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            int sonsceneid = mapComponent.SonSceneId;
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(sonsceneid);
            if (!towerConfig.MonsterSet.Contains(defend.ConfigId.ToString()))
            {
                return;
            }

            //有人做作弊器修改了客户端时间 ，战斗时间超过一分钟则判定失败。
            long usetime = TimeHelper.ServerNow() - self.BeginTime;
            if (usetime <= 0 || usetime > TimeHelper.Second * 70)
            {
                Console.WriteLine($"TrialDungeon  usetime <= 0 || usetime > TimeHelper.Second * 70");
                M2C_FubenSettlement m2C_FubenSettlement_0 = new M2C_FubenSettlement();
                m2C_FubenSettlement_0.BattleResult = CombatResultEnum.Fail;
                MessageHelper.SendToClient(players[0], m2C_FubenSettlement_0);
                return;
            }

            self.UploadHurtValue().Coroutine();

            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = CombatResultEnum.Win;

            long lastDungeonId = players[0].GetComponent<NumericComponent>().GetAsLong(NumericType.TrialDungeonId);

            string userName = players[0].GetComponent<UserInfoComponent>().UserInfo.Name;
            Log.Warning($"试炼之地通关： 区:{players[0].DomainZone()}   {players[0].Id}   {mapComponent.SonSceneId}  {userName}  {players[0].GetComponent<UserInfoComponent>().UserInfo.Lv}");

            if (lastDungeonId < mapComponent.SonSceneId)
            {
                players[0].GetComponent<NumericComponent>().ApplyValue(NumericType.TrialDungeonId, mapComponent.SonSceneId);
            }
            MessageHelper.SendToClient(players[0], m2C_FubenSettlement);

            players[0].GetComponent<TaskComponent>().TriggerTaskEvent( TaskTargetType.TrialTowerCeng_134, mapComponent.SonSceneId, 1);
            players[0].GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.TrialTowerCeng_134, mapComponent.SonSceneId, 1);
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
            if (Response.Error == ErrorCode.ERR_Success && Response.RankId != 0)
            {
                players[0].GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.TrialRank_81, Response.RankId, 1);
                players[0].GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.TrialRank_81, Response.RankId, 1);
            }
            self.HurtValue = 0;
            await ETTask.CompletedTask;
        }

        public static void OnUpdateDamage(this TrialDungeonComponent self,Unit player, Unit attack, Unit defend, long damage, int skillid)
        {
            if (defend.Type != UnitType.Monster)
            {
                return;
            }
            self.HurtValue += damage;

            if(player.Id == 2010003137213038592)
            {
                string skillName = string.Empty;
                if (skillid != 0)
                {
                    skillName = SkillConfigCategory.Instance.Get(skillid).SkillName; ;
                }
                
                if (attack.Type == UnitType.Player)
                {
                    LogHelper.TrialBattleInfo(44, $"南宫灵蓝 使用{skillName} 造成了{damage}伤害");
                }
                if (attack.Type == UnitType.Pet)
                {
                    PetConfig petConfig = PetConfigCategory.Instance.Get(attack.ConfigId);
                    LogHelper.TrialBattleInfo(44, $"南宫灵蓝 宠物{petConfig.PetName} 使用{skillName} 造成了{damage}伤害");
                }
                if (attack.Type == UnitType.Monster)
                {
                    MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(attack.ConfigId);
                    LogHelper.TrialBattleInfo(44, $"南宫灵蓝 召唤怪{monsterConfig.MonsterName} 使用{skillName} 造成了{damage}伤害");
                }
            }
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
