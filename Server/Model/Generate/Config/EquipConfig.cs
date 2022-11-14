using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EquipConfigCategory : ProtoObject, IMerge
    {
        public static EquipConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EquipConfig> dict = new Dictionary<int, EquipConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EquipConfig> list = new List<EquipConfig>();
		
        public EquipConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EquipConfigCategory s = o as EquipConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EquipConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EquipConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EquipConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EquipConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EquipConfig> GetAll()
        {
            return this.dict;
        }

        public EquipConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EquipConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>鉴定道具消耗</summary>
		[ProtoMember(2)]
		public int AppraisalItem { get; set; }
		/// <summary>套装ID</summary>
		[ProtoMember(3)]
		public int EquipSuitID { get; set; }
		/// <summary>隐藏属性类型</summary>
		[ProtoMember(4)]
		public int HideType { get; set; }
		/// <summary>隐藏属性最大值</summary>
		[ProtoMember(5)]
		public int HideMax { get; set; }
		/// <summary>单条隐藏属性出现概率</summary>
		[ProtoMember(6)]
		public double HideShowPro { get; set; }
		/// <summary>一级属性随机值</summary>
		[ProtoMember(7)]
		public int OneProRandomValue { get; set; }
		/// <summary>初始宝石孔位</summary>
		[ProtoMember(8)]
		public int GemHole { get; set; }
		/// <summary>血量</summary>
		[ProtoMember(9)]
		public int Equip_Hp { get; set; }
		/// <summary>最低攻击</summary>
		[ProtoMember(10)]
		public int Equip_MinAct { get; set; }
		/// <summary>最高攻击</summary>
		[ProtoMember(11)]
		public int Equip_MaxAct { get; set; }
		/// <summary>最低攻击</summary>
		[ProtoMember(12)]
		public int Equip_MinMagAct { get; set; }
		/// <summary>最高攻击</summary>
		[ProtoMember(13)]
		public int Equip_MaxMagAct { get; set; }
		/// <summary>最低防御</summary>
		[ProtoMember(14)]
		public int Equip_MinDef { get; set; }
		/// <summary>最高防御</summary>
		[ProtoMember(15)]
		public int Equip_MaxDef { get; set; }
		/// <summary>最低防御</summary>
		[ProtoMember(16)]
		public int Equip_MinAdf { get; set; }
		/// <summary>最高防御</summary>
		[ProtoMember(17)]
		public int Equip_MaxAdf { get; set; }
		/// <summary>暴击</summary>
		[ProtoMember(18)]
		public double Equip_Cri { get; set; }
		/// <summary>命中</summary>
		[ProtoMember(19)]
		public double Equip_Hit { get; set; }
		/// <summary>闪避</summary>
		[ProtoMember(20)]
		public double Equip_Dodge { get; set; }
		/// <summary>伤害加成</summary>
		[ProtoMember(21)]
		public double Equip_DamgeAdd { get; set; }
		/// <summary>伤害减免</summary>
		[ProtoMember(22)]
		public double Equip_DamgeSub { get; set; }
		/// <summary>速度</summary>
		[ProtoMember(23)]
		public double Equip_Speed { get; set; }
		/// <summary>幸运值</summary>
		[ProtoMember(24)]
		public int Equip_Lucky { get; set; }
		/// <summary>附加属性类型</summary>
		[ProtoMember(25)]
		public int[] AddPropreListType { get; set; }
		/// <summary>附加属性值</summary>
		[ProtoMember(26)]
		public long[] AddPropreListValue { get; set; }
		/// <summary>是否显示属性</summary>
		[ProtoMember(27)]
		public long[] AddPropreListIfShow { get; set; }
		/// <summary>附加</summary>
		[ProtoMember(28)]
		public int TianFuId { get; set; }

	}
}
