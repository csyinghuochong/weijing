using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [Timer(TimerType.TeamDropTimer)]
    public class TeamDropTimer : ATimer<TeamDungeonComponent>
    {
        public override void Run(TeamDungeonComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class TeamDungeonComponentAwakeSystem : AwakeSystem<TeamDungeonComponent>
    {
        public override void Awake(TeamDungeonComponent self)
        {
            self.EnterTime = 0;
            self.BoxReward.Clear();
            self.ItemFlags.Clear();
            self.TeamDropItems.Clear();
        }
    }

    [ObjectSystem]
    public class TeamDungeonComponentDestroySystem : DestroySystem<TeamDungeonComponent>
    {
        public override void Destroy(TeamDungeonComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class TeamDungeonComponentSystem
    {

        public static void Check(this TeamDungeonComponent self)
        {
            if (self.TeamDropItems.Count == 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
                return;
            }

            long serverTime = TimeHelper.ServerNow();
            int playerCount = FubenHelp.GetUnitList(self.DomainScene(),  UnitType.Player).Count;
            for (int i = self.TeamDropItems.Count - 1; i >= 0; i--)
            {
         
                TeamDropItem teamDropItem = self.TeamDropItems[i];
                if (teamDropItem.EndTime == -1)
                {
                    continue;
                }
                List<long> needIds = teamDropItem.NeedPlayers;
                List<long> giveIds = teamDropItem.GivePlayers;
                bool finish = serverTime >= teamDropItem.EndTime || (needIds.Count + giveIds.Count >= playerCount);
                if (!finish)
                {
                    continue;
                }
                teamDropItem.EndTime = -1;
                long unitid = needIds.Count == 0 ? 0 : teamDropItem.NeedPlayers[RandomHelper.RandomNumber(0, teamDropItem.NeedPlayers.Count)];
                Unit unit = self.DomainScene().GetComponent<UnitComponent>().Get(unitid);
                if (unit != null)
                {
                    List<RewardItem> rewardItems = new List<RewardItem>();
                    rewardItems.Add(new RewardItem() { ItemID = teamDropItem.DropInfo.ItemID, ItemNum = teamDropItem.DropInfo.ItemNum });
                    unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, "", $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                    FubenHelp.SendPickMessage(unit, teamDropItem.DropInfo, self.m2C_SyncChatInfo);
                }
                self.DomainScene().GetComponent<UnitComponent>().Remove(teamDropItem.DropInfo.UnitId);       //移除掉落ID
            }
        }

        public static TeamDropItem AddTeamDropItem(this TeamDungeonComponent self, Unit unit, DropInfo dropInfo)
        {
            for (int i = 0; i < self.TeamDropItems.Count; i++)
            {
                if (self.TeamDropItems[i].DropInfo.UnitId == dropInfo.UnitId)
                {
                    return null;
                }
            }

            TeamDropItem teamDropItem = self.AddChildWithId<TeamDropItem>(dropInfo.UnitId);
            teamDropItem.DropInfo = dropInfo;
            teamDropItem.EndTime = TimeHelper.ServerNow() + 20 * 1000;
            self.TeamDropItems.Add(teamDropItem);
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TeamDropTimer, self);
            }
            M2C_TeamPickMessage teamPickMessage = self.m2C_TeamPickMessage;
            teamPickMessage.DropItems.Clear();
            teamPickMessage.DropItems.Add(dropInfo);
            MessageHelper.Broadcast(unit, teamPickMessage);
            return teamDropItem;
        }

        public static void OnUpdateDamage(this TeamDungeonComponent self, Unit unit, int damage)
        {
            if (self.TeamInfo == null)
            {
                Log.Debug($"TeamDungeon unit.Id: {unit.Id}  senceid: {unit.DomainScene().InstanceId} instanceid: {self.InstanceId} ");
                return;
            }
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
                if (unit.Type == UnitType.Player)
                {
                    haveplayer = true;
                    break;
                }
            }
            return haveplayer;
        }

        public static bool IsAllMonsterDead(this TeamDungeonComponent self)
        {
            return FubenHelp.IsAllMonsterDead(self.DomainScene());
        }

        public static void OnKillEvent(this TeamDungeonComponent self, Unit unit)
        {
            if (unit.Type != UnitType.Monster)
            {
                return;
            }

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(self.TeamInfo.SceneId);
            if (unit.ConfigId != sceneConfig.BossId)
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
                    unit1.GetComponent<BagComponent>().OnAddItemData(m2C_FubenSettlement.RewardExtraItem, "", $"{ItemGetWay.FubenGetReward}_{TimeHelper.ServerNow()}");
                }
                MessageHelper.SendToClient(unit1, m2C_FubenSettlement);
            }
        }

    }
}
