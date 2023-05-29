using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PaiMaiSellConfigCategory : ProtoObject, IMerge
    {
        public static PaiMaiSellConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PaiMaiSellConfig> dict = new Dictionary<int, PaiMaiSellConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PaiMaiSellConfig> list = new List<PaiMaiSellConfig>();
		
        public PaiMaiSellConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PaiMaiSellConfigCategory s = o as PaiMaiSellConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PaiMaiSellConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PaiMaiSellConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PaiMaiSellConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PaiMaiSellConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PaiMaiSellConfig> GetAll()
        {
            return this.dict;
        }

        public PaiMaiSellConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PaiMaiSellConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>拍卖类型</summary>
		[ProtoMember(2)]
		public int PaiMaiType { get; set; }
		/// <summary>章节ID</summary>
		[ProtoMember(3)]
		public int ChapterId { get; set; }
		/// <summary>购买等级</summary>
		[ProtoMember(4)]
		public int BuyLv { get; set; }
		/// <summary>道具ID</summary>
		[ProtoMember(5)]
		public int ItemID { get; set; }
		/// <summary>价格</summary>
		[ProtoMember(6)]
		public int[] Price { get; set; }
		/// <summary>价格上限</summary>
		[ProtoMember(7)]
		public int PriceMax { get; set; }
		/// <summary>价格下限</summary>
		[ProtoMember(8)]
		public int PriceMin { get; set; }

	}
}
