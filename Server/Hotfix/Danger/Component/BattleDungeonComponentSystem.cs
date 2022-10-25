using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ObjectSystem]
    public class BattleDungeonComponentAwakeSystem : AwakeSystem<BattleDungeonComponent>
    {

        public override void Awake(BattleDungeonComponent self)
        {
            self.CampKillNumber_1 = 0;
            self.CampKillNumber_2 = 0;
        }
    }

    public static class BattleDungeonComponentSystem
    {
        public static void OnKillEvent(this BattleDungeonComponent self, Unit defend)
        {
            if (defend.Type != UnitType.Player)
            {
                return;
            }
            if (UnitHelper.GetBattleCamp(defend) == CampEnum.CampPlayer_1)
            {
                self.CampKillNumber_2++;
            }
            else
            {
                self.CampKillNumber_1++;
            }
        }

        public static  void SendReward(this BattleDungeonComponent self, int winCamp)
        {
            if (winCamp == 0)
            {
                return;
            }
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(58);
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
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
            int winCamp = 1;
            if (self.CampKillNumber_1 > self.CampKillNumber_2)
            {
                winCamp = CampEnum.CampPlayer_1;
            }
            if (self.CampKillNumber_2 > self.CampKillNumber_1)
            {
                winCamp = CampEnum.CampPlayer_2;
            }
            self.SendReward(winCamp);
            self.KickOutPlayer();
        }
    }
}
