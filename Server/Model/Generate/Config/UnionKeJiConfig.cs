using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class UnionKeJiConfigCategory : ProtoObject, IMerge
    {
        public static UnionKeJiConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, UnionKeJiConfig> dict = new Dictionary<int, UnionKeJiConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<UnionKeJiConfig> list = new List<UnionKeJiConfig>();
		
        public UnionKeJiConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            UnionKeJiConfigCategory s = o as UnionKeJiConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (UnionKeJiConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public UnionKeJiConfig Get(int id)
        {
            this.dict.TryGetValue(id, out UnionKeJiConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (UnionKeJiConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, UnionKeJiConfig> GetAll()
        {
            return this.dict;
        }

        public UnionKeJiConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class UnionKeJiConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>装备名称</summary>
		[ProtoMember(2)]
		public string EquipSpaceName { get; set; }
		/// <summary>下一级强化</summary>
		[ProtoMember(3)]
		public int NextID { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(4)]
		public int QiangHuaLv { get; set; }
		/// <summary>需要家族等级</summary>
		[ProtoMember(5)]
		public int NeedUnionLv { get; set; }
		/// <summary>升级需要时间（单位:s）</summary>
		[ProtoMember(6)]
		public int NeedTime { get; set; }
		/// <summary>升级消耗家族金币</summary>
		[ProtoMember(7)]
		public int CostUnionGold { get; set; }
		/// <summary>强化属性</summary>
		[ProtoMember(8)]
		public string EquipPropreAdd { get; set; }

	}
}
