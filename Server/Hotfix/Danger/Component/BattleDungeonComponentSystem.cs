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
            int score = GlobalValueConfigCategory.Instance.Get(57).Value2;
            if (self.CampKillNumber_1 > score || self.CampKillNumber_2 > score)
            {
                self.SendReward();
            }
        }

        public static  void SendReward(this BattleDungeonComponent self)
        {
            if (!self.SendReward)
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
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }
                if (units[i].GetBattleCamp()!=winCamp)
                {
                    continue;
                }

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
                units[i].GetComponent<TaskComponent>().OnWinCampBattle();
                MailHelp.SendUserMail(self.DomainZone(), units[i].Id, mailInfo).Coroutine();
            }
        }

        /// <summary>
        /// 踢出还在副本的玩家
        /// </summary>
        /// <param name="self"></param>
        public static void KickOutPlayer(this BattleDungeonComponent self)
        {
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }
                TransferHelper.MainCityTransfer(units[i]).Coroutine();
            }
        }

        public static void OnBattleOver(this BattleDungeonComponent self)
        {
            self.SendReward();
            self.KickOutPlayer();
        }
    }
}
