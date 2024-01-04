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
        public const int ActivityV1_DuiHuanWord = 6;   //兑换
        public const int ActivityV1_ChouKa2 = 7;            //抽卡2  当奖励已经领取超过50%可进行奖励刷新
        public const int ActivityV1_Task = 8;           //活动任务，每日刷新  TaskComponent.TaskCountryList   TaskCountryType.ActivityV1
        public const int ActivityV1_LiBao = 9;          //每日礼包  ActivityConfig ActivityType = 102
        public const int ActivityV1_Feed = 10;          //喂食


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
        public static string ChouKaCostItem = "1;100";

        /// <summary>
        /// 抽奖次数奖励
        /// </summary>
        public static Dictionary<int, string> ChouKaNumberReward = new Dictionary<int, string>()
        {
            {  1,   "1;1" },
            {  3,   "1;3" },
            {  10,  "1;10" },
        };
        
        ///可供竞猜的数量。（数量6对应对个字）
        public static int GuessNumber = 6;

        /// <summary>
        /// 第一个字免费， 第二个字开始消耗道具.  
        /// </summary>
        public static string GuessCostItem = "1;100@1;200@1;300@1;400@1;500@1;600";


        /// <summary>
        /// 竞猜时间点奖励
        /// </summary>
        public static Dictionary<int, string> GuessRewardList = new Dictionary<int, string>()
        {
             { 0, "1;100"},
             { 14, "1;200"},
             { 18, "1;300"},
             { 21, "1;400"},
        };

        /// <summary>
        /// 开启消耗
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string GetGuessCostItem(int index)
        {
            if (index == 0)
            {
                return string.Empty;
            }
            string[] costitem = GuessCostItem.Split('@');
            if (index > costitem.Length)
            {
                return costitem[costitem.Length - 1];
            }
            return costitem[index - 1]; 
        }

        /// <summary>
        /// 消费钻石奖励
        /// </summary>
        public static Dictionary<int, string> ConsumeDiamondReward = new Dictionary<int, string>()
        {
            {  100, "1;1000" },
            {  200, "1;1000" }
        };
        
        /// <summary>
        /// 红包奖励
        /// </summary>
        public static int HongBaoDropId = 601901001;

        /// <summary>
        /// 单个兑换奖励. 单个字可以兑换10万金币

        /// </summary>

        public static Dictionary<int, string> DuiHuanWordReward = new Dictionary<int, string>()
        {
            {  10030013,"1;100000" },
            {  10030014,"1;100000" },
            {  10030015,"1;100000" },
            {  10030016,"1;100000" },
        };

        //一套字可以兑换一个金条.  DuiHuanWordReward.keys
        public static string GroupsWordReward = "10010045;1";


        /// <summary>
        /// 每档随机取几个。抽满一半可以刷新
        /// </summary>
        public static Dictionary<int, List<int>> Chou2ItemList = new Dictionary<int, List<int>>()
        {
            {  1, new List<int>(){ 10030013, 10030013, 10030013 } },
            {  2, new List<int>(){ 10030013, 10030013, 10030013 } },
            {  3, new List<int>(){ 10030013, 10030013, 10030013 } },
        };

        /// <summary>
        /// 在野外击败怪物时会掉落元宵和饺子, 喂食道具会获得奖励哦
        /// </summary>

        public static Dictionary<int, string> FeedItemReward = new Dictionary<int, string>()
        {
            {  10030013,"1;100000" },
            {  10030014,"1;100000" },
        };

        ///当饱食度达到1000点时,会为每位贡献者赠送一个礼包哦

        public static string Feed1000Reward = "10010045;1";

        /// <summary>
        /// 每日礼包
        /// </summary>
        public static Dictionary<int, string> LiBaoList = new Dictionary<int, string>()
        {
            { 1, "10030013;1@10030013;1"},
            { 2, "10030013;1@10030013;1"},
            { 3, "10030013;1@10030013;1"},
        };

        public static List<int> GetLiBaoList()
        {
            return new List<int> { 1, 2, 3 };
        }

    }
}