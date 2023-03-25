using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class JiaYuanComponent : Entity, IAwake, IDestroy, ITransfer, IDeserialize, IUnitCache
    {
        public int JiaYuanLeve; 
        public List<MysteryItemInfo> MysteryItems = new List<MysteryItemInfo>();
        public List<JiaYuanPlant> JianYuanPlants = new List<JiaYuanPlant>();

        public List<BagInfo> Warehouse1 = new List<BagInfo>();
        public List<BagInfo> Warehouse2 = new List<BagInfo>();
        public List<BagInfo> Warehouse3 = new List<BagInfo>();
        public List<BagInfo> Warehouse4 = new List<BagInfo>();

#if SERVER
#else
        public List<BagInfo>[] AllItemList;
        public int CellIndex = 0;
#endif
    }
}
