using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JiaYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {
        public int JiaYuanLeve;
        /// <summary>
        /// 家园农场商店
        /// </summary>
        public List<MysteryItemInfo> MysteryItems = new List<MysteryItemInfo>();

        
        public List<MysteryItemInfo> 

        /// <summary>
        /// 家园种植植物
        /// </summary>
        public List<JiaYuanPlant> JianYuanPlants = new List<JiaYuanPlant>();

#if SERVER
#else
        public List<BagInfo>[] AllItemList;
        public int CellIndex = 0;
#endif
    }
}
