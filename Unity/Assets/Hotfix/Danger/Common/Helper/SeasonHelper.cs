
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
                return true;
            }
            return false;
        }
#endif

        /// <summary>
        /// 赛季时间
        /// </summary>
        public static long SeasonOpenTime = 1697990400000;
        public static long SeasonCloseTime = 1705939200000;

        /// <summary>
        /// 赛季BOSS
        /// </summary>
        public static int SeasonBossId = 82000022;
    }
}

