using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;

namespace ET
{

    public static class ConfigHelper
    {

        /// <summary>
        /// 宠物守护（0-3）
        /// </summary>

        public static List<KeyValuePair> PetShouHuAttri = new List<KeyValuePair>
        {
            new KeyValuePair(){  Value = "青龙守护", Value2 = "100203;1000@100203;1000" },
            new KeyValuePair(){  Value = "白虎守护", Value2 = "100203;1000" },
            new KeyValuePair(){  Value = "朱雀守护", Value2 = "100203;1000" },
            new KeyValuePair(){  Value = "玄武守护", Value2 = "100203;1000" },
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
            { 83000101, 60 },       //石块  资金
            { 83000102, 30 },       //树叶  给材料
            { 83000103, 10 }        //宝箱
        };


        //奖励最多不超过五个格子
        public static Dictionary<long, string> SerialReward = new Dictionary<long, string>()
        {
             //评论奖励   金币100000  钻石 500    藏宝图 * 1   领主刷新券 * 1
             { 1, "1;100000@3;500@10010039;1@10010046;1" },
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
        
        //游戏公告
        public static List<WorldSayConfig> WorldSayList = new List<ET.WorldSayConfig>
        {
            new WorldSayConfig(){ Time = 1230, Conent = "巨龙神已经准时出现在宝藏之地,想要挑战我的就带上你们的武器过来挑战我吧!"  },
            new WorldSayConfig(){ Time = 1930, Conent = "一波红包雨已经来临,赶紧来看看自己是否是那个幸运玩家!"  },
            new WorldSayConfig(){ Time = 1940, Conent = "角斗场已经开启,想要参加的勇士要抓紧时间哦!"  },
            new WorldSayConfig(){ Time = 2000, Conent = "世界领主已经出现在密境中,赶紧过来看看吧!"  },
            new WorldSayConfig(){ Time = 2030, Conent = "战场活动已经开启,可以通过右上角的战场按钮快速加入哦!"  },
            new WorldSayConfig(){ Time = 2100, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2110, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2120, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },

            //年兽
            new WorldSayConfig(){ Time = 2114, Conent = "新年活动:新年的年兽-夕还有1分钟即将来到宝藏之地,主城的勇士们,带上你们的装备快去迎接挑战吧！"  },
            new WorldSayConfig(){ Time = 2115, Conent = "新年的年兽-夕：我已经等了整整一年,弱者不配与我进行战斗,想要挑战我的就带上你们的装备过来吧,我已经到来到宝藏之地的中心！" },
            new WorldSayConfig(){ Time = 2000, Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2100, Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2200, Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
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
            new JiaYuanPurchase{ ItemID = 10036001,ItemNum = 1, BuyMinZiJin = 2000,BuyMaxZiJin = 3999},  //炒鸡蛋
            new JiaYuanPurchase{ ItemID = 10036002,ItemNum = 1, BuyMinZiJin = 3780,BuyMaxZiJin = 7560},  //咸鸭蛋
            new JiaYuanPurchase{ ItemID = 10036003,ItemNum = 1, BuyMinZiJin = 4956,BuyMaxZiJin = 9912},  //胡萝卜汁
            new JiaYuanPurchase{ ItemID = 10036004,ItemNum = 1, BuyMinZiJin = 4350,BuyMaxZiJin = 8700},  //腌蛋
            new JiaYuanPurchase{ ItemID = 10036005,ItemNum = 1, BuyMinZiJin = 5951,BuyMaxZiJin = 11901},  //红萝卜汁
            new JiaYuanPurchase{ ItemID = 10036006,ItemNum = 1, BuyMinZiJin = 4832,BuyMaxZiJin = 9663},  //鸡汤
            new JiaYuanPurchase{ ItemID = 10036007,ItemNum = 1, BuyMinZiJin = 11592,BuyMaxZiJin = 23184},  //兔绒披风
            new JiaYuanPurchase{ ItemID = 10036008,ItemNum = 1, BuyMinZiJin = 18096,BuyMaxZiJin = 36192},  //绒毛面具
            new JiaYuanPurchase{ ItemID = 10036009,ItemNum = 1, BuyMinZiJin = 11378,BuyMaxZiJin = 22755},  //红薯团
            new JiaYuanPurchase{ ItemID = 10036010,ItemNum = 1, BuyMinZiJin = 11928,BuyMaxZiJin = 23856},  //鸡蛋汉堡
            new JiaYuanPurchase{ ItemID = 10036011,ItemNum = 1, BuyMinZiJin = 12170,BuyMaxZiJin = 24339},  //烤肉
            new JiaYuanPurchase{ ItemID = 10036012,ItemNum = 1, BuyMinZiJin = 23700,BuyMaxZiJin = 47400},  //猪肉串
            new JiaYuanPurchase{ ItemID = 10036013,ItemNum = 1, BuyMinZiJin = 32688,BuyMaxZiJin = 65376},  //牛皮护腕
            new JiaYuanPurchase{ ItemID = 10036014,ItemNum = 1, BuyMinZiJin = 16617,BuyMaxZiJin = 33234},  //清蒸土豆
            new JiaYuanPurchase{ ItemID = 10036015,ItemNum = 1, BuyMinZiJin = 19868,BuyMaxZiJin = 39735},  //水果汁
            new JiaYuanPurchase{ ItemID = 10036016,ItemNum = 1, BuyMinZiJin = 24240,BuyMaxZiJin = 48480},  //南瓜羹
            new JiaYuanPurchase{ ItemID = 10036017,ItemNum = 1, BuyMinZiJin = 36768,BuyMaxZiJin = 73536},  //绒毛围裙
            new JiaYuanPurchase{ ItemID = 10036018,ItemNum = 1, BuyMinZiJin = 37367,BuyMaxZiJin = 74733},  //黄瓜汁
            new JiaYuanPurchase{ ItemID = 10036019,ItemNum = 1, BuyMinZiJin = 46626,BuyMaxZiJin = 93252},  //牛奶点心
            new JiaYuanPurchase{ ItemID = 10036020,ItemNum = 1, BuyMinZiJin = 29360,BuyMaxZiJin = 58719},  //西红柿炒蛋
            new JiaYuanPurchase{ ItemID = 10036021,ItemNum = 1, BuyMinZiJin = 48996,BuyMaxZiJin = 97992},  //美味拼盘
            new JiaYuanPurchase{ ItemID = 10036022,ItemNum = 1, BuyMinZiJin = 63432,BuyMaxZiJin = 126864},  //美味蛋糕
            new JiaYuanPurchase{ ItemID = 10036023,ItemNum = 1, BuyMinZiJin = 77766,BuyMaxZiJin = 155532},  //美味奶汁
            new JiaYuanPurchase{ ItemID = 10036024,ItemNum = 1, BuyMinZiJin = 70707,BuyMaxZiJin = 141414},  //玉米骨汤
            new JiaYuanPurchase{ ItemID = 10036025,ItemNum = 1, BuyMinZiJin = 75294,BuyMaxZiJin = 150588},  //风味肉汁
            new JiaYuanPurchase{ ItemID = 10036026,ItemNum = 1, BuyMinZiJin = 78258,BuyMaxZiJin = 156516},  //风味炒饭
            new JiaYuanPurchase{ ItemID = 10036027,ItemNum = 1, BuyMinZiJin = 116565,BuyMaxZiJin = 233130},  //风味奶酪
            new JiaYuanPurchase{ ItemID = 10036028,ItemNum = 1, BuyMinZiJin = 27360,BuyMaxZiJin = 54720},  //西红柿组合
            new JiaYuanPurchase{ ItemID = 10036029,ItemNum = 1, BuyMinZiJin = 35552,BuyMaxZiJin = 71103},  //风味南瓜粥
            new JiaYuanPurchase{ ItemID = 10036030,ItemNum = 1, BuyMinZiJin = 42408,BuyMaxZiJin = 84816},  //回味汤圆
            new JiaYuanPurchase{ ItemID = 10036031,ItemNum = 1, BuyMinZiJin = 7604,BuyMaxZiJin = 15207},  //烤鸡肉
            new JiaYuanPurchase{ ItemID = 10036032,ItemNum = 1, BuyMinZiJin = 19260,BuyMaxZiJin = 38520},  //红烧烤肉
            new JiaYuanPurchase{ ItemID = 10036033,ItemNum = 1, BuyMinZiJin = 50886,BuyMaxZiJin = 101772},  //加厚皮裙
            new JiaYuanPurchase{ ItemID = 10036034,ItemNum = 1, BuyMinZiJin = 68526,BuyMaxZiJin = 137052},  //香味奶汁
            new JiaYuanPurchase{ ItemID = 10036035,ItemNum = 1, BuyMinZiJin = 27276,BuyMaxZiJin = 54552},  //绿色果汁
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
        };

    }
}
