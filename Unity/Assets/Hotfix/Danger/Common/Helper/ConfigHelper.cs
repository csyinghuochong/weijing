using System.Collections.Generic;

namespace ET
{

    public static class ConfigHelper
    {

        public static int PetFramgeItemId = 10000152;       //神兽碎片兑换璀传承

        /// <summary>
        /// 竞技场buff
        /// </summary>
        public static List<int> SoloBuffIds = new List<int>() { 99004006 };  

        /// <summary>
        /// 奔跑大赛随机怪
        /// </summary>
        public static List<int> RunRaceMonsterList = new List<int>() { 90000021, 90000022, 90000023, 90000024, 90000025, 90000026, 90000027 };


        public static string TurtleWinNotice = "号选手获得了本次小龟大赛的最终胜利";

        /// <summary>
        /// 小龟说话
        /// </summary>
        //1移动 2停止
        public static Dictionary<int, List<string>> TurtleSpeakList = new Dictionary<int, List<string>>()
        {
            { 1, new List<string>(){ "不知道后面是不是有东西追我,我号好害怕,我要赶紧溜。", "加油,我一定是最后获得胜利的那只神龟","冲冲冲,我不会让大家失望的!" } },      //开始跑了
            { 2, new List<string>(){ "我好累,妈妈说累了就可以歇一歇", "好饱啊,我要停下来歇一歇。","唉呀,谁用石头丢了我一下,头好晕哦" } }
        };

        /// <summary>
        /// 小龟选手 npcconfig
        /// </summary>
        public static List<int> TurtleList = new List<int>() { 20099011, 20099012, 20099013 };

        public static List<BagInfo> GetHeQuReward(int lv)
        {
            List<BagInfo> rewards = new List<BagInfo>();
            if (lv < 50)
            {
                return rewards;
            }
            else
            {
                rewards.Add(new BagInfo() { GetWay = $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", ItemID = 10000143, ItemNum = 30 });
                rewards.Add(new BagInfo() { GetWay = $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", ItemID = 10010093, ItemNum = 1 });
                rewards.Add(new BagInfo() { GetWay = $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", ItemID = 10010041, ItemNum = 50 });
                rewards.Add(new BagInfo() { GetWay = $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", ItemID = 10010046, ItemNum = 1 });
                return rewards;
            }
        }

        //觉醒技能ID
        public static List<int> JueXingSkillIDList = new List<int>() {
            60031111,
            60031121,
            60031131,
            60031132,
            60031141,
            60031151,
            60031161,
            60031162,
        };


        /// <summary>
        /// 家园开启宠物仓库的消耗
        /// </summary>
        public static Dictionary<int, string> PetOpenCangKu = new Dictionary<int, string>()
        {
            //第一个格子默认开启
            { 1, "13;200000" },    //第二个格子
            { 2, "13;500000" },    //第三个格子
            { 3, "13;1000000" },   //第四个格子
            { 4, "13;2000000" },   //第五个格子
            { 5, "13;4000000" },   //第六个格子
        };

        //赠送钻石数量
        public static Dictionary<int, int> RechargeGive = new Dictionary<int, int>(8){
            { 6,        0},
            { 30,       300},
            { 50,       600},
            { 98,       1200},
            { 198,      2888},
            { 298,      4888},
            { 488,      8888},
            { 648,      12888},
        };
        public static int GetDiamondNumber(int key)
        {
            if (!RechargeGive.ContainsKey(key))
            {
                return 0;
            }
            int number = RechargeGive[key];
            return key * 100 + number;
        }


        ///// <summary>
        ///// 对比用
        ///// </summary>
        //public const string NoticeVersion = "1.0.0";        
        ////公告内容
        //public const string NoticeText =
        //    "版本更新内容\r\n1.更新家族系统,可以创建家族邀请其他玩家加入。\r\n2.开启游戏第六章第一个地图,60级可进入。\r\n3.新增宠物守护系统,根据宠物评分可以增加暴击等相关属性。\r\n4.增加家园访问，其他玩家可以互相访问家园。\r\n5.家园小地图显示石块和树叶方便玩家快速查询。\r\n6.赏金任务需要的怪物数量缩减。\r\n7.创建角色增加随机姓名。\r\n8.修复牧师技能不加攻击的问题。\r\n9.增加天气系统。\r\n10.增加野外碰到精灵和宠物的几率。";


        //类型对应部位
        public static Dictionary<int, List<EquipChuanChengList>> EquipChuanChengSkill = new Dictionary<int, List<EquipChuanChengList>>()
        {
            //攻击
            { 1, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69031001, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031002, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031003, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031004, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031005, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031006, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031007, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031008, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031009, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69031010, RandPro = 100 },
            }},

            //防御
            { 2, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69032001, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032002, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032003, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032004, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032005, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032006, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032007, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032008, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032009, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69032010, RandPro = 100 },
            }},

            //技能_战士
            { 11, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69033101, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033102, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033103, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033104, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033105, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033106, RandPro = 100 },
            }},

            //技能_法师
            { 12, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69033201, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033202, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033203, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033204, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033205, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69033206, RandPro = 100 },
            }},
        };

        //装备传承职业对应激活技能
        public static Dictionary<int, List<EquipChuanChengList>> EquipChuanChengSkillOccTwo = new Dictionary<int, List<EquipChuanChengList>>()
        {

            { 11, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69011101, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011102, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011103, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011104, RandPro = 100 },
            }},

