using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 活动相关配置
    /// </summary>

    public static class ActivityConfigHelper
    {
        
        public const int ActivityV1_ChouKa = 1;    //好运
        public const int ActivityV1_Guess = 2;     //竞猜
        public const int ActivityV1_Consume = 3;     //豪掷
        public const int ActivityV1_Points = 4;      //积分
        public const int ActivityV1_HongBao = 5;     //红包
        public const int ActivityV1_Shop = 6;          //商店
        public const int ActivityV1_DuiHuanWord = 7;   //兑换
        public const int ActivityV1_ChouKa2 = 8;            //抽取  当奖励已经领取超过50%可进行奖励刷新
        public const int ActivityV1_Task = 9;           //限时活动-任务，每日刷新  TaskComponent.TaskCountryList   TaskCountryType.ActivityV1
        public const int ActivityV1_LiBao = 10;          //每日礼包  ActivityConfig ActivityType = 102
        public const int ActivityV1_Feed = 11;          //喂食
        public const int ActivityV1_PointsChouKa = 12;      //积分抽卡
        public const int ActivityV1_GoldWeeklyCard = 13;    //黄金周卡
        public const int ActivityV1_DiamondWeeklyCard = 14; //钻石周卡
        public const int ActivityV1_Order = 15;             //订单
        public const int ActivityV1_GrowthTree = 16;        //成长树
        public const int ActivityV1_WeeklyTask = 17;        //周任务 TaskCountryType.ActivityWeekly
        public const int ActivityV1_NewYearCollectionWord = 18;        //限时活动-集字
        public const int ActivityV1_NewYearMonster = 19;   //限时活动-年兽
        public const int ActivityV1_PointsShunXu = 20;      //积分兑换 顺序领取


        //成长树和商人活动这两个活动会有2个掉落ID（分别对应小怪和BOSS掉落，其中小怪只有在有体力的时候才能触发掉落），
        //这个ID只有在活动期间才会激活，只有关卡里的小怪和BOSS会额外附加对应的活动掉落ID，这些掉落的东西会在活动结束后自动消失。 

        //商人活动期间才激活这个掉落
        public static int OrderDropId = 61400610;

        //喂食活动期间才激活这个掉落
        public static int FeedDropId = 61400620;

        //成长树活动期间才激活这个掉落
        public static int GrowthTreeDropId = 61400630;

        //集字活动激活这个掉落
        public static int CollectionWordDropId = 61400640;

        /// <summary>
        /// 随机生成活动列表
        /// </summary>
        /// <returns></returns>
        public static List<int> RandomGenerateActivityList(int weekindex)
        { 
            List<int> ids = new List<int>();

            ///
            ///限时活动页面：
            ///ActivityConfigHelper.ActivityV1_NewYearCollectionWord 集字   101
            ///ActivityConfigHelper.ActivityV1_NewYearMonster       年兽
            ///ActivityConfigHelper.ActivityV1_Task         周任务1         201
            ///ActivityConfigHelper.ActivityV1_Points       积分奖励1       401
            ///ActivityConfigHelper.ActivityV1_Shop         商店            301
            ///ActivityConfigHelper.ActivityV1_PointsChouKa 抽奖            503  充值积分抽奖

            /// 新活动页面->限时活动页面：11个切页
            ///ActivityConfigHelper.ActivityV1_ChouKa       好运   7         504  消耗充值积分
            ///ActivityConfigHelper.ActivityV1_Guess        竞猜   8         //废弃
            ///ActivityConfigHelper.ActivityV1_Consume      豪掷   9         //废弃
            ///ActivityConfigHelper.ActivityV1_HongBao      红包   10        //废弃
            ///ActivityConfigHelper.ActivityV1_DuiHuanWord  兑换   11        //废弃
            ///ActivityConfigHelper.ActivityV1_ChouKa2      抽取   12    302     冬季积分抽奖
            ///ActivityConfigHelper.ActivityV1_LiBao        礼包   13    502     充值积分购买
            ///ActivityConfigHelper.ActivityV1_Feed         喂食   14    102
            ///ActivityConfigHelper.ActivityV1_Order        订单   15    103
            ///ActivityConfigHelper.ActivityV1_GrowthTree   成长树 16    104
            ///ActivityConfigHelper.ActivityV1_WeeklyTask   周任务 17    202
            ///ActivityConfigHelper.ActivityV1_PointsShunXu 积分奖励 顺序领取   402

            if (weekindex == 0)
            {
                //第一周
                ids.Add(ActivityConfigHelper.ActivityV1_GrowthTree);
                ids.Add(ActivityConfigHelper.ActivityV1_Task);
                ids.Add(ActivityConfigHelper.ActivityV1_Shop);
                ids.Add(ActivityConfigHelper.ActivityV1_Points);
                ids.Add(ActivityConfigHelper.ActivityV1_PointsChouKa);
            }
            else if (weekindex == 1)
            {
                //第二周
                ids.Add(ActivityConfigHelper.ActivityV1_Order);                  //商人   15
                ids.Add(ActivityConfigHelper.ActivityV1_WeeklyTask);            //周任务 17
                ids.Add(ActivityConfigHelper.ActivityV1_ChouKa2);               //抽取   12   302
                ids.Add(ActivityConfigHelper.ActivityV1_PointsShunXu);                //积分奖励1       401
                ids.Add(ActivityConfigHelper.ActivityV1_ChouKa);                //好运   7         504  消耗充值积分
            }
            else if (weekindex == 2)
            {
                //第三周
                ids.Add(ActivityConfigHelper.ActivityV1_Feed);                  //喂食   14    102
                ids.Add(ActivityConfigHelper.ActivityV1_Task);                  //周任务1         201
                ids.Add(ActivityConfigHelper.ActivityV1_Shop);                  //商店            301
                ids.Add(ActivityConfigHelper.ActivityV1_Points);                //积分奖励1       401
                ids.Add(ActivityConfigHelper.ActivityV1_LiBao);                 //礼包   13    502
            }
            else
            {
                //第四周
                ids.Add(ActivityConfigHelper.ActivityV1_NewYearCollectionWord); //集字   101
                ids.Add(ActivityConfigHelper.ActivityV1_NewYearMonster);        //年兽
                ids.Add(ActivityConfigHelper.ActivityV1_WeeklyTask);            //周任务 17
                ids.Add(ActivityConfigHelper.ActivityV1_ChouKa2);               //抽取   12   302
                ids.Add(ActivityConfigHelper.ActivityV1_PointsShunXu);                //积分奖励1       401
                ids.Add(ActivityConfigHelper.ActivityV1_ChouKa);                //好运   7         504  消耗充值积分
            }

            return ids;
        }

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


        //积分桉顺序兑换
        public static Dictionary<int, string> PointsShunXuRewardList = new Dictionary<int, string>()
        {
            {  100, "10000184;25@3;1000@10000158;1@10000167;1@10010040;1" },
            {  300, "10000184;50@3;2000@10000158;2@10000167;2@10010081;1" },
            {  500, "10000184;50@3;2000@10000158;2@10000167;2@10000135;1" },
            {  1000, "10000184;125@3;5000@10000158;5@10000167;5@10000164;1" },
            {  2000, "10000184;250@3;10000@10000158;10@10000167;10@10010026;1" },
            {  3000, "10000184;250@3;10000@10000158;10@10000167;10@10000151;5" },
        };

        public static int GetNextShunXuReward(int curid)
        {
            foreach (var rewardinfo in PointsShunXuRewardList)
            {
                if (rewardinfo.Key > curid)
                {
                    return rewardinfo.Key;
                }
            }
            return 0;
        }

        //积分抽卡   权重-奖励
        public static List<TimerChouKaItemn> PointsChouKaList = new List<TimerChouKaItemn>()
        {
            new TimerChouKaItemn(){   Weight = 15,  ItemInfo =  "10000143;3" },     
            new TimerChouKaItemn(){   Weight = 15, ItemInfo =  "10000151;1" },    
            new TimerChouKaItemn(){   Weight = 15, ItemInfo =  "10010040;1" },    
            new TimerChouKaItemn(){   Weight = 5, ItemInfo =  "10010094;1" },  
            new TimerChouKaItemn(){  Weight = 15, ItemInfo =  "10000150;1" },   
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


        //成长树
        /// <summary>
        /// 成长树消耗道具列表  key道具id,  value获得成长值
        /// </summary>
        public static Dictionary<int, (int, int)> ActivityTreeCostItem = new Dictionary<int, (int, int)>()
        {
            { 10030031,(1, 3) },
            { 10030032,(5, 10) },
            { 10030033,(10, 20) }
        };

        /// <summary>
        /// 成长树阶段奖励
        /// </summary>
        public static List<ActivityTreeStageItem> ActivityTreeStageDesc = new List<ActivityTreeStageItem>()
        {
            new ActivityTreeStageItem(){ GrowthValue = 250, Name = "幼苗期", Reward = "3;300@10000184;50@1;150000@10010083;10@10010085;100@10000102;1" },
            new ActivityTreeStageItem(){ GrowthValue = 600, Name = "成长期", Reward = "3;300@10000184;100@1;300000@10010083;20@10010085;200@10000158;1" },
            new ActivityTreeStageItem(){ GrowthValue = 1200, Name = "盛开期", Reward = "3;300@10000184;150@1;500000@10010083;30@10010085;300@10010093;1" },
        };

        public static int GetActivityTreeStageItem(long growthvalue)
        {
            for (int i = 0; i < ActivityTreeStageDesc.Count; i++)
            {
                if (growthvalue < ActivityTreeStageDesc[i].GrowthValue)
                {
                    return i;
                }
            }
            return ActivityTreeStageDesc.Count;
        }

        /// <summary>
        /// 成长树施肥奖励
        /// </summary>
        public static List<ActivityTreeTendItem> ActivityTreeTendRewardItem = new List<ActivityTreeTendItem>()
        {
            new ActivityTreeTendItem(){ GrowthValueLower = 1, GrowthValueUpper = 10, Reward = 61400410 },
            new ActivityTreeTendItem(){ GrowthValueLower = 11, GrowthValueUpper = 20, Reward = 61400420 },
            new ActivityTreeTendItem(){ GrowthValueLower = 21, GrowthValueUpper = 100, Reward = 61400430 }
        };

        public static ActivityTreeTendItem GetActivityTreeTendItem(int score)
        {
            if (score < ActivityTreeTendRewardItem[0].GrowthValueLower)
            {
                return default;
            }

            for (int i = 0; i < ActivityTreeTendRewardItem.Count; i++)
            {
                if (score >= ActivityTreeTendRewardItem[i].GrowthValueLower 
                    && score <= ActivityTreeTendRewardItem[i].GrowthValueUpper)
                { 
                    return ActivityTreeTendRewardItem[i];   
                }
            }

            return ActivityTreeTendRewardItem[ActivityTreeTendRewardItem.Count - 1];
        }

        /// <summary>
        /// 订单刷新券
        /// </summary>
        public static string ActivityOrderRefreshItem = "10030040;1";

        /// <summary>
        /// 订单刷新时间（毫秒）
        /// </summary>
        public static long ActivityOrderRefreshTime = TimeHelper.Minute * 60;

        /// <summary>
        /// 订单列表  先随机档次 在从每个档次随机奖励
        /// 每个档次只配一个LevelWeight
        /// </summary>
        public static List<ActivityOrderItem> ActivityOrderItemList = new List<ActivityOrderItem>()
        {
            new ActivityOrderItem(){ Level = 1, LevelWeight = 1,  Weight = 1, Give = "10030041;2@10030042;1", Get = "10000184;1@1;5000", DropID = "61400510" },
            new ActivityOrderItem(){ Level = 1, LevelWeight = 0,  Weight = 1, Give = "10030041;1@10030042;2", Get = "10000184;1@1;5000", DropID = "61400510" },
            new ActivityOrderItem(){ Level = 1, LevelWeight = 0,  Weight = 1, Give = "10030041;2@10030042;2", Get = "10000184;1@1;5000", DropID = "61400510" },
            new ActivityOrderItem(){ Level = 1, LevelWeight = 0,  Weight = 1, Give = "10030041;3", Get = "10000184;1@1;5000", DropID = "61400510" },
            new ActivityOrderItem(){ Level = 1, LevelWeight = 0,  Weight = 1, Give = "10030042;3", Get = "10000184;1@1;5000", DropID = "61400510" },
            new ActivityOrderItem(){ Level = 1, LevelWeight = 0,  Weight = 1, Give = "10030044;1@10030042;1", Get = "10000184;1@1;5000", DropID = "61400510" },
            new ActivityOrderItem(){ Level = 1, LevelWeight = 0,  Weight = 1, Give = "10030044;1@10030041;1", Get = "10000184;1@1;5000", DropID = "61400510" },

            new ActivityOrderItem(){ Level = 2, LevelWeight = 1,  Weight = 1, Give = "10030043;2@10030044;1", Get = "10000184;3@1;15000", DropID = "61400520" },
            new ActivityOrderItem(){ Level = 2, LevelWeight = 0,  Weight = 1, Give = "10030043;1@10030044;2", Get = "10000184;3@1;15000", DropID = "61400520" },
            new ActivityOrderItem(){ Level = 2, LevelWeight = 0,  Weight = 1, Give = "10030043;2@10030042;2@10030041;1", Get = "10000184;3@1;15000", DropID = "61400520" },
            new ActivityOrderItem(){ Level = 2, LevelWeight = 0,  Weight = 1, Give = "10030044;2@10030042;1@10030041;2", Get = "10000184;3@1;15000", DropID = "61400520" },
            new ActivityOrderItem(){ Level = 2, LevelWeight = 0,  Weight = 1, Give = "10030043;2@10030041;3", Get = "10000184;3@1;15000", DropID = "61400520" },
            new ActivityOrderItem(){ Level = 2, LevelWeight = 0,  Weight = 1, Give = "10030044;2@10030042;3", Get = "10000184;3@1;15000", DropID = "61400520" },

            new ActivityOrderItem(){ Level = 3, LevelWeight = 0,  Weight = 1, Give = "10030045;2@10030043;2@10030042;2", Get = "10000184;5@1;30000", DropID = "61400530" },
            new ActivityOrderItem(){ Level = 3, LevelWeight = 0,  Weight = 1, Give = "10030045;2@10030044;2@10030041;2", Get = "10000184;5@1;30000", DropID = "61400530" },
            new ActivityOrderItem(){ Level = 3, LevelWeight = 0,  Weight = 1, Give = "10030045;2@10030044;1@10030043;1", Get = "10000184;5@1;30000", DropID = "61400530" },
            new ActivityOrderItem(){ Level = 3, LevelWeight = 0,  Weight = 1, Give = "10030045;2@10030042;5@10030041;5", Get = "10000184;5@1;30000", DropID = "61400530" },
            new ActivityOrderItem(){ Level = 3, LevelWeight = 0,  Weight = 1, Give = "10030046;1@10030043;1@10030042;3", Get = "10000184;5@1;30000", DropID = "61400530" },
            new ActivityOrderItem(){ Level = 3, LevelWeight = 0,  Weight = 1, Give = "10030046;1@10030044;1@10030044;3", Get = "10000184;5@1;30000", DropID = "61400530" }
        };

        /// <summary>
        /// 获取订单Id ..
        /// </summary>
        /// <returns></returns>
        public static int GenerateActivityOrderId()
        {
            List<int> levelIdList = new List<int>();
            List<int> levelWeight = new List<int>();

            for (int i = 0; i < ActivityOrderItemList.Count; i++)
            {
                ActivityOrderItem chouKa2Item = ActivityOrderItemList[i];
                if (!levelIdList.Contains(chouKa2Item.Level))
                {
                    levelIdList.Add(chouKa2Item.Level);
                    levelWeight.Add(chouKa2Item.Weight);
                }
            }

            int levelIndex = RandomHelper.RandomByWeight(levelWeight);
            int levelId = levelIdList[levelIndex];

            int preTotalIndex = 0;
            List <ActivityOrderItem>  levelItemList = new List<ActivityOrderItem>();
            for (int i = 0; i < ActivityOrderItemList.Count; i++)
            {
                ActivityOrderItem chouKa2Item = ActivityOrderItemList[i];

                if (chouKa2Item.Level < levelId)
                {
                    preTotalIndex++;    
                }
                if (chouKa2Item.Level == levelId)
                {
                    levelItemList.Add(chouKa2Item); 
                }
            }

            int weightindex = 0;
            int[] weightlist = new int[levelItemList.Count];
 
            for (int i = 0; i < levelItemList.Count; i++)
            {
                ActivityOrderItem chouKa2Item = levelItemList[i];
                weightlist[i] = chouKa2Item.Weight;
            }

            weightindex = RandomHelper.RandomByWeight(weightlist);

            weightindex += preTotalIndex;

            return weightindex; 
        }

        /// <summary>
        /// 抽卡消耗道具
        /// </summary>
        public static string Chou2CostItem = "10000184;30";


        /// <summary>
        /// 抽卡刷新道具   抽取6次也就是50%可以免费刷新，没到之前需要花费40冬季积分
        /// </summary>
        public static string Chou2FreshItem = "10000184;40";

        /// <summary>
        /// 每档随机取几个。抽满一半可以刷新
        /// </summary>
        public static List<ChouKa2Item> ChouKa2ItemList = new List<ChouKa2Item>()
        {
           new ChouKa2Item(){ Numer = 6, Weight = 50, Items =   new List<string>(){ "10010083;1", "10010083;3", "10000132;2", "10000132;5", "10000131;1", "10000131;3", "10010039;1", "10010041;2" , "10010042;2", "10010098;2", "10010098;2", "10010085;10", "10010091;1", "10010034;1", "10000184;30" }   },
           new ChouKa2Item(){ Numer = 4, Weight = 35, Items =  new List<string>(){ "10000166;1", "10010028;1", "10010033;1", "10010043;2", "10010037;2", "10010083;5", "10000142;1", "10010092;1" , "10010085;20", "10000184;60" } },
           new ChouKa2Item(){ Numer = 2, Weight = 15, Items = new List<string>(){ "10000150;1", "10000141;1", "10010040;1", "10010086;1", "10010046;1", "10010045;1", "10000143;1", "10010093;1" }  }
        };

        public static List<string> GetRewardListByType()
        {
            List<string> randomList = new List<string>();

            for (int i = 0; i < ChouKa2ItemList.Count; i++)
            {
                ChouKa2Item chouKa2Item = ChouKa2ItemList[i];
                List<string> rewardList = chouKa2Item.Items;

                int[] randomIds = RandomHelper.GetRandoms(chouKa2Item.Numer, 0, rewardList.Count);
                for (int random = 0; random < randomIds.Length; random++)
                {
                    randomList.Add(rewardList[randomIds[random]]);
                }
            }
            return randomList;
        }

        public static string GetChouKa2RewardList()
        {
            string rewardList = string.Empty;
            List<string> allrewardList = new List<string>();

            ////每一档取不同的数量
            allrewardList.AddRange(GetRewardListByType() );

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

        /// <summary>
        /// 1 2 3 档增加概率 1 档50% 2档35% 3档 15% 每次抽取先随机档位在随机
        /// </summary>
        /// <param name="rewardList"></param>
        /// <param name="rewardIds"></param>
        /// <returns></returns>
        public static int GetChouKa2RewardIndex(string rewardList, List<int> rewardIds)
        {
            int weightindex = 0;
            int[] weightlist = new int[ChouKa2ItemList.Count];
            int id_lower = 0;
            int id_upper = 0;

            for (int i = 0; i < ChouKa2ItemList.Count; i++)
            {
                ChouKa2Item chouKa2Item = ChouKa2ItemList[i];
                weightlist[i]  = chouKa2Item.Weight;        
            }

            weightindex = RandomHelper.RandomByWeight(weightlist);
            for (int i = 0; i < ChouKa2ItemList.Count; i++)
            {
                id_upper += ChouKa2ItemList[i].Numer;
                if (i >= weightindex)
                {
                    break;
                }
                id_lower += ChouKa2ItemList[i].Numer;
            }

            int allnumber = rewardList.Split('@').Length;
            List<int> leftIds = new List<int> {  };   
            List<int> weightids = new List<int> { };    
            for (int i = 0; i < allnumber; i++)
            {
                if (rewardIds.Contains(i))
                {
                    continue;
                }
                if (i >= id_lower && i < id_upper)
                {
                    weightids.Add(i);   
                }
                leftIds.Add(i);
            }

            if (leftIds.Count == 0)
            {
                return -1;
            }
            if (weightids.Count > 0)
            {
                return weightids[RandomHelper.RandomNumber(0, weightids.Count)];
            }
            return leftIds[ RandomHelper.RandomNumber(0, leftIds.Count) ];
        }

        /// <summary>
        /// 在野外击败怪物时会掉落元宵和饺子, 喂食道具会获得奖励哦
        /// </summary>

        public static Dictionary<int, KeyValuePairLong> FeedItemReward = new Dictionary<int, KeyValuePairLong>()
        {
            {  10030051, new KeyValuePairLong{ KeyId = 61400711, Value = 1, Value2 = 3  } },
            {  10030052, new KeyValuePairLong{ KeyId = 61400721, Value = 3, Value2 = 5  } },
            {  10030053, new KeyValuePairLong{ KeyId = 61400731, Value = 5, Value2 = 10  } }
        };

        ///当饱食度达到一定值时,会为每位贡献者赠送一个礼包哦

        public static Dictionary<int, string> Feed1RewardList = new Dictionary<int, string>()
        {
            { 1000, "3;200@1;100000@10000184;30@10000132;10@10010085;50@10010041;3"},
            { 2000, "3;200@1;100000@10000184;30@10010083;10@10010085;50@10010041;3"},
            { 3500, "3;200@1;100000@10000184;30@10010092;1@10010085;100@10010041;3"},
            { 5000, "3;200@1;100000@10000184;30@10000143;1@10010085;100@10010041;3"},
        };

        public static int GetFeed1RewardIndex(int lastindex, int  newid )
        {
            foreach (var costitem in ActivityConfigHelper.Feed1RewardList)
            {
                if (costitem.Key <= newid && costitem.Key > lastindex)
                {
                    return costitem.Key;
                }
            }
            return 0;
        }

        /// <summary>
        /// 每日礼包
        /// </summary>
        public static Dictionary<int, LiBaoListItem> LiBaoList = new Dictionary<int, LiBaoListItem>()
        {
            { 1,  new LiBaoListItem(){ Value = "37;498", Name = "魔能礼包", Value2 = "10010060;1@10000180;100@10000183;2@10000184;300" }}, //Value消耗钻石Value2道具
            { 2,  new LiBaoListItem(){ Value = "37;498", Name = "生肖礼包", Value2 = "10010053;1@10010037;50@10010052;2@10000184;300" }},
            { 3,  new LiBaoListItem(){ Value = "37;498", Name = "宝石礼包", Value2 = "10000107;1@10045108;1@10000108;2@10000184;300" }},
            { 4,  new LiBaoListItem(){ Value = "37;498", Name = "宠物礼包", Value2 = "10010093;3@10000166;20@10000131;100@10000184;300" }},
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
                "3;1000@1;300000@10000167;1@10000143;3",
                "3;1000@1;300000@10000167;1@10010045;1",
                "3;1000@1;300000@10000167;1@10010040;1",
                "3;1000@1;300000@10000167;1@10000141;1",
                "3;1000@1;300000@10000167;1@10000158;1",
                "3;1000@1;300000@10000167;1@10010081;1",
                "3;1000@1;300000@10000167;1@10000151;1"
            } },
            {  2, new List<string>()
            {
                "3;3000@10010045;1@10000151;1@10010081;3",
                "3;3000@10010045;1@10000151;1@10000167;3",
                "3;3000@10010045;1@10000151;1@10010026;1",
                "3;3000@10010045;1@10000151;1@10000141;2",
                "3;3000@10010045;1@10000151;1@10000167;3",
                "3;3000@10010045;1@10000151;1@10000164;1",
                "3;3000@10010045;1@10000151;1@10010094;1"
            } }
        };
    }
}