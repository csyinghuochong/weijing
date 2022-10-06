using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EquipSuitPropertyConfigCategory : ProtoObject, IMerge
    {
        public static EquipSuitPropertyConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EquipSuitPropertyConfig> dict = new Dictionary<int, EquipSuitPropertyConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EquipSuitPropertyConfig> list = new List<EquipSuitPropertyConfig>();
		
        public EquipSuitPropertyConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EquipSuitPropertyConfigCategory s = o as EquipSuitPropertyConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EquipSuitPropertyConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EquipSuitPropertyConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EquipSuitPropertyConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EquipSuitPropertyConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EquipSuitPropertyConfig> GetAll()
        {
            return this.dict;
        }

        public EquipSuitPropertyConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EquipSuitPropertyConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>套装名称</summary>
		[ProtoMember(2)]
		public string EquipSuitName { get; set; }
		/// <summary>套装名称2</summary>
		[ProtoMember(3)]
		public string EquipSuitDes { get; set; }
		/// <summary>是否显示套装件数</summary>
		[ProtoMember(4)]
		public int ifShowSuitNum { get; set; }
		/// <summary>血量</summary>
		[ProtoMember(5)]
		public int Equip_Hp { get; set; }
		/// <summary>最低攻击</summary>
		[ProtoMember(6)]
		public int Equip_MinAct { get; set; }
		/// <summary>最高攻击</summary>
		[ProtoMember(7)]
		public int Equip_MaxAct { get; set; }
		/// <summary>最低攻击3</summary>
		[ProtoMember(8)]
		public int Equip_MinMagAct { get; set; }
		/// <summary>最高攻击4</summary>
		[ProtoMember(9)]
		public int Equip_MaxMagAct { get; set; }
		/// <summary>最低防御</summary>
		[ProtoMember(10)]
		public int Equip_MinDef { get; set; }
		/// <summary>最高防御</summary>
		[ProtoMember(11)]
		public int Equip_MaxDef { get; set; }
		/// <summary>最低防御5</summary>
		[ProtoMember(12)]
		public int Equip_MinAdf { get; set; }
		/// <summary>最高防御6</summary>
		[ProtoMember(13)]
		public int Equip_MaxAdf { get; set; }
		/// <summary>暴击</summary>
		[ProtoMember(14)]
		public double Equip_Cri { get; set; }
		/// <summary>命中</summary>
		[ProtoMember(15)]
		public double Equip_Hit { get; set; }
		/// <summary>闪避</summary>
		[ProtoMember(16)]
		public double Equip_Dodge { get; set; }
		/// <summary>伤害加成</summary>
		[ProtoMember(17)]
		public double Equip_DamgeAdd { get; set; }
		/// <summary>伤害减免</summary>
		[ProtoMember(18)]
		public double Equip_DamgeSub { get; set; }
		/// <summary>速度</summary>
		[ProtoMember(19)]
		public double Equip_Speed { get; set; }
		/// <summary>幸运值</summary>
		[ProtoMember(20)]
		public int Equip_Lucky { get; set; }
		/// <summary>套装附加技能</summary>
		[ProtoMember(21)]
		public int EquipSuitSkillID { get; set; }
		/// <summary>附加</summary>
		[ProtoMember(22)]
		public string AddPropreListStr { get; set; }

	}
}
