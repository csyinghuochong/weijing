using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JiaYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {
        public int JiaYuanLeve;
#if SERVER
         /// <summary>
        /// 家园农场商店
        /// </summary>
        public List<MysteryItemInfo> MysteryItems = new List<MysteryItemInfo>();

        /// <summary>
        /// 家园牧场商店
        /// </summary>
        public List<MysteryItemInfo> PastureItems = new List<MysteryItemInfo>();

        /// <summary>
        /// 家园植物
        /// </summary>
        public List<JiaYuanPlant> JianYuanPlants = new List<JiaYuanPlant>();

        /// <summary>
        /// 家园动物
        /// </summary>
        public List<JiaYuanPastures> JiaYuanPastures = new List<JiaYuanPastures>();

#else
        public List<BagInfo>[] AllItemList;
        public int CellIndex = 0;
#endif
    }
}
