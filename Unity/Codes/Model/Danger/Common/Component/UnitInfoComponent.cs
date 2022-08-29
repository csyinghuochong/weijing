

using System.Collections.Generic;

namespace ET
{ 
    public class UnitInfoComponent : Entity, IAwake, ITransfer
    {

        //离线
        public bool IsDisconnect { get; set; }
        public float DisconnectTime { get; set; }

        public long UserID { get; set; }

        public string PlayerName { get; set; }

        public UnitType Type { get; set; }

        /// <summary>
        /// 根据不同的类型获取对应的ID,例如怪物类型,这里就是怪物ID
        /// </summary>
        public int UnitCondigID { get; set; }
        public int RoleCamp { get; set; }

        public int EnergySkillId { get; set; }

        public long ReviveTime;

        public List<long> ZhaohuanIds = new List<long>();

        public int PlayerLevel { get; set; }

        public string StallName { get; set; }

        public string UnionName { get; set; }

        public List<KeyValuePair> Buffs = new List<KeyValuePair>();
    }
}
