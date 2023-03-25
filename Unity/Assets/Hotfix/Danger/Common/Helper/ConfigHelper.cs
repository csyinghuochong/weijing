using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;

namespace ET
{
   
    public static class ConfigHelper
    {

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

    }
}
