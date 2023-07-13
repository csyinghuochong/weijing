using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBPaiMainInfo : Entity
    {
        public List<PaiMaiItemInfo> PaiMaiItemInfos = new List<PaiMaiItemInfo>();

        public List<PaiMaiShopItemInfo> PaiMaiShopItemInfos = new List<PaiMaiShopItemInfo>();

        //-----------拍卖行缓存----------
        /*
        //消耗品
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Consume = new List<PaiMaiItemInfo>();
        public long UpdateTimeConsume;
        //材料
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Material = new List<PaiMaiItemInfo>();
        public long UpdateTimeMaterial;
        //装备
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Equipment = new List<PaiMaiItemInfo>();
        public long UpdateTimeEquipment;
        //宝石
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Gemstone = new List<PaiMaiItemInfo>();
        public long UpdateTimeGemstone;
        */
    }
}
