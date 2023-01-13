using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;

namespace ET
{
   
    public static class ConfigHelper
    {

        //游戏公告
        public static List<WorldSayConfig> WorldSayList = new List<ET.WorldSayConfig>
        {
            new WorldSayConfig(){ Time = 1930, Conent = "一波红包雨已经来临,赶紧来看看自己是否是那个幸运玩家!"  },
            new WorldSayConfig(){ Time = 2000, Conent = "世界领主已经出现在密境中,赶紧过来看看吧!"  },
            new WorldSayConfig(){ Time = 2030, Conent = "战场活动已经开启,可以通过右上角的战场按钮快速加入哦!"  },
            new WorldSayConfig(){ Time = 2100, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2110, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
            new WorldSayConfig(){ Time = 2120, Conent = "一大波宝箱出现在宝藏之地,想要去的玩家赶紧前往哦!"  },
        };

        public static Dictionary<int, CollectionWord> CollectionWordList = new Dictionary<int, ET.CollectionWord>
        {
            { 1, new CollectionWord(){ Words = "洗迎新年", Reward = "3;500@10010041;5@10010042;5@10010083;5@10010088;2"  } },
            { 2, new CollectionWord(){ Words = "兔年大吉", Reward = "3;500@10010041;5@10010042;5@10010083;5@10010088;2"  } },
        };

    }
}
