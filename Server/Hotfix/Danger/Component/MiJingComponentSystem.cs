using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static  class MiJingComponentSystem
    {


        public static void OnKillEvent(this MiJingComponent self, Unit defend)
        {
            if (defend.ConfigId != self.BossId)
            {
                return;
            }

            List<TeamPlayerInfo> players = new List<TeamPlayerInfo>();
            players.AddRange(self.PlayerDamageList.Take(5));

            self.SendReward(players, 0, 0,  "10010098;10@10010099;1@10000132;100");
            self.SendReward(players, 1, 1,  "10010098;10@10010099;1@10000132;100");
            self.SendReward(players, 2, 4,  "10010098;10@10010099;1@10000132;100");

            self.PlayerDamageList.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="players"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="rewardList"></param>
        public static void SendReward(this MiJingComponent self, List<TeamPlayerInfo> players, int start, int end,  string rewardList)
        {
            long serverTime = TimeHelper.ServerNow();
            for (int i = start; i <= end; i++)
            {
                if (i >= players.Count || players[i].RobotId > 0)
                {
                    return;
                }
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Context = "秘境奖励";
                mailInfo.Title = "秘境奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();
                string[] needList = rewardList.Split('@');
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
                MailHelp.SendUserMail(self.DomainZone(),  players[i].UserID, mailInfo).Coroutine();
            }
        }

        public static void OnUpdateDamage(this MiJingComponent self,  Unit attack,  Unit defend, long damage)
        {
            if (!defend.IsBoss() || defend.ConfigId != self.BossId)
            {
                return;
            }

            TeamPlayerInfo teamPlayerInfo = null;
            for (int i = 0; i < self.PlayerDamageList.Count; i++)
            {
                if (self.PlayerDamageList[i].UserID == attack.Id)
                {
                    teamPlayerInfo = self.PlayerDamageList[i];
                    teamPlayerInfo.Damage += (int)damage;
                }
            }
            if (teamPlayerInfo == null)
            {
                teamPlayerInfo = new TeamPlayerInfo();
                teamPlayerInfo.UserID = attack.Id;
                teamPlayerInfo.PlayerName = attack.GetComponent<UserInfoComponent>().UserInfo.Name;
                teamPlayerInfo.Damage = (int)damage;
                self.PlayerDamageList.Add(teamPlayerInfo);
            }
            if (TimeHelper.ServerNow() - self.LastTime < 1000)
            {
                return;
            }
            self.LastTime = TimeHelper.ServerNow();
            self.PlayerDamageList.Sort(delegate (TeamPlayerInfo a, TeamPlayerInfo b)
            {
                return (int)b.Damage - (int)a.Damage;
            });

            List<Unit> allPlayer = FubenHelp.GetUnitList(self.DomainScene(), UnitType.Player);
            for (int i = 0; i < allPlayer.Count; i++)
            {
                self.M2C_SyncMiJingDamage.DamageList.Clear();
                self.M2C_SyncMiJingDamage.DamageList.AddRange(self.PlayerDamageList.Take(5));
                MessageHelper.SendToClient(allPlayer[i], self.M2C_SyncMiJingDamage);
            }
        }
    }
}
