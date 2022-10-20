

using System.Collections.Generic;

namespace ET
{ 
    public class UnitInfoComponent : Entity, IAwake, ITransfer, IDestroy
    {
        public string PlayerName { get; set; }

        public int EnergySkillId { get; set; }

        public List<long> ZhaohuanIds = new List<long>();

        public string StallName { get; set; }

        public string UnionName { get; set; }

        public List<KeyValuePair> Buffs = new List<KeyValuePair>();
    }
}
