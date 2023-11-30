
namespace ET
{
    public static class SeasonHelper
    {

#if NOT_UNITY
        public static bool IsOpenSeason()
        {
            if (StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("127.0.0.1")
               || StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("192.168"))
            {
                 long serverTime = TimeHelper.ServerNow();
                 return serverTime >= SeasonOpenTime && serverTime <= SeasonCloseTime;   
            }
            return false;
        }
#else
        public static bool IsOpenSeason()
        {
            long serverTime = TimeHelper.ServerNow();
            return serverTime >= SeasonOpenTime && serverTime <= SeasonCloseTime;   
        }
#endif

        public static int GetFubenId(int lv)
        {
            return 10001;
        }

        /// <summary>
        /// 赛季开始时间
        /// </summary>
        public static long SeasonOpenTime = 1697990400000;

        //赛季结束时间
        public static long SeasonCloseTime = 1705939200000;


        public static long SeasonFruitTime = TimeHelper.Hour;

        /// <summary>
        /// 赛季BOSS
        /// </summary>
        public static int SeasonBossId = 90000051;
    }
}

