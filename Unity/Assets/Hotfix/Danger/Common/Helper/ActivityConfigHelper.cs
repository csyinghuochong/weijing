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
        public const int ActivityV1_Points = 4;      //积分
        public const int ActivityV1_HongBao = 5;     //红包
        public const int ActivityV1_Shop = 6;          //商店
        public const int ActivityV1_DuiHuanWord = 7;   //兑换
        public const int ActivityV1_ChouKa2 = 8;            //抽卡2  当奖励已经领取超过50%可进行奖励刷新
        public const int ActivityV1_Task = 9;           //活动任务，每日刷新  TaskComponent.TaskCountryList   TaskCountryType.ActivityV1
        public const int ActivityV1_LiBao = 10;          //每日礼包  ActivityConfig ActivityType = 102
        public const int ActivityV1_Feed = 11;          //喂食
        public const int ActivityV1_PointsChouKa = 12;      //积分抽卡
        public const int ActivityV1_GoldWeeklyCard = 13;
        public const int ActivityV1_DiamondWeeklyCard = 14;
      
        /// <summary>
        /// 抽奖奖励，每个区每天随机一个掉落ID
        /// </summary>
        public static List<int> ChouKaDropId = new List<int> { 61400301 };

        /// <summary>
        /// 抽奖消耗道具
        /// </summary>
        public static string ChouKaCostItem = "37;30";

        /// <summary>
        /// 抽奖次数奖励
        /// </summary>
        public static Dictionary<int, string> ChouKaNumberReward = new Dictionary<int, string>()
        {
            {  5,   "10000184;200@1;200000@10010086;1" },
            {  10,   "10000184;200@1;200000@10010093;1" },
            {  20,  "10000184;400@1;500000@10010040;1" },
            {  30,  "10000184;400@1;500000@10000141;1" },
            {  50,  "10000184;800@1;1000000@10010026;1" },
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

        public static string ConvertToChineseDay(int day)
        {
            string[] chineseNumbers = { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };

            if (day >= 1 && day <= 10)
            {
                return $"第{chineseNumbers[day - 1]}天";
            }
            else if (day > 10)
            {
                // 处理大于10的情况（如十一、十二等）
                return $"第{ConvertToChinese(day)}天";
            }

            return $"第{day}天";
        }

        // 简单的数字转中文方法（处理1-99）
        private static string ConvertToChinese(int number)
        {
            if (number == 10) return "十";
            if (number < 10) return new string[] { "一", "二", "三", "四", "五", "六", "七", "八", "九" }[number - 1];
            if (number < 20) return "十" + ConvertToChinese(number % 10);

            int tens = number / 10;
            int ones = number % 10;
            string result = new string[] { "", "十", "二十", "三十", "四十", "五十", "六十", "七十", "八十", "九十" }[tens];
            if (ones > 0) result += ConvertToChinese(ones);
            return result;
        }

        /// <summary>
        /// 消费钻石奖励
        /// </summary>
        public static Dictionary<int, string> ConsumeDiamondReward = new Dictionary<int, string>()
        {
            {  100, "1;1000" },
            {  200, "1;1000" }
        };

        //积分兑换
        public static Dictionary<int, string> PointsRewardList = new Dictionary<int, string>()
        {
            {  100, "10000184;25@1;300000@10010083;10@10000143;2@10000150;1" },
            {  300, "10000184;75@1;600000@10000141;1@10000151;1@10010079;2" },
            {  500, "10000184;125@10000135;1@10000141;2@10000151;2@10010046;1" },
            {  1000, "10000184;250@10000135;2@10000141;4@10000151;5@10010096;1" },
            {  2000, "10000184;500@10000135;3@10000141;8@10000151;10@10010094;1" },
        };

        //积分抽卡   权重-奖励
        public static List<TimerChouKaItemn> PointsChouKaList = new List<TimerChouKaItemn>()
        {
             new TimerChouKaItemn(){   Weight = 15,  ItemInfo =  "10000143;3" },     
            new TimerChouKaItemn(){   Weight = 15, ItemInfo =  "10000151;1" },    
            new TimerChouKaItemn(){   Weight = 15, ItemInfo =  "10010040;1" },    
            new TimerChouKaItemn(){   Weight = 5, ItemInfo =  "10010094;1" },  
            new TimerChouKaItemn(){    Weight = 15, ItemInfo =  "10000150;1" },   
            new TimerChouKaItemn(){  Weight = 15,  ItemInfo =  "10000135;1" },    
            new TimerChouKaItemn(){  Weight = 5,  ItemInfo =  "10000151;3" },    
            new TimerChouKaItemn(){  Weight = 15,  ItemInfo =  "10010046;1" },    
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
        /// 抽卡消耗道具(幸运卷轴)
        /// </summary>
        public static int Chou2CostItem = 10000184;

        /// <summary>
        /// 每档随机取几个。抽满一半可以刷新
        /// </summary>
        public static Dictionary<int, List<string>> ChouKa2ItemList = new Dictionary<int, List<string>>()
        {
            {  1, new List<string>(){ "10010083;1", "10010083;3", "10000132;2", "10000132;5", "10000131;1", "10000131;3", "10010039;1", "10010041;2" , "10010042;2", "10010098;2", "10010098;2", "10010085;10", "10010091;1", "10010034;1", "10000184;30" } },
            {  2, new List<string>(){ "10000166;1", "10010028;1", "10010033;1", "10010043;2", "10010037;2", "10010083;5", "10000142;1", "10010092;1" , "10010085;20", "10000184;60" } },
            {  3, new List<string>(){ "10000150;1", "10000141;1", "10010040;1", "10010086;1", "10010046;1", "10010045;1", "10000143;1", "10010093;1" } },
        };

        public static List<string> GetRewardListByType(int id, int number)
        {
            List<string> randomList = new List<string>();   
            List<string> rewardList = ChouKa2ItemList[id];
            int[] randomIds = RandomHelper.GetRandoms(number, 0, rewardList.Count);
            for (int i = 0; i < randomIds.Length; i++)
            {
                randomList.Add(rewardList[randomIds[i]]);
            }
            return randomList;
        }

        public static string GetChouKa2RewardList()
        {
            string rewardList = string.Empty;
            List<string> allrewardList = new List<string>();

            ////每一档取不同的数量
            allrewardList.AddRange(GetRewardListByType(1, 6) );
            allrewardList.AddRange(GetRewardListByType(2, 4));
            allrewardList.AddRange(GetRewardListByType(3, 2));

            for (int i = 0; i < allrewardList.Count; i++)
            {
                rewardList += $"{allrewardList[i]}";
                if (i == allrewardList.Count - 1)
                {
                    break;
                }
                rewardList += "@";
            }
            return rewardList;
        }

        public static int GetChouKa2RewardIndex(string rewardList, List<int> rewardIds)
        {
            List<int> leftIds = new List<int>();  
            int allnumber = rewardList.Split('@').Length;
            for (int i = 0; i < allnumber; i++)
            {
                if (!rewardIds.Contains(i))
                {
                    leftIds.Add(i);
                }
            }
            if (leftIds.Count == 0)
            {
                return -1;
            }
            return leftIds[ RandomHelper.RandomNumber(0, leftIds.Count) ];
        }

        /// <summary>
        /// 在野外击败怪物时会掉落元宵和饺子, 喂食道具会获得奖励哦
        /// </summary>

        public static Dictionary<int, string> FeedItemReward = new Dictionary<int, string>()
        {
            {  10030013,"1;100000" },
            {  10030014,"1;100000" },
        };

        ///当饱食度达到一定值时,会为每位贡献者赠送一个礼包哦

        public static Dictionary<int, string> Feed1RewardList = new Dictionary<int, string>()
        {
            { 10, "10010045;1"},
            { 2000, "10010045;1"},
        };

        /// <summary>
        /// 每日礼包
        /// </summary>
        public static Dictionary<int, LiBaoListItem> LiBaoList = new Dictionary<int, LiBaoListItem>()
        {
            { 1,  new LiBaoListItem(){ Value = "37;498", Name = "洗练礼包1", Value2 = "10010060;1@10000180;100@10000183;2@10000184;300" }}, //Value消耗钻石Value2道具
            { 2,  new LiBaoListItem(){ Value = "37;498", Name = "洗练礼包2", Value2 = "10010053;1@10010037;50@10010052;2@10000184;300" }},
            { 3,  new LiBaoListItem(){ Value = "37;498", Name = "洗练礼包3", Value2 = "10000107;1@10045108;1@10000108;2@10000184;300" }},
            { 4,  new LiBaoListItem(){ Value = "37;498", Name = "洗练礼包4", Value2 = "10010093;3@10000166;20@10000131;100@10000184;300" }},
        };

        public static List<int> GetLiBaoList()
        {
            return new List<int> { 1, 2, 3, 4 };
        }


        /// <summary>
        /// 1 黄金周卡 2钻石周卡
        /// </summary>
        public static Dictionary<int, List<string>> ActivityV1WeeklyCardReward = new Dictionary<int, List<string>>()
        {
            {  1, new List<string>()
            {
                 "10000184;1@1;300000@10010083;10@10000143;2@10000150;1",
                 "10000184;2@1;300000@10010083;10@10000143;2@10000150;2",
                 "10000184;3@1;300000@10010083;10@10000143;2@10000150;3",
                 "10000184;4@1;300000@10010083;10@10000143;2@10000150;4",
                 "10000184;5@1;300000@10010083;10@10000143;2@10000150;5",
                 "10000184;6@1;300000@10010083;10@10000143;2@10000150;6",
                 "10000184;7@1;300000@10010083;10@10000143;2@10000150;7"
            } },
            {  2, new List<string>()
            {
                 "10000184;11@1;300000@10010083;10@10000143;2@10000150;1",
                 "10000184;12@1;300000@10010083;10@10000143;2@10000150;2",
                 "10000184;13@1;300000@10010083;10@10000143;2@10000150;3",
                 "10000184;14@1;300000@10010083;10@10000143;2@10000150;4",
                 "10000184;15@1;300000@10010083;10@10000143;2@10000150;5",
                 "10000184;16@1;300000@10010083;10@10000143;2@10000150;6",
                 "10000184;17@1;300000@10010083;10@10000143;2@10000150;7"
            } }
        };
    }
}