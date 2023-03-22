using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MysteryConfigCategory : ProtoObject, IMerge
    {
        public static MysteryConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MysteryConfig> dict = new Dictionary<int, MysteryConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MysteryConfig> list = new List<MysteryConfig>();
		
        public MysteryConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MysteryConfigCategory s = o as MysteryConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MysteryConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MysteryConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MysteryConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MysteryConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MysteryConfig> GetAll()
        {
            return this.dict;
        }

        public MysteryConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MysteryConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>NextId</summary>
		[ProtoMember(2)]
		public int NextId { get; set; }
		/// <summary>随机数量</summary>
		[ProtoMember(3)]
		public int[] NumberLimit { get; set; }
		/// <summary>出售道具</summary>
		[ProtoMember(4)]
		public int SellItemID { get; set; }
		/// <summary>出售货币种类</summary>
		[ProtoMember(5)]
		public int SellType { get; set; }
		/// <summary>出售价格</summary>
		[ProtoMember(6)]
		public int SellValue { get; set; }
		/// <summary>出现权重</summary>
		[ProtoMember(7)]
		public int ShowPro { get; set; }
		/// <summary>出现服务器时间(天)</summary>
		[ProtoMember(8)]
		public int ShowServerDay { get; set; }
		/// <summary>限购数量</summary>
		[ProtoMember(9)]
		public int BuyNumMax { get; set; }
		/// <summary>家园等级</summary>
		[ProtoMember(10)]
		public int JiaYuanLv { get; set; }

	}
}
