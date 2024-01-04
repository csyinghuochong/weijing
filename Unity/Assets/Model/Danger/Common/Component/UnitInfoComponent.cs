
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

#if SERVER
        public class UnitInfoComponent : Entity, IAwake, ITransfer, IDestroy
#else
        public class UnitInfoComponent : Entity, IAwake, IDestroy
#endif
    {
       
        public int EnergySkillId { get; set; }

        public List<long> ZhaohuanIds = new List<long>();

        public string UnitName { get; set; }    //自身名字

        public string MasterName { get; set; }  //主人名字

        public string UnionName { get; set; }  //帮会名字

        public string DemonName { get; set; }

        public List<KeyValuePair> Buffs = new List<KeyValuePair>();

        //掉落
        public List<DropInfo> Drops = new List<DropInfo>();

        public List<int> FashionEquipList = new List<int>();


        public int LastDungeonId = 0;
        public Vector3 LastDungeonPosition;
    }
}
