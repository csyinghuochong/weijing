using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ObjectSystem]
    public class TeamDungeonComponentAwakeSystem : AwakeSystem<TeamDungeonComponent>
    {
        public override void Awake(TeamDungeonComponent self)
        {
            self.EnterTime = 0;
            self.BoxReward.Clear();
            self.ItemFlags.Clear();
        }
    }

    public static class TeamDungeonComponentSystem
    {

        public static async ETTask OnDungeonOff(this TeamDungeonComponent self, long userId)
        {
            long teamServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Team").InstanceId;
            T2M_TeamDungeonOffResponse g2M_UpdateUnitResponse = (T2M_TeamDungeonOffResponse)await ActorMessageSenderComponent.Instance.Call
                (teamServerId, new M2T_TeamDungeonOffRequest() { UserID = userId });
        }

        public static void OnUpdateDamage(this TeamDungeonComponent self, Unit unit, int damage)
        {
            long userId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId;
            for (int i = 0; i < self.TeamInfo.PlayerList.Count; i++)
            {
                if (self.TeamInfo.PlayerList[i].UserID == userId)
                {
                    self.TeamInfo.PlayerList[i].Damage = damage;
                    break;
                }
            }
        }

        public static bool IsHavePlayer(this TeamDungeonComponent self)
        {
            bool haveplayer = false;
            List<Entity> units = self.DomainScene().GetComponent<UnitComponent>().Children.Values.ToList() ;
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i] as Unit;
                if (unit.GetComponent<UnitInfoComponent>().Type == UnitType.Player)
                {
                    haveplayer = true;
                    break;
                }
            }
            return haveplayer;
        }

        public static bool IsAllMonsterDead(this TeamDungeonComponent self)
        {
            List<Entity> allunits = self.DomainScene().GetComponent<UnitComponent>().Children.Values.ToList() ;
            for (int i = 0; i < allunits.Count; i++)
            {
                UnitInfoComponent unitInfoComponent = allunits[i].GetComponent<UnitInfoComponent>();
                if (unitInfoComponent.IsMonster() && unitInfoComponent.IsCanBeAttack())
                    return false;
            }

            return true;
        }

        public static void OnKillEvent(this TeamDungeonComponent self, Unit unit)
        {
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.Type != UnitType.Monster)
            {
                return;
            }

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(self.TeamInfo.FubenId);
            if (unitInfoComponent.UnitCondigID != sceneConfig.BossId)
            {
                return;
            }

            M2C_TeamDungeonSettlement m2C_FubenSettlement = new M2C_TeamDungeonSettlement();

            m2C_FubenSettlement.PassTime = TimeHelper.ServerNow() - self.EnterTime;
            m2C_FubenSettlement.PlayerList = self.TeamInfo.PlayerList;

            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.RewardExtraItem);

            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.ReardList);
            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.ReardList);
            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.ReardList);

            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.ReardListExcess);
            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.ReardListExcess);
            DropHelper.DropIDToDropItem_2(sceneConfig.BoxDropID, m2C_FubenSettlement.ReardListExcess);

            //最高伤害额外奖励
            long idExtra = 0;
            int damageMax = 0;
            for (int i = 0; i < m2C_FubenSettlement.PlayerList.Count; i++)
            {
                if (m2C_FubenSettlement.PlayerList[i].Damage >= damageMax)
                {
                    damageMax = m2C_FubenSettlement.PlayerList[i].Damage;
                    idExtra = m2C_FubenSettlement.PlayerList[i].UserID;
                }
            }

            List<Unit> units = unit.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit1 = units[i] as Unit;
                if (unit1.Type != UnitType.Player)
                {
                    continue;
                }

                unit1.GetComponent<TaskComponent>().OnPassTeamFuben();
                if (unit1.GetComponent<UserInfoComponent>().UserInfo.UserId == idExtra)
                {
                    unit1.GetComponent<BagComponent>().OnAddItemData(m2C_FubenSettlement.RewardExtraItem, 0, $"{ItemGetWay.FubenGetReward}_{TimeHelper.ServerNow()}");
                }
                MessageHelper.SendToClient(unit1, m2C_FubenSettlement);
            }
        }

    }
}
