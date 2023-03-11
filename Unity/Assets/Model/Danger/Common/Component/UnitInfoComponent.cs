

using System.Collections.Generic;

namespace ET
{ 
    public class UnitInfoComponent : Entity, IAwake, ITransfer, IDestroy
    {
       
        public int EnergySkillId { get; set; }

        public List<long> ZhaohuanIds = new List<long>();

        public string UnitName { get; set; }    //自身名字

        public string MasterName { get; set; }  //主人名字

        public string StallName { get; set; }  //玩家摆摊名字

        public string UnionName { get; set; }  //帮会名字

        public List<KeyValuePair> Buffs = new List<KeyValuePair>();

        //掉落
        public List<DropInfo> Drops = new List<DropInfo>(); 
    }
}
