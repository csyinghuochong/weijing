using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;

namespace ET
{

    public static class ConfigHelper
    {

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
            new WorldSayConfig(){ Time = 2015, Conent = "拍卖特惠已经开启,有需要的玩家可以购买哦!"  },
            new WorldSayConfig(){ Time = 2030, Conent = "战场活动已经开启,可以通过右上角的战场按钮快速加入哦!"  },
            new WorldSayConfig(){ Time = 2100, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2110, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2120, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },

            //年兽
            new WorldSayConfig(){ Time = 2114, Conent = "新年活动:新年的年兽-夕还有1分钟即将来到宝藏之地,主城的勇士们,带上你们的装备快去迎接挑战吧！"  },
            new WorldSayConfig(){ Time = 2115, Conent = "新年的年兽-夕：我已经等了整整一年,弱者不配与我进行战斗,想要挑战我的就带上你们的装备过来吧,我已经到来到宝藏之地的中心！" },
            new WorldSayConfig(){ Time = 2000, Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2100, Conent = "新年活动:捣乱的年兽出现在宝藏之地,想要去的玩家带上鞭炮赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2200, Conent = "家族入侵:家族出现了入侵怪兽,想要奖励的小勇士请带上你们的武器速速前往!"  },
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

    }
}
