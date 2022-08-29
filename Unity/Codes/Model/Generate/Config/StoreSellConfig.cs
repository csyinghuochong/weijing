using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class StoreSellConfigCategory : ProtoObject, IMerge
    {
        public static StoreSellConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, StoreSellConfig> dict = new Dictionary<int, StoreSellConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<StoreSellConfig> list = new List<StoreSellConfig>();
		
        public StoreSellConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            StoreSellConfigCategory s = o as StoreSellConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (StoreSellConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public StoreSellConfig Get(int id)
        {
            this.dict.TryGetValue(id, out StoreSellConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (StoreSellConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, StoreSellConfig> GetAll()
        {
            return this.dict;
        }

        public StoreSellConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class StoreSellConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>下一级id</summary>
		[ProtoMember(2)]
		public int NextID { get; set; }
		/// <summary>需要玩家显示等级</summary>
		[ProtoMember(3)]
		public int ShowRoleLvMin { get; set; }
		/// <summary>需要玩家不显示等级</summary>
		[ProtoMember(4)]
		public int ShowRoleLvMax { get; set; }
		/// <summary>出售道具</summary>
		[ProtoMember(5)]
		public int SellItemID { get; set; }
		/// <summary>出售道具</summary>
		[ProtoMember(6)]
		public int SellItemNum { get; set; }
		/// <summary>出售货币种类</summary>
		[ProtoMember(7)]
		public int SellType { get; set; }
		/// <summary>出售价格</summary>
		[ProtoMember(8)]
		public int SellValue { get; set; }

	}
}
