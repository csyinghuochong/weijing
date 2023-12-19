using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 活动相关配置
    /// </summary>

    public static class ActivityConfigHelper
    {

        public const int ActivityV1_ChouKa = 1;    //抽卡
        public const int ActivityV1_Guess = 2;     //竞猜
        public const int ActivityV1_Consume = 3;     //消费
        public const int ActivityV1_HongBao = 4;     //红包
        public const int ActivityV1_Shop = 5;          //商店


        /// <summary>
        /// UI切页也据此显示
        /// </summary>
        public static List<int> ActivityV1OpenList = new List<int>() { 
            ActivityV1_ChouKa, ActivityV1_Guess, ActivityV1_Consume,ActivityV1_HongBao, ActivityV1_Shop };  


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