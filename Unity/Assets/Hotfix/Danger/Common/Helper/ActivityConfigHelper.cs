using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 活动相关配置
    /// </summary>

    public static class ActivityConfigHelper
    {
        /// <summary>
        /// 抽奖奖励，每个区每天随机一个掉落ID
        /// </summary>
        public static List<int> ChouKaDropId = new List<int> { 601901001 };

        /// <summary>
        /// 抽奖消耗道具
        /// </summary>
        public static string ChouKaCostItem = "1;0";

        /// <summary>
        /// 抽奖次数奖励
        /// </summary>
        public static Dictionary<int, string> ChouKaNumberReward = new Dictionary<int, string>()
        {
            {  3,   "1;0" },
            {  10,  "1;0" },
        };
        
        ///可供竞猜的数量。（数量6对应对个字）
        public static int GuessNumber = 6;

        /// <summary>
        /// 第一个字免费， 第二个字开始消耗道具.  
        /// </summary>
        public static string GuessCostItem = "1;0@1;0@1;0@1;0@1;0@1;0";   

        /// <summary>
        /// 消费钻石奖励
        /// </summary>
        public static Dictionary<int, string> ConsumeDiamondReward = new Dictionary<int, string>()
        {
            {  100, "1;0" },
            {  200, "1;0" }
        };

        /// <summary>
        /// 红包奖励
        /// </summary>
        public static int HongBaoDropId = 0;
    }
}