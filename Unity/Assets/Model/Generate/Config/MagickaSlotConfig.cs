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
		/// <summary>魔能类型</summary>
		[ProtoMember(2)]
		public int MagicType { get; set; }
		/// <summary>位置</summary>
		[ProtoMember(3)]
		public int Position { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(4)]
		public string MagicName { get; set; }
		/// <summary>名字2</summary>
		[ProtoMember(5)]
		public string MagicName_EN { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(6)]
		public int MagicLevel { get; set; }
		/// <summary>开启消耗道具</summary>
		[ProtoMember(7)]
		public string OpenCostItem { get; set; }
		/// <summary>开启需要总等级</summary>
		[ProtoMember(8)]
		public int NeedTotalLevel { get; set; }
		/// <summary>升级需要经验</summary>
		[ProtoMember(9)]
		public int NeedExp { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(10)]
		public string AddProperty { get; set; }
		/// <summary>额外描述</summary>
		[ProtoMember(11)]
		public string Des { get; set; }
		/// <summary>额外描述2</summary>
		[ProtoMember(12)]
		public string Des_EN { get; set; }

	}
}
