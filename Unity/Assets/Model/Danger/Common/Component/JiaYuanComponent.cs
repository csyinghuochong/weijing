using System.Collections.Generic;

namespace ET
{
    public class JiaYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {

        public long RefreshMonsterTime_1 = 0;

        public long JiaYuanDaShiTime_1 = 0;

        public long JiaYuanFuJinTime_1 = 0;

        public List<int> PlanOpenList_7 = new List<int>();

        public List<int> LearnMakeIds_7 = new List<int>();

        public List<long> JiaYuanFuJins = new List<long>();

        /// <summary>
        /// 家园收购列表
        /// </summary>
        public List<JiaYuanPurchaseItem> PurchaseItemList_7 = new List<JiaYuanPurchaseItem>();

        /// <summary>
        /// 家园植物
        /// </summary>
        public List<JiaYuanPlant> JianYuanPlantList_7 = new List<JiaYuanPlant>();

        /// <summary>
        /// 家园动物
        /// </summary>
        public List<JiaYuanPastures> JiaYuanPastureList_7 = new List<JiaYuanPastures>();

        /// <summary>
        /// 家园宠物
        /// </summary>
        public List<JiaYuanPet> JiaYuanPetList_2 = new List<JiaYuanPet>();

        /// <summary>
        /// 家园大师
        /// </summary>
        public List<KeyValuePair> JiaYuanProList_7 = new List<KeyValuePair>();

#if SERVER
        /// <summary>
        /// 家园农场商店
        /// </summary>
        public List<MysteryItemInfo> PlantGoods_7 = new List<MysteryItemInfo>();

        /// <summary>
        /// 家园牧场商店
        /// </summary>
        public List<MysteryItemInfo> PastureGoods_7 = new List<MysteryItemInfo>();

        /// <summary>
        /// 家园随机怪
        /// </summary>
        //keyValuePair.KeyId    怪物id
        //keyValuePair.Value    怪物出生时间戳
        //keyValuePair.Value2   怪物坐标
        public List<JiaYuanMonster> JiaYuanMonster_2 = new List<JiaYuanMonster>();
#else
        public long MasterId = 0;
#endif
    }
}
