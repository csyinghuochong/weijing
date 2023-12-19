using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 活动相关配置
    /// </summary>

    public static class ActivityConfigHelper
    {
        /// <summary>
        /// 抽奖奖励
        /// </summary>
        public static int ChouKaDropId = 0;

        /// <summary>
        /// 抽奖次数奖励
        /// </summary>
        public static Dictionary<int, string> ChouKaNumberReward = new Dictionary<int, string>()
        {
            {  3, "1;0" }
        };
        
        ///可供竞猜的数量。（数量6对应对个字）
        public static int GuessNumber = 6;

        /// <summary>
        /// 第一个字免费， 一个钻石多猜一个字
        /// </summary>
        public static int GuessCostDiamond = 100;   

        /// <summary>
        /// 消费钻石奖励
        /// </summary>
        public static Dictionary<int, string> ConsumeDiamondReward = new Dictionary<int, string>()
        {
            {  100, "1;0" }
        };

        /// <summary>
        /// 红包奖励
        /// </summary>
        public static int HongBaoDropId = 0;
    }
}