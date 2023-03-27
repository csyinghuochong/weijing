using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JiaYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {
#if SERVER
         /// <summary>
        /// 家园农场商店
        /// </summary>
        public List<MysteryItemInfo> PlantGoods = new List<MysteryItemInfo>();

        /// <summary>
        /// 家园牧场商店
        /// </summary>
        public List<MysteryItemInfo> PastureGoods = new List<MysteryItemInfo>();

        /// <summary>
        /// 家园植物
        /// </summary>
        public List<JiaYuanPlant> JianYuanPlantList = new List<JiaYuanPlant>();

        /// <summary>
        /// 家园动物
        /// </summary>
        public List<JiaYuanPastures> JiaYuanPastureList = new List<JiaYuanPastures>();
#endif
    }
}
