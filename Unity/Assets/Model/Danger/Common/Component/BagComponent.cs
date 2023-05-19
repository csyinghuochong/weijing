using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{
    public class BagComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        public int BagAddedCell = 0;

        public List<int> QiangHuaLevel = new List<int>();

        public List<int> QiangHuaFails = new List<int>();

        public List<int> WarehouseAddedCell = new List<int>();

#if SERVER
        public List<BagInfo> BagItemList =new List<BagInfo>();
        public List<BagInfo> BagItemPetHeXin = new List<BagInfo>();
        public List<BagInfo> EquipList = new List<BagInfo>();
        public List<BagInfo> GemList = new List<BagInfo>();
        public List<BagInfo> PetHeXinList = new List<BagInfo>();
        public List<BagInfo> Warehouse1 = new List<BagInfo>();
        public List<BagInfo> Warehouse2 = new List<BagInfo>();
        public List<BagInfo> Warehouse3 = new List<BagInfo>();
        public List<BagInfo> Warehouse4 = new List<BagInfo>();
        public List<BagInfo> JianYuanWareHouse1 = new List<BagInfo>();
        public List<BagInfo> JianYuanWareHouse2 = new List<BagInfo>();
        public List<BagInfo> JianYuanWareHouse3 = new List<BagInfo>();
        public List<BagInfo> JianYuanWareHouse4 = new List<BagInfo>();

        [BsonIgnore]
        public int FuMoItemId = 0;

        [BsonIgnore]
        public List<HideProList> FuMoProList = new List<HideProList>();

        [BsonIgnore]
        public M2C_RoleBagUpdate message = new M2C_RoleBagUpdate() {  };

        [BsonIgnore]
        public List<int> InheritSkills = new List<int>() { };
#else

        public List<BagInfo>[] AllItemList;

        /// <summary>
        /// 当前选择的仓库
        /// </summary>
        public int CurrentHouse;

        public bool RealAddItem;
#endif
    }
}