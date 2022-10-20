using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public static  class FirstWinHelper
    {
        public static int GetFirstWinID(int bossId, int difficulty = 1)
        {
            FirstWinConfigCategory.Instance.FirstWinList.TryGetValue(bossId, out List<int> firstWinConfigs);
            if (firstWinConfigs == null)
            {
                return 0;
            }
            return firstWinConfigs[0];
        }

        public static void  SendFirstWinInfo(Unit player, Unit boss, int difficulty = 1)
        {
            if (difficulty == 0)
            {
                Log.Info("SendFirstWinInfo:  difficulty == 0");
                difficulty = 1;
            }
            int firstwinid = GetFirstWinID(boss.ConfigId, difficulty);
            if (firstwinid == 0)
            {
                return;
            }
            UserInfo userInfo = player.GetComponent<UserInfoComponent>().UserInfo;
            FirstWinInfo firstWinInfo = new FirstWinInfo();
            firstWinInfo.FirstWinId = firstwinid;
            firstWinInfo.KillTime = TimeHelper.ServerNow();
            firstWinInfo.UserId = userInfo.UserId;
            firstWinInfo.PlayerName = userInfo.Name;
            firstWinInfo.Difficulty = difficulty;

            M2A_FirstWinInfoMessage message = new M2A_FirstWinInfoMessage()
            {
                FirstWinInfo = firstWinInfo,
            };
            long activiyServerId = DBHelper.GetActivityServerId(player.DomainZone());
            MessageHelper.SendActor(activiyServerId, message);
        }
    }
}