            { 12, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69011201, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011202, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011203, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011204, RandPro = 100 },
            }},

            { 13, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69011301, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011302, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011303, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011304, RandPro = 100 },
            }},

            { 21, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69012101, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012102, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012103, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012104, RandPro = 100 },
            }},

            { 22, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69012201, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012202, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012203, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012204, RandPro = 100 },
            }},

            { 23, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69012301, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012302, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012303, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012304, RandPro = 100 },
            }},

        };

        //装备传承部位对应激活技能
        public static Dictionary<int, List<EquipChuanChengList>> EquipChuanChengSkillOcc = new Dictionary<int, List<EquipChuanChengList>>()
        {

            { 1, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69011001, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011002, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011003, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011004, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011005, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69011006, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69021011, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69021012, RandPro = 100 },

            }},

            { 2, new List<EquipChuanChengList>()
            {
                 new EquipChuanChengList() { SkillID = 69012001, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012002, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012003, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012004, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012005, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69012006, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69021013, RandPro = 100 },
                 new EquipChuanChengList() { SkillID = 69021014, RandPro = 100 },
            }},

        };

        //装备传承部位通用
        //技能id，权重概率
        public static List<EquipChuanChengList> EquipChuanChengSkillCom = new List<EquipChuanChengList>()
        {
            new EquipChuanChengList() { SkillID = 69041001, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69041002, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69041003, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69041004, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69041005, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69041006, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69041007, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021001, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021002, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021003, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021004, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021005, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021006, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021007, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021008, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021009, RandPro = 100 },
            new EquipChuanChengList() { SkillID = 69021010, RandPro = 100 },
        };

        //技能ID 随机权重
        public class EquipChuanChengList
        {
            public int SkillID;
            public int RandPro;
        }



        /// <summary>
        /// 宠物守护（0-3）
        /// </summary>
        public static List<KeyValuePair> PetShouHuAttri = new List<KeyValuePair>
        {
            new KeyValuePair(){  Value = "青龙守护", Value2 = "200101" },                      //暴击
            new KeyValuePair(){  Value = "白虎守护", Value2 = "200401" },                      //抗暴
            new KeyValuePair(){  Value = "朱雀守护", Value2 = "200201" },                      //命中
            new KeyValuePair(){  Value = "玄武守护", Value2 = "200301" },                      //闪避
            new KeyValuePair(){  Value = "神兽守护", Value2 = "" },
        };

        /// <summary>
        /// 家园大师 
        /// </summary>
        public static List<KeyValuePair> JiaYuanDaShiPro = new List<KeyValuePair>()
        {
            new KeyValuePair(){ KeyId = 1, Value = "美味大师1级", Value2 = "50@100203,1000" },
            new KeyValuePair(){ KeyId = 2, Value = "美味大师2级", Value2 = "100@100203,1500" },
            new KeyValuePair(){ KeyId = 3, Value = "美味大师3级", Value2 = "250@100203,2000" },
            new KeyValuePair(){ KeyId = 4, Value = "美味大师4级", Value2 = "500@100203,2500" },
            new KeyValuePair(){ KeyId = 5, Value = "美味大师5级", Value2 = "1000@100203,3000" },
            new KeyValuePair(){ KeyId = 6, Value = "美味大师6级", Value2 = "2000@100203,4000" },
        };

        /// <summary>
        /// 家园随机怪
        /// </summary>

        public static Dictionary<int, int> JiaYuanMonster = new Dictionary<int, int>()
        {
            { 83000101, 50 },       //石块  资金
            { 83000102, 30 },       //树叶  给材料
            { 83000103, 5 },        //宝箱
            { 83000104, 15 }        //带锁的宝箱
        };

        /// <summary>
        /// 序列号奖励 奖励最多不超过五个格子 
        /// </summary>
        public static Dictionary<long, string> SerialReward = new Dictionary<long, string>()
        {
             //评论奖励   金币100000  钻石 500    藏宝图 * 1   领主刷新券 * 1
             { 1, "1;100000@3;500@10010039;1@10010046;1" },
             { 2, "1;100000@3;500@10010039;1@10010046;1" },
             { 3, "1;50000@10000101;1" },
             { 4, "1;100000@3;500@10010039;1@10010046;1" },
             { 5, "1;100000@3;500@10010039;1@10010046;1" },
             { 6, "1;100000@3;500@10010039;1@10010046;1" },
             { 7, "1;100000@3;500@10010039;1@10010046;1" },
        };

        /// <summary>
        /// KeyId 节假日 Value 周末
        /// </summary>
        public static Dictionary<int, KeyValuePairInt> HolidayList = new Dictionary<int, KeyValuePairInt>()
        {
            { 20230405, new KeyValuePairInt{  KeyId =1, Value = 0  } },
            { 20230408, new KeyValuePairInt{  KeyId =0, Value = 1  } },
        };

        //生命之盾
        public static Dictionary<int, int> ItemAddShieldExp = new Dictionary<int, int>()
        {
            {10020001,1},
            {10021001,1},
            {10021002,1},
            {10021003,1},
            {10021004,1},
            {10021005,1},
            {10021006,1},
            {10021007,1},
            {10021008,200},
            {10021009,300},
            {10021010,1},
            {10022001,1},
            {10022002,1},
            {10022003,1},
            {10022004,1},
            {10022005,1},
            {10022006,1},
            {10022007,1},
            {10022008,200},
            {10022009,300},
            {10022010,1},
            {10023001,1},
            {10023002,1},
            {10023003,1},
            {10023004,1},
            {10023005,1},
            {10023006,1},
            {10023007,1},
            {10023008,200},
            {10023009,300},
            {10023010,1},
            {10024001,1},
            {10024002,1},
            {10024003,1},
            {10024004,1},
            {10024005,1},
            {10024006,1},
            {10024007,1},
            {10024008,200},
            {10024009,300},
            {10024010,1},
            {10025001,1},
            {10025002,1},
            {10025003,1},
            {10025004,1},
            {10025005,1},
            {10025006,1},
            {10025007,1},
            {10025008,200},
            {10025009,300},
            {10025010,1},
            {10010085,3 },
            {10010083,10 },
        };

        //购买背包
        public static List<BuyCellCost> BuyBagCellCosts = new List<BuyCellCost>
        {
            new BuyCellCost{ Cost = "10000156;1",Get = "10010041;5"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10010046;1"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10010093;1"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10000104;1"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10000143;5"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10010088;2"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10000150;1"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10000141;1"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10010086;2"},
            new BuyCellCost{ Cost = "10000156;1",Get = "10010026;1"},

        };

        //购买仓库
        public static List<BuyCellCost> BuyStoreCellCosts = new List<BuyCellCost>
        {
            //仓库1
            new BuyCellCost{ Cost = "3;360",Get = "10010083;5"},
            new BuyCellCost{ Cost = "3;360",Get = "10010085;200"},
            new BuyCellCost{ Cost = "3;360",Get = "10010039;1"},
            new BuyCellCost{ Cost = "3;360",Get = "10010046;1"},
            new BuyCellCost{ Cost = "3;360",Get = "10000143;2"},
            new BuyCellCost{ Cost = "3;360",Get = "10010041;1"},
            new BuyCellCost{ Cost = "3;360",Get = "10000101;1"},
            new BuyCellCost{ Cost = "3;360",Get = "10000122;1"},
            new BuyCellCost{ Cost = "3;360",Get = "10000132;10"},
            new BuyCellCost{ Cost = "3;360",Get = "10000143;2"},

            //仓库2
            new BuyCellCost{ Cost = "3;480",Get = "10010042;5"},
            new BuyCellCost{ Cost = "3;480",Get = "10000102;1"},
            new BuyCellCost{ Cost = "3;480",Get = "10010092;1"},
            new BuyCellCost{ Cost = "3;480",Get = "10010098;10"},
            new BuyCellCost{ Cost = "3;480",Get = "10000155;1"},
            new BuyCellCost{ Cost = "3;480",Get = "10010052;1"},
            new BuyCellCost{ Cost = "3;480",Get = "10010088;2"},
            new BuyCellCost{ Cost = "3;480",Get = "10000123;1"},
            new BuyCellCost{ Cost = "3;480",Get = "10010046;1"},
            new BuyCellCost{ Cost = "3;480",Get = "10000143;5"},

            //仓库3
            new BuyCellCost{ Cost = "3;600",Get = "10010083;10"},
            new BuyCellCost{ Cost = "3;600",Get = "10000131;10"},
            new BuyCellCost{ Cost = "3;600",Get = "10010083;10"},
            new BuyCellCost{ Cost = "3;600",Get = "10010046;1"},
            new BuyCellCost{ Cost = "3;600",Get = "10000143;5"},
            new BuyCellCost{ Cost = "3;600",Get = "10010039;1"},
            new BuyCellCost{ Cost = "3;600",Get = "10010088;2"},
            new BuyCellCost{ Cost = "3;600",Get = "10010043;5"},
            new BuyCellCost{ Cost = "3;600",Get = "10010099;1"},
            new BuyCellCost{ Cost = "3;600",Get = "10010026;1"},

            //仓库4
            new BuyCellCost{ Cost = "3;720",Get = "10010046;1"},
            new BuyCellCost{ Cost = "3;720",Get = "10010083;10"},
            new BuyCellCost{ Cost = "3;720",Get = "10010043;5"},
            new BuyCellCost{ Cost = "3;720",Get = "10010083;10"},
            new BuyCellCost{ Cost = "3;720",Get = "10010093;1"},
            new BuyCellCost{ Cost = "3;720",Get = "10000104;1"},
            new BuyCellCost{ Cost = "3;720",Get = "10010083;10"},
            new BuyCellCost{ Cost = "3;720",Get = "10010039;1"},
            new BuyCellCost{ Cost = "3;720",Get = "10000143;2"},
            new BuyCellCost{ Cost = "3;720",Get = "10000105;1"},

        };

        //客戶端活动提示
        public static List<ActivityTipConfig> ActivityShowList = new List<ET.ActivityTipConfig>
        {
            new ActivityTipConfig(){ OpenTime = 1940, OpenDay = new List<int>{-1}, CloseTime = 1950, Conent = "角斗场" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2000, OpenDay = new List<int>{1,3,5,0}, CloseTime = 2025, Conent = "世界领主活动开启" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2000, OpenDay = new List<int>{2,4,6}, CloseTime = 2025, Conent = "小龟赛跑" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2030, OpenDay = new List<int>{ -1},CloseTime = 2055, Conent = "战场活动开启" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2100, OpenDay = new List<int>{1,3,5,0},CloseTime = 2115, Conent = "宝藏活动开启" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2100, OpenDay = new List<int>{2,4,6},CloseTime = 2105, Conent = "变身大赛活动开启" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2130, OpenDay = new List<int>{1,3,5,0}, CloseTime = 2140, Conent = "狩猎活动" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2130, OpenDay = new List<int>{2,4,6}, CloseTime = 2140, Conent = "喜从天降" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2200, OpenDay = new List<int>{2,4,6},CloseTime = 2210, Conent = "家族入侵" , UIType = string.Empty },
            new ActivityTipConfig(){ OpenTime = 2200, OpenDay = new List<int>{1,3,5,0},CloseTime = 2200, Conent = "竞技场活动开启" , UIType = string.Empty },
            //new ActivityTipConfig(){ OpenTime = 2130, OpenDay = new List<int>{ -1},CloseTime = 2155, Conent = "竞技场活动开启"  , UIType = string.Empty },
            //示例
            //new ActivityTipConfig(){ OpenTime = 1516, CloseTime = 1517, Conent = "活动333" , UIType = "Main/Chat/UIChat"  },
        };

        //游戏公告
        public static List<WorldSayConfig> WorldSayList = new List<ET.WorldSayConfig>
        {
            new WorldSayConfig(){ Time = 1230, OpenDay = new List<int>{ -1},  Conent = "巨龙神已经准时出现在宝藏之地,想要挑战我的就带上你们的武器过来挑战我吧!"  },
            new WorldSayConfig(){ Time = 1930, OpenDay = new List<int>{ -1},  Conent = "一波红包雨已经来临,赶紧来看看自己是否是那个幸运玩家!"  },
            new WorldSayConfig(){ Time = 1940, OpenDay = new List<int>{ -1},  Conent = "角斗场已经开启,想要参加的勇士要抓紧时间哦!"  },
            new WorldSayConfig(){ Time = 2000, OpenDay = new List<int>{1,3,5,0},   Conent = "世界领主已经出现在密境中,赶紧过来看看吧!"  },
            new WorldSayConfig(){ Time = 2015, OpenDay = new List<int>{ -1},  Conent = "拍卖特惠已经开启,有需要的玩家可以购买哦!"  },
            new WorldSayConfig(){ Time = 2030, OpenDay = new List<int>{ -1},  Conent = "战场活动已经开启,可以通过右上角的战场按钮快速加入哦!"  },
            new WorldSayConfig(){ Time = 2100, OpenDay = new List<int>{ 1,3,5,0},  Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2110, OpenDay = new List<int>{ 1,3,5,0},  Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2120, OpenDay = new List<int>{ 1,3,5,0},  Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2100, OpenDay = new List<int>{ 2,4,6},  Conent = "变身大赛活动即将开启,想要参加的小伙伴记得要准时参加噢,5分钟后开启正式比赛!"  },
            //年兽
            new WorldSayConfig(){ Time = 2114, OpenDay = new List<int>{ -1},  Conent = "新年活动:新年的年兽-夕还有1分钟即将来到宝藏之地,主城的勇士们,带上你们的装备快去迎接挑战吧！"  },
            new WorldSayConfig(){ Time = 2115, OpenDay = new List<int>{ -1},  Conent = "新年的年兽-夕：我已经等了整整一年,弱者不配与我进行战斗,想要挑战我的就带上你们的装备过来吧,我已经到来到宝藏之地的中心！" },
            new WorldSayConfig(){ Time = 2000, OpenDay = new List<int>{ -1},  Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2100, OpenDay = new List<int>{ -1},  Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2200, OpenDay = new List<int>{ -1},  Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2200, OpenDay = new List<int>{ 2,4,6},  Conent = "家族入侵:家族出现了入侵怪兽,想要奖励的小勇士请带上你们的武器速速前往!"  },
            new WorldSayConfig(){ Time = 2200, OpenDay = new List<int>{ 1,3,5,0},  Conent = "竞技场活动已经开启,想要证明自己能力的小伙伴记得前往噢!"  },
        };

        //家园相关
        //开启牧场地块花费 0开始
        public static Dictionary<int, int> JiaYuanFarmOpen = new Dictionary<int, int>()
        {
            {4,5000},
            {5,10000},
            {6,20000},
            {7,30000},
            {8,40000},
            {9,55000},
            {10,70000},
            {11,85000},
            {12,100000},
            {13,120000},
            {14,150000},
            {15,180000},
            {16,210000},
            {17,250000},
            {18,300000},
            {19,400000}
        };

        //收购列表
        public static List<JiaYuanPurchase> JiaYuanPurchaseList = new List<JiaYuanPurchase>
        {
            new JiaYuanPurchase{ ItemID = 10036001,ItemNum = 1, BuyMinZiJin = 1500,BuyMaxZiJin = 3000},  //炒鸡蛋
            new JiaYuanPurchase{ ItemID = 10036002,ItemNum = 1, BuyMinZiJin = 2646,BuyMaxZiJin = 5292},  //咸鸭蛋
            new JiaYuanPurchase{ ItemID = 10036003,ItemNum = 1, BuyMinZiJin = 3345,BuyMaxZiJin = 6690},  //胡萝卜汁
            new JiaYuanPurchase{ ItemID = 10036004,ItemNum = 1, BuyMinZiJin = 3105,BuyMaxZiJin = 6210},  //腌蛋
            new JiaYuanPurchase{ ItemID = 10036005,ItemNum = 1, BuyMinZiJin = 3912,BuyMaxZiJin = 7824},  //红萝卜汁
            new JiaYuanPurchase{ ItemID = 10036006,ItemNum = 1, BuyMinZiJin = 3330,BuyMaxZiJin = 6660},  //鸡汤
            new JiaYuanPurchase{ ItemID = 10036007,ItemNum = 1, BuyMinZiJin = 7452,BuyMaxZiJin = 14904},  //兔绒披风
            new JiaYuanPurchase{ ItemID = 10036008,ItemNum = 1, BuyMinZiJin = 11448,BuyMaxZiJin = 22896},  //绒毛面具
            new JiaYuanPurchase{ ItemID = 10036009,ItemNum = 1, BuyMinZiJin = 7299,BuyMaxZiJin = 14598},  //红薯团
            new JiaYuanPurchase{ ItemID = 10036010,ItemNum = 1, BuyMinZiJin = 7658,BuyMaxZiJin = 15315},  //鸡蛋汉堡
            new JiaYuanPurchase{ ItemID = 10036011,ItemNum = 1, BuyMinZiJin = 7805,BuyMaxZiJin = 15609},  //烤肉
            new JiaYuanPurchase{ ItemID = 10036012,ItemNum = 1, BuyMinZiJin = 14396,BuyMaxZiJin = 28791},  //猪肉串
            new JiaYuanPurchase{ ItemID = 10036013,ItemNum = 1, BuyMinZiJin = 19662,BuyMaxZiJin = 39324},  //牛皮护腕
            new JiaYuanPurchase{ ItemID = 10036014,ItemNum = 1, BuyMinZiJin = 10236,BuyMaxZiJin = 20472},  //清蒸土豆
            new JiaYuanPurchase{ ItemID = 10036015,ItemNum = 1, BuyMinZiJin = 12014,BuyMaxZiJin = 24027},  //水果汁
            new JiaYuanPurchase{ ItemID = 10036016,ItemNum = 1, BuyMinZiJin = 15392,BuyMaxZiJin = 30783},  //南瓜羹
            new JiaYuanPurchase{ ItemID = 10036017,ItemNum = 1, BuyMinZiJin = 23364,BuyMaxZiJin = 46728},  //绒毛围裙
            new JiaYuanPurchase{ ItemID = 10036018,ItemNum = 1, BuyMinZiJin = 22941,BuyMaxZiJin = 45882},  //黄瓜汁
            new JiaYuanPurchase{ ItemID = 10036019,ItemNum = 1, BuyMinZiJin = 24843,BuyMaxZiJin = 49686},  //牛奶点心
            new JiaYuanPurchase{ ItemID = 10036020,ItemNum = 1, BuyMinZiJin = 19740,BuyMaxZiJin = 39480},  //西红柿炒蛋
            new JiaYuanPurchase{ ItemID = 10036021,ItemNum = 1, BuyMinZiJin = 22550,BuyMaxZiJin = 45099},  //美味拼盘
            new JiaYuanPurchase{ ItemID = 10036022,ItemNum = 1, BuyMinZiJin = 38349,BuyMaxZiJin = 76698},  //美味蛋糕
            new JiaYuanPurchase{ ItemID = 10036023,ItemNum = 1, BuyMinZiJin = 32340,BuyMaxZiJin = 64680},  //美味奶汁
            new JiaYuanPurchase{ ItemID = 10036024,ItemNum = 1, BuyMinZiJin = 40698,BuyMaxZiJin = 81396},  //玉米骨汤
            new JiaYuanPurchase{ ItemID = 10036025,ItemNum = 1, BuyMinZiJin = 25772,BuyMaxZiJin = 51543},  //风味肉汁
            new JiaYuanPurchase{ ItemID = 10036026,ItemNum = 1, BuyMinZiJin = 51462,BuyMaxZiJin = 102924},  //风味炒饭
            new JiaYuanPurchase{ ItemID = 10036027,ItemNum = 1, BuyMinZiJin = 37527,BuyMaxZiJin = 75054},  //风味奶酪
            new JiaYuanPurchase{ ItemID = 10036028,ItemNum = 1, BuyMinZiJin = 18240,BuyMaxZiJin = 36480},  //西红柿组合
            new JiaYuanPurchase{ ItemID = 10036029,ItemNum = 1, BuyMinZiJin = 22995,BuyMaxZiJin = 45990},  //风味南瓜粥
            new JiaYuanPurchase{ ItemID = 10036030,ItemNum = 1, BuyMinZiJin = 27378,BuyMaxZiJin = 54756},  //回味汤圆
            new JiaYuanPurchase{ ItemID = 10036031,ItemNum = 1, BuyMinZiJin = 5178,BuyMaxZiJin = 10356},  //烤鸡肉
            new JiaYuanPurchase{ ItemID = 10036032,ItemNum = 1, BuyMinZiJin = 11882,BuyMaxZiJin = 23763},  //红烧烤肉
            new JiaYuanPurchase{ ItemID = 10036033,ItemNum = 1, BuyMinZiJin = 31329,BuyMaxZiJin = 62658},  //加厚皮裙
            new JiaYuanPurchase{ ItemID = 10036034,ItemNum = 1, BuyMinZiJin = 26460,BuyMaxZiJin = 52920},  //香味奶汁
            new JiaYuanPurchase{ ItemID = 10036035,ItemNum = 1, BuyMinZiJin = 16521,BuyMaxZiJin = 33042},  //绿色果汁
        };

        //成就炼金使用这些药剂增加点数
        public static List<int> ChengJiuLianJin = new List<int>
        {
            13001002,13001003,13001004,13001005,13001006,
            13001101,13001102,13001103,13001104,13001105,
            13002002,13002003,13002004,13002005,13002006,
            13002101,13002102,13002103,13002104,13002105,
            13003003,13003003,13003004,13003005,13003006,
            13003101,13003102,13003103,13003104,13003105,
            13004004,13004004,13004004,13004005,13004006,
            13004101,13004102,13004103,13004104,13004105,
            13005005,13005005,13005005,13005005,13005006,
            13005101,13005102,13005103,13005104,13005105,
            13006002,13009001,13009002
        };

        //关卡boss显示列表
        public static List<int> BossShowTimeList = new List<int>
        {
            70001004,70001011,70001104,70001206,70001209,
            70002003,70002007,70002012,
            70003003,70003006,70003012,70003016,
            70004003,70004006,70004010,70004013,
            70005003,70005004,70005012,70005013,
            70006011,70006012
        };

        //副本深渊模式创建怪物   参数：场景ID,MonsterPositionConfigID
        public static Dictionary<int, int> ShenYuanCreateConfig = new Dictionary<int, int>()
        {
            {110001,90011},
            {110002,90012},
            {110003,90013},
            {110004,90014},
            {110005,90015},
        };

        /// <summary>
        /// 宠物守护队伍开启等级
        /// </summary>
        public static List<int> PetMiningTeamOpenLevel = new List<int>() { 1, 30, 40 };

        /// <summary>
        /// 宠物矿场
        /// </summary>
        public static Dictionary<int, List<PetMiningItem>> PetMiningList = new Dictionary<int, List<PetMiningItem>>()
        {
            { 10001, new List<PetMiningItem>(){ 
                new PetMiningItem() { X = 266, Y = -118 },  
                new PetMiningItem() { X= 653, Y = 2 }, 
                new PetMiningItem { X = 1017, Y = -118  }, 
                new PetMiningItem { X = 1672, Y = -38 },
                new PetMiningItem { X = 2277, Y = -88 },
            } },
            { 10002, new List<PetMiningItem>(){ 
                new PetMiningItem() { X = 201, Y = -42 },  
                new PetMiningItem() { X= 501, Y = -159 },
                new PetMiningItem { X = 990, Y = -164  }, 
                new PetMiningItem { X = 1260, Y = 106 },
                new PetMiningItem { X = 751, Y = 53 },
                new PetMiningItem() { X = 1673, Y = -109 },
                new PetMiningItem() { X= 2196, Y = -109 },
                new PetMiningItem { X = 2637, Y = -109  },
                new PetMiningItem { X = 2466, Y = 24 },
                new PetMiningItem { X = 1918, Y = 24 },
            } },
            { 10003, new List<PetMiningItem>(){ 
                new PetMiningItem() { X = 201, Y = 189 },  
                new PetMiningItem() { X= 208, Y = -197 }, 
                new PetMiningItem { X = 500, Y = -164  }, 
                new PetMiningItem { X = 496, Y = 152 }, 
                new PetMiningItem { X = 795, Y = 179 }, 
                new PetMiningItem { X = 798, Y = -197 },
                new PetMiningItem { X = 1082, Y = -176 },
                new PetMiningItem { X = 1084, Y = 155 },
                new PetMiningItem { X = 1367, Y = 168 },
                new PetMiningItem { X = 1359, Y = -174 },
                new PetMiningItem() { X = 2403, Y = 155 },
                new PetMiningItem() { X= 1618, Y = -189 },
                new PetMiningItem { X = 2141, Y = -197  },
                new PetMiningItem { X = 1625, Y = 160 },
                new PetMiningItem { X = 1882, Y = -164 },
                new PetMiningItem { X = 1876, Y = 152 },
                new PetMiningItem { X = 2138, Y = 179 },
                new PetMiningItem { X = 2401, Y = -176 },
                new PetMiningItem { X = 2673, Y = 168 },
                new PetMiningItem { X = 2671, Y = -174 },
            } },
        };

        /// <summary>
        /// 猎人切换状态CD
        /// </summary>
        public static long HunterSwichCD = TimeHelper.Second * 10;

        /// <summary>
        /// 猎人远程技能
        /// </summary>
        public static List<int> HunterFarSkill = new List<int>() {  63200101, 63200102, 63200103, 63200104 };

        /// <summary>
        /// 猎人近战技能
        /// </summary>
        public static List<int> HunterNearSkill = new List<int>() { 63200201, 63200202, 63200203, 63200204 };


        /// <summary>
        /// 新人抽奖 //KeyId权重 value道具..     第七天是武器ComHelp.GetWelfareWeapon
        /// </summary>
        public static List<KeyValuePair> WelfareDrawList = new List<KeyValuePair>
        {
            //第一天
            new KeyValuePair(){ KeyId = 10, Value = "10000161;2" },  
            //第二天
            new KeyValuePair(){ KeyId = 10,  Value = "11200000;1" },
            //第三天
            new KeyValuePair(){ KeyId = 0,  Value = "10010072;1" },
            //第四天
            new KeyValuePair(){ KeyId = 10,  Value = "10010033;1" },
            //第五天
            new KeyValuePair(){ KeyId = 0,  Value = "10010093;1" },
            //第六天
            new KeyValuePair(){ KeyId = 10,  Value = "10010073;1" },
            //第七天
            new KeyValuePair(){ KeyId = 0,  Value = "1;1" },
        };


        /// <summary>
        /// 投资金额, 只可以投六天，第七天领取奖励。  投资金额-》礼包
        /// </summary>
        public static List<KeyValuePair> WelfareInvestList = new List<KeyValuePair>()
        { 
            new KeyValuePair(){ KeyId = 50000, Value = "10000122;1" },
            new KeyValuePair(){ KeyId = 100000, Value = "10010088;1" },
            new KeyValuePair(){ KeyId = 150000, Value = "10010083;5" },
            new KeyValuePair(){ KeyId = 200000, Value = "10010033;1" },
            new KeyValuePair(){ KeyId = 250000, Value = "10000158;1" },
            new KeyValuePair(){ KeyId = 300000, Value = "10010046;1" },
        };

        /// <summary>
        /// 完成每天目标任务的奖励
        /// </summary>
        public static List<string> WelfareTaskReward = new List<string>() { "10000161;1@10010033;1@10010092;1", "10000161;1@10010051;1@10010093;1", "10000161;1@10000158;1@10010046;1", "10000161;1@10010033;1@10010086;1", "10000161;1@10010040;1@10000158;1", "10000161;1@10000143;3@10010086;1", "10000161;1@10049003;1@10010052;1" };

        /// <summary>
        /// 目标任务 TaskConfig
        /// </summary>
        public static List<List<int>> WelfareTaskList = new List<List<int>>()
        {
            //第一天
            new List<int>{ 71001001,71001002,71001003,71001004,71001005,71001006 },          
            //第二天
            new List<int>{ 71002001,71002002,71002003,71002004,71002005,71002006 },
            //第三天
            new List<int>{ 71003001,71003002,71003003,71003004,71003005 },
            //第四天
            new List<int>{ 71004001,71004002,71004003,71004004,71004005 },
            //第五天
            new List<int>{ 71005001,71005002,71005003,71005004,71005005 },
            //第六天
            new List<int>{ 71006001,71006002,71006003,71006004,71006005 },
            //第七天
            new List<int>{ 71007001,71007002,71007003,71007004,71007005 },
        };


        /// <summary>
        /// 累充奖励
        /// </summary>
        public static Dictionary<int, string> RechargeReward = new Dictionary<int, string>()
        {
            { 50, "10031014;1@10000143;5@10010045;1@10010086;2@10000141;1"  },
            { 98, "10000202;1@10000143;12@10010045;2@10010086;3@10000150;1" }
        };


        /// <summary>
        /// 角色属性推荐加点,按比例加点
        /// </summary>
        public static Dictionary<int, string> RecommendAddPoint = new Dictionary<int, string>()
        {
            { 1, "3@0@1@1@0" },
            { 2, "0@3@1@1@0" },
            { 3, "2@0@1@1@1" },
            { 101, "0@3@1@1@0" },
            { 102, "0@0@1@1@3" },
            { 103, "3@0@1@1@0" },
            { 201, "0@3@1@1@0" },
            { 202, "0@3@1@1@0" },
            { 203, "0@3@1@1@0" },
            { 301, "2@0@1@1@1" },
            { 302, "2@0@1@1@1" },
            { 303, "2@0@1@1@1" }
        };

        public static Dictionary<int, string> PropertyHint = new Dictionary<int, string>()
        {
            { NumericType.Now_MaxHp, "自身的生命值上限,当生命值为0时便意味着自身的挑战失败" },
            { NumericType.Now_MaxAct, "伤害基础值,对目标造成伤害的主要属性" },
            { NumericType.Now_MaxDef, "物理防御,可以抵扣物理攻击带来的伤害" },
            { NumericType.Now_MaxAdf, "法术防御,可以抵扣魔法攻击带来的伤害" },
            { NumericType.Now_Mage, "会额外提升你所有的技能造成的伤害" },
            { NumericType.Now_Constitution, "提升生命和闪避，伤害减免属性" },
            { NumericType.Now_Power, "提升攻击，物防和物穿攻速属性" },
            { NumericType.Now_Intellect, "提升技能伤害，魔防和魔穿属性" },
            { NumericType.Now_Stamina, "提升双防，抗暴，战斗回血属性" },
            { NumericType.Now_Agility, "提升攻速，攻击，冷却缩减属性" },
            { NumericType.Now_Cri, "本次攻击触发暴击的概率" },
            { NumericType.Now_MageDamgeSubPro, "降低受到魔法类技能的伤害" },
            { NumericType.Now_Res, "抵抗对方暴击的概率和抵抗眩晕等控制类技能" },
            { NumericType.Now_ZhongJiPro, "攻击有概率使目标的防御降低为0,无视对方防御进行攻击" },
            { NumericType.Now_Hit, "命中敌人的附加概率，和闪避概率进行抵消" },
            { NumericType.Now_ZhongJi, "触发重击后额外附加的伤害值" },
            { NumericType.Now_Dodge, "受到敌人攻击闪避本次攻击的概率，可闪避普攻和技能" },
            { NumericType.Now_HuShiActPro, "攻击中降低敌人物理防御值百分比" },
            { NumericType.Now_HuShiMagePro, "攻击中降低敌人魔法防御值百分比" },
            { NumericType.Now_DamgeSubPro, "受到敌人攻击的伤害后，降低本次受到的伤害" },
            { NumericType.Now_HuShiDef, "攻击中降低敌人物理防御值固定值" },
            { NumericType.Now_Speed, "自身在地图中移动的速度" },
            { NumericType.Now_SkillCDTimeCostPro, "降低释放技能的冷却时间" },
            { NumericType.Now_CriLv, "根据当前的暴击等级换算成暴击概率附加到自身属性" },
            { NumericType.Now_MageDodgePro, "受到魔法技能伤害时,可以躲避本次魔法伤害的概率" },
            { NumericType.Now_ResLv, "根据当前的韧性等级换算成韧性概率附加到自身属性" },
            { NumericType.Now_ActDodgePro, "受到物理技能伤害时,可以躲避本次魔法伤害的概率" },
            { NumericType.Now_HitLv, "根据当前的命中等级换算成命中概率附加到自身属性" },
            { NumericType.Now_GeDang, "受到伤害可以减免对应的伤害值" },
            { NumericType.Now_DodgeLv, "根据当前的闪避等级换算成闪避概率附加到自身属性" },
            { NumericType.Now_ZhenShi, "每次攻击额外增加的固定伤害" },
            { NumericType.Now_ActDamgeAddPro, "使用物理攻击目标时额外造成的伤害" },
            { NumericType.Now_ActSpeedPro, "可以加快自身普通攻击的攻击频率" },
            { NumericType.Now_MageDamgeAddPro, "使用魔法攻击目标时额外造成的伤害" },
            { NumericType.Now_ShenNongPro, "使用药剂和技能为自身恢复生命值时,可以获得额外恢复的能力" },
            { NumericType.Now_ActDamgeSubPro, "受到物理伤害可以降低自身受到的伤害值" },
            { NumericType.Now_HuiXue, "战斗中提升额外的生命恢复" },
            { NumericType.Now_HuShiAdf, "攻击中降低敌人魔法防御值固定值" },
            { NumericType.Now_Luck, "当幸运达到10点时,你将刀刀发挥最高攻击!" }
        };
        
        
        /// <summary>
        /// 背包一键出售
        /// </summary>
        public static List<List<int>> OneSellList = new List<List<int>>()
        {
            // 基础
            new List<int> { 11300101,11300102,11300103,11300104,11300105 },
            // 中级
            new List<int> { 11300201,11300202,11300203,11300204,11300205 },
            // 高级
            new List<int> { 11300301,11300302,11300303,11300304,11300305 },
            // 特级
            new List<int> { 11300401,11300402,11300403,11300404,11300405 },
            // 超级 
            new List<int> { 11300501,11300502,11300503,11300504,11300505 }
        };


        /// <summary>
        /// 一键出售材料
        /// </summary>
        public static List<int> OneSellMaterialList = new List<int>()
        {
           10021001,10021002,10021003,10021004,10021005,10021006,10021007,10021010,
            10022001,10022002,10022003,10022004,10022005,10022006,10022007,10022010,
            10023001,10023002,10023003,10023004,10023005,10023006,10023007,10023010,
            10024001,10024002,10024003,10024004,10024005,10024006,10024007,10024010,
            10025001,10025002,10025003,10025004,10025005,10025006,10025007,10025010,
        };


        /// <summary>
        /// 神兽羁绊属性
        /// </summary>
        public static Dictionary<int, List<PropertyValue>> ShenShouJiBan = new Dictionary<int, List<PropertyValue>>()
        {
            { 1, new List<PropertyValue>(){ new PropertyValue() { HideID = 201003,  HideValue = 1000 } } },
            { 2, new List<PropertyValue>(){ new PropertyValue() { HideID = 200903, HideValue = 1000 }/*, new PropertyValue() { HideID = 105201, HideValue = 0 }*/ } },
            { 3, new List<PropertyValue>(){ new PropertyValue() { HideID = 200903, HideValue = 1500 } } },
        };


        /// <summary>
        /// 施法前吟唱时给自己添加一个buff
        /// </summary>
        public static Dictionary<int, int> SingingBuffList = new Dictionary<int, int>
        {
            //驭剑士光能击吟唱为霸体状态
            { 61022102, 80001033 },
            { 61022103, 80001033 },
            { 61022104, 80001033 },
            { 61022105, 80001033 },
            { 61022106, 80001033 },
        };

        /// <summary>
        /// 支持批量使用的道具.  目前服务器只支持ItemSubType = 111 的道具批量使用
        /// 支持批量使用的道具客户端点击使用的时候二次弹框，输入使用数量。
        /// self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, 使用数量).Coroutine();
        /// </summary>
        public static List<int> BatchUseItemList = new List<int>() { 10010042, 10010043 };


        public static List<BossDevelopment> BossDevelopmentList_5 = new List<BossDevelopment>()
        {
            new BossDevelopment(){ Name = "初级领主", Level = 1, AttributeAdd = 1f,   ExpAdd = 1f,   ReviveTimeAdd = 1f,     DropAdd = 1f,   KillNumber = 0 },
            new BossDevelopment(){ Name = "次级领主", Level = 2, AttributeAdd = 1.1f, ExpAdd = 1.25f,    ReviveTimeAdd = 1.25f,   DropAdd = 1.15f, KillNumber = 3 },
            new BossDevelopment(){ Name = "中级领主", Level = 3, AttributeAdd = 1.2f, ExpAdd = 1.5f,    ReviveTimeAdd = 1.5f,     DropAdd = 1.3f, KillNumber = 5 },
            new BossDevelopment(){ Name = "高级领主", Level = 4, AttributeAdd = 1.3f, ExpAdd = 1.75f,    ReviveTimeAdd = 1.75f,   DropAdd = 1.4f, KillNumber = 10 },
            new BossDevelopment(){ Name = "终级领主", Level = 5, AttributeAdd = 1.4f, ExpAdd = 2f,    ReviveTimeAdd = 2f,     DropAdd = 1.5f, KillNumber = 20 },
        };

        public static List<BossDevelopment> BossDevelopmentList_6 = new List<BossDevelopment>()
        {
            new BossDevelopment(){ Name = "初级领主", Level = 1, AttributeAdd = 1f,    ExpAdd = 1f,   ReviveTimeAdd = 1f,     DropAdd = 1f,   KillNumber = 0 },
            new BossDevelopment(){ Name = "次级领主", Level = 2, AttributeAdd = 1.1f,  ExpAdd = 1.25f,  ReviveTimeAdd = 1.25f,   DropAdd = 1.15f, KillNumber = 3 },
            new BossDevelopment(){ Name = "中级领主", Level = 3, AttributeAdd = 1.2f,  ExpAdd = 1.5f,   ReviveTimeAdd = 1.5f,     DropAdd = 1.3f, KillNumber = 5 },
            new BossDevelopment(){ Name = "高级领主", Level = 4, AttributeAdd = 1.3f,  ExpAdd = 1.75f,   ReviveTimeAdd = 1.75f,   DropAdd = 1.4f, KillNumber = 10 },
            new BossDevelopment(){ Name = "终级领主", Level = 5, AttributeAdd = 1.4f,  ExpAdd = 2f,   ReviveTimeAdd = 2f,     DropAdd = 1.5f, KillNumber = 20 },
        };

        public static List<BossDevelopment> GetBossDevelopmentByChapter(int chapterid)
        {
            if (chapterid == 6)
            {
                return BossDevelopmentList_6;
            }
            else
            {
                return BossDevelopmentList_5;
            }
        }

        public static BossDevelopment GetBossDevelopmentByKill(int chapterid, int killNumber)
        {
            List<BossDevelopment> BossDevelopmentList = GetBossDevelopmentByChapter(chapterid);

            for (int i = BossDevelopmentList.Count - 1; i >=0; i--)
            {
                if (killNumber >= BossDevelopmentList[i].KillNumber)
                { 
                    return BossDevelopmentList[i];  
                }
            }
            return BossDevelopmentList[0];
        }

        public static BossDevelopment GetBossDevelopmentById(int chapterid, int level)
        {
            List<BossDevelopment> BossDevelopmentList = GetBossDevelopmentByChapter(chapterid);

            for (int i = BossDevelopmentList.Count - 1; i >= 0; i--)
            {
                if (level == BossDevelopmentList[i].Level)
                {
                    return BossDevelopmentList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// 三个对应等级套装属性
        /// </summary>

        public static Dictionary<int, string> PetSuitProperty = new Dictionary<int, string>()
        {
                {  5, "205003,0.05;203003,0.2;203103,0.2" },
                {  8, "205003,0.1;203003,0.25;203103,0.25" },
                {  10, "205003,0.15;203003,0.3;203103,0.3" },
        };

        public static string GetPetSuitProperty(List<int> pethexinLv)
        {
            int lv5number = 0;
            int lv8number = 0;
            int lv10number = 0;
            for (int i = 0; i < pethexinLv.Count; i++)
            {
                if (pethexinLv[i] >= 5)
                {
                    lv5number++;
                }
                if (pethexinLv[i] >= 8)
                {
                    lv8number++;
                }
                if (pethexinLv[i] >= 10)
                {
                    lv10number++;
                }
            }

            if (lv10number >= 3)
            {
                return PetSuitProperty[10];
            }
            if (lv8number >= 3)
            {
                return PetSuitProperty[8];
            }
            if (lv5number >= 3)
            {
                return PetSuitProperty[5];
            }
            return null;
        }

        /// <summary>
        /// 等级奖励,大于或等于可以领取奖励.  一个道具直接领取，多个道具弹出选择界面
        /// 三个职业 以&切分
        /// </summary>
        public static Dictionary<int, string> LeavlRewardItem = new Dictionary<int, string>()
        {
            //14060006
            { 5, "14060006;1" },            //升级到6级装备
            { 8,  "14100021;1@14100022;1&14100121;1@14100122;1&14100221;1" },       //本职业特色武器
            { 10, "10031002;1" },       //小松鼠
            { 12, "10010033;1" },       //金钥匙
            { 14, "10000106;1" },       //国王的宝石箱子
            { 16, "10000120;1" },       //国王的装备盒子
            { 18, "10000122;1" },       //二章装备盒子
            { 20, "10010092;1" },       //稀少的宠物蛋
            { 22, "10000156;1" },       //背包扩展袋子
            { 24, "10000158;1" },       //封印之塔挑战凭证
            { 26, "10000140;1" },       //忘灵丹
            { 28, "10010088;5" }       //体力补充
        };


        /// <summary>  
        /// 击杀怪物奖励。     NumericType.KillMonsterNumber击杀怪物数量  NumericType.KillMonsterReward击杀怪物领取奖励记录
        /// </summary>
        public static Dictionary<int, string> KillMonsterReward = new Dictionary<int, string>
        {
            { 50, "10041101;1" },       //优秀的赤精石
            { 100, "14070003;1" },      //森之戒指
            { 200, "10010091;1" },      //幼小的宠物蛋
            { 300, "10000121;1" },      //一章装备盒子
            { 500, "14080002;1" },      //精灵守护
            { 750, "11200001;1" },      //锻造鉴定符
            { 1000, "10010046;1" },     //领主刷新券

            //{ 300, "14100021;1@14100022;1&14100121;1@14100122;1&14100221;1" }
        };

        /// <summary>
        /// 跑环任务奖励
        /// </summary>
        public static Dictionary<int, int> RingTaskDrop = new Dictionary<int, int>()
        {
            { 20, 61500001},   //完成每20环对应奖励
            { 40, 61500001},
            { 60, 61500001},
            { 80, 61500001},
            { 100, 61500011},
        };

        /// <summary>
        /// 周任务奖励
        /// </summary>
        public static Dictionary<int, int> WeekTaskDrop = new Dictionary<int, int>()
        {
            { 10, 61500001},   //完成每20环对应奖励
        };

        /// <summary>
        /// 宠物探宝奖励
        /// </summary>
        public static Dictionary<int, string> PetExploreReward = new Dictionary<int, string>()
        {
            { 50, "10010086;1$3;100,1000" }, //钻石特殊处理, 也可以定位其他格式
            { 100, "10010096;1$3;200,1000" }, //钻石特殊处理
            { 150, "10010094;1$3;300,1500" },
            { 200, "10010094;1$3;400,2000" },
            { 300, "10000136;1$3;500,2500" },
        };

        /// <summary>
        /// 宠物核心探宝奖励
        /// </summary>
        public static Dictionary<int, string> PetHeXinExploreReward = new Dictionary<int, string>()
        {
            { 50, "10020001;1$1;100,1000" }, //钻石特殊处理, 也可以定位其他格式
            { 100, "10020001;1$1;200,1000" }, //钻石特殊处理
            { 150, "10020001;1$1;300,1500" },
            { 200, "10020001;1$1;400,2000" },
            { 300, "10020001;1$1;500,2500" },
        };

        /// <summary>
        /// 宠物抽奖掉落展示
        /// </summary>
        public static string PetChouKaRewardItemShow =
                "10000136;1@10010078;1@10010079;1@10010093;1@10010086;1@10010096;1@10031015;1@10031016;1@10031017;1@10031014;1@10031013;1@10031012;1@10031011;1@10031010;1@10031009;1@10060105;1@10060205;1@10060305;1@10060405;1@10060505;1@10060605;1@10060705;1";

        /// <summary>
        /// 宠物之核抽奖掉落展示
        /// </summary>
        public static string PetHeXinChouKaRewardItemShow = "10060205;1@10060305;1@10060405;1@10060505;1@10060605;1@10060705;1";


        public static List<int> BaoShiBuff = new List<int>() { 99001042, 99001031, 99001032, 99001011 };
        public static List<int> DonationBuff = new List<int>() { 99003011 , 99003012, 99003013, 99003021, 99003022, 99003023,
                                                                99003031, 99003032, 99003033,99003041,  99003042, 99003043,
                                                                99003051, 99003052,99003053,99003061,99003062,99003063, 99003064};


        

        public static List<string> RankChengHao = new List<string>() { "天下第一勇士", "天下第二勇士", "天下第三勇士" };
        public static List<string> OccRankChengHao = new List<string>() { 
            "全区第一战士", "全区第二战士", "全区第三战士",
            "全区第一法师","全区第二法师","全区第三法师",
            "全区第一猎人","全区第二猎人","全区第三猎人" };

        /// <summary>
        /// 职业排行榜第一名buff 
        /// </summary>
        public static List<int> CombatRankBuff = new List<int>() {
            99007001, 99007002, 99007003,
            99007001, 99007002, 99007003,
            99007001, 99007002, 99007003 };


        /// <summary>
        /// 第一个权重大优先显示全区称号
        /// </summary>
        public static List<int> ChengHaoWeight = new List<int>() { 100, 0 };

        public static int GetRankBuff(int rankId, int occRankId, int occ)
        {
            if (occRankId >= 1 && occRankId <= 3)
            {
                return CombatRankBuff[(occ - 1) * 3 + occRankId - 1];
            }
            return 0;
        }

        public static string GetRankChengHao(int rankId, int occRankId, int occ)
        {
            //int weight_0 = ChengHaoWeight[0];
            //int weight_1 = ChengHaoWeight[1];
            //if (weight_0 >= weight_1 &&  rankId >= 1 && rankId <= 3)
            //{
            //    return RankChengHao[rankId - 1];
            //}
            //if (weight_0 < weight_1 && occRankId == 1)
            //{
            //    return OccRankChengHao[occ - 1];
            //}
            //if (rankId >= 1 && rankId <= 3)
            //{
            //    return RankChengHao[rankId - 1];
            //}
            if ( occRankId >= 1 && occRankId <= 3)
            {
                return OccRankChengHao[ (occ - 1) * 3 + occRankId - 1 ];
            }
            return string.Empty;
        }


        /// <summary>
        /// 单笔充值奖励
        /// </summary>
        public static Dictionary<int, string> SingleRechargeReward = new Dictionary<int, string>()
        {
            { 6, "1;100000@10000122;1@10010086;1" },
            { 30, "10000141;1@10000164;1@10000158;1" }, 
            { 50, "10010045;1@10000164;1@10000158;2@10010079;1" }, 
            { 98, "10000135;1@10000164;1@10010086;2@10010079;1" },
            { 198, "10000134;1@10000150;1@10010026;1@10000137;1@10010053;1" },
            { 298, "10000134;1@10000150;1@10010026;1@10000138;1@10010094;1" },
            { 488, "10049101;1@10000150;1@10010026;1@10000137;2@10000143;5" },
            { 648, "10000134;1@10049101;1@10000150;1@10010026;1@10000138;2@10000143;10" }
        };
        
        
        /// <summary>
        /// 洗练次数奖励
        /// </summary>
        public static Dictionary<int, string> ItemXiLianNumReward = new Dictionary<int, string>()
        {
            { 30, "1;200000@10000158;1$1;0,0" },
            { 80, "1;300000@10000158;2$1;0,0" },
            { 150, "1;500000@10010053;1@10000151;1$1;0,0" },
            { 300, "1;1000000@10000151;1@11200000;1$1;0,0" },
        };

        /// <summary>
        /// 个人副本  gm账号显示副本和新地图,大于等于指定副本id不显示
        /// </summary>
        public static int GMDungeonId = 900000;


        /// <summary>
        /// 组队副本  gm账号显示副本和新地图,大于等于指定副本id不显示
        /// </summary>
        public static int GmTeamdungeonId = 110006;
    }
}
