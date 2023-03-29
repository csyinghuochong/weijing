using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class BattleDungeonComponentAwakeSystem : AwakeSystem<BattleDungeonComponent>
    {

        public override void Awake(BattleDungeonComponent self)
        {
            self.CampKillNumber_1 = 0;
            self.CampKillNumber_2 = 0;
            self.SendReward = false;
        }
    }

    public static class BattleDungeonComponentSystem
    {
        public static void OnKillEvent(this BattleDungeonComponent self, Unit defend, Unit attack)
        {
            if (defend.Type != UnitType.Player)
            {
                return;
            }
            if (defend.GetBattleCamp() == CampEnum.CampPlayer_1)
            {
                self.CampKillNumber_2++;
            }
            else
            {
                self.CampKillNumber_1++;
            }
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }

                M2C_BattleInfoResult m2C_Battle = self.m2C_BattleInfoResult;
                m2C_Battle.CampKill_1 = self.CampKillNumber_1;
                m2C_Battle.CampKill_2 = self.CampKillNumber_2;
                MessageHelper.SendToClient(units[i], m2C_Battle);
            }

            if (attack != null && attack.Type == UnitType.Player)
            {
                attack.GetComponent<NumericComponent>().ApplyChange(null, NumericType.BattleTodayKill, 1, 0);
            }
        }

        public static void SendReward(this BattleDungeonComponent self, BattleInfo battleInfo)
        {
            if (self.SendReward)
            {
                return;
            }
            self.SendReward = true;
            int winCamp = 1;
            if (self.CampKillNumber_1 > self.CampKillNumber_2)
            {
                winCamp = CampEnum.CampPlayer_1;
            }
            if (self.CampKillNumber_2 > self.CampKillNumber_1)
            {
                winCamp = CampEnum.CampPlayer_2;
            }
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(56);
            List<long> winPlayers = winCamp == 1 ? battleInfo.Camp1Player: battleInfo.Camp2Player;
        
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < winPlayers.Count; i++)
            {
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Context = "战场奖励";
                mailInfo.Title = "战场奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();
                string[] needList = globalValueConfig.Value.Split('@');
                for (int k = 0; k < needList.Length; k++)
                {
                    string[] itemInfo = needList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.BattleWin}_{serverTime}" });
                }

                Unit unit = self.DomainScene().GetComponent<UnitComponent>().Get(winPlayers[i]);
                if (unit != null)
                {
                    unit.GetComponent<TaskComponent>().OnWinCampBattle();
                }
                if (unit != null && unit.IsRobot())
                {
                    continue;
                }
                MailHelp.SendUserMail(self.DomainZone(), winPlayers[i], mailInfo).Coroutine();
            }
        }

        /// <summary>
        /// 踢出还在副本的玩家
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask KickOutPlayer(this BattleDungeonComponent self)
        {
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }
                if (units[i].IsDisposed || units[i].IsRobot())
                {
                    continue;
                }
                TransferHelper.MainCityTransfer(units[i]).Coroutine();
            }
            await ETTask.CompletedTask;
        }

        public static async ETTask OnBattleOver(this BattleDungeonComponent self, BattleInfo battleInfo)
        {
            self.SendReward(battleInfo);
            await self.KickOutPlayer();
        }
    }
}
