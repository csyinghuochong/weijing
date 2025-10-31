using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MagickaSlotConfigCategory : ProtoObject, IMerge
    {
        public static MagickaSlotConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MagickaSlotConfig> dict = new Dictionary<int, MagickaSlotConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MagickaSlotConfig> list = new List<MagickaSlotConfig>();
		
        public MagickaSlotConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MagickaSlotConfigCategory s = o as MagickaSlotConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MagickaSlotConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MagickaSlotConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MagickaSlotConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MagickaSlotConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MagickaSlotConfig> GetAll()
        {
            return this.dict;
        }

        public MagickaSlotConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MagickaSlotConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>生命之盾类型</summary>
		[ProtoMember(2)]
		public int ShieldType { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(3)]
		public string ShieldName { get; set; }
		/// <summary>名字2</summary>
		[ProtoMember(4)]
		public string ShieldName_EN { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(5)]
		public int ShieldLevel { get; set; }
		/// <summary>生命之盾经验</summary>
		[ProtoMember(6)]
		public int ShieldExp { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(7)]
		public string AddProperty { get; set; }
		/// <summary>额外描述</summary>
		[ProtoMember(8)]
		public string Des { get; set; }
		/// <summary>额外描述2</summary>
		[ProtoMember(9)]
		public string Des_EN { get; set; }

	}
}
