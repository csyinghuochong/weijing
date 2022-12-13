using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static  class MiJingComponentSystem
    {
        public static void OnKillEvent(this MiJingComponent self, Unit defend)
        {
            if (defend.IsBoss() && defend.ConfigId == self.BossId)
            {
                self.PlayerDamageList.Clear();
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
