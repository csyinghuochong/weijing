
using System.Collections.Generic;

namespace ET
{
    public static class SeasonHelper
    {

#if NOT_UNITY
        public static bool IsOpenSeason(int userLv)
        {
            //FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1071);
            //if (userLv < funtionConfig.ConditionParam[0])
            //{
            //    return false;
            //}
            if (userLv < 55)
            {
                return false;
            }
            if (userLv < 55)
            {
                return false;
            }
            long serverTime = TimeHelper.ServerNow();
            return serverTime >= SeasonOpenTime && serverTime <= SeasonCloseTime;
            //if (StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("127.0.0.1")
            //   || StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("192.168"))
            //{
            //     long serverTime = TimeHelper.ServerNow();
            //     return serverTime >= SeasonOpenTime && serverTime <= SeasonCloseTime;   
            //}
            //return false;
        }
#else
        public static bool IsOpenSeason(int userLv)
        {
            if (userLv < 55)
            {
                return false;
            }
            long serverTime = TimeHelper.ServerNow();
            return serverTime >= SeasonOpenTime && serverTime <= SeasonCloseTime;   
        }
#endif

        public static int GetFubenId(int lv)
        {
            List<int> canEnterIds = new List<int>();
            Dictionary<int, DungeonConfig> keyValuePairs = DungeonConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.EnterLv <= lv)
                {
                    canEnterIds.Add(item.Key);
                }
            }

            return canEnterIds[RandomHelper.RandomNumber(0, canEnterIds.Count)];
        }

        /// <summary>
        /// 赛季开始时间
        /// </summary>
        public static long SeasonOpenTime = 1697990400000;

        //赛季结束时间
        public static long SeasonCloseTime = 1705939200000;

        /// <summary>
        /// 赛季BOSS
        /// </summary>
        public static int SeasonBossId = 90000051;
    }
}

