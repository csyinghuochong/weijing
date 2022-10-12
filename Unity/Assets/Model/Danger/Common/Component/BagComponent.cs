using System.Collections.Generic;

namespace ET
{
    public class BagComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        public List<int> QiangHuaLevel = new List<int>();

        public List<int> QiangHuaFails = new List<int>();
        
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
#else

        public List<BagInfo>[] AllItemList;

        /// <summary>
        /// 当前选择的仓库
        /// </summary>
        public int CurrentHouse;

        public BagInfo HuiShouSelect;
#endif
    }
}