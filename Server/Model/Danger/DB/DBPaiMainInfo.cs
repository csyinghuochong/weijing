using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBPaiMainInfo : Entity
    {
        public List<PaiMaiItemInfo> PaiMaiItemInfos = new List<PaiMaiItemInfo>();                       

        public List<PaiMaiItemInfo> StallItemInfos = new List<PaiMaiItemInfo>();                       //摆摊，废弃掉，PaiMaiItemInfos
        public List<PaiMaiShopItemInfo> PaiMaiShopItemInfos = new List<PaiMaiShopItemInfo>();         //商店，

    }
}
