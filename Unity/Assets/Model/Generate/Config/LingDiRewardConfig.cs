using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LingDiRewardConfigCategory : ProtoObject, IMerge
    {
        public static LingDiRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, LingDiRewardConfig> dict = new Dictionary<int, LingDiRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<LingDiRewardConfig> list = new List<LingDiRewardConfig>();
		
        public LingDiRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LingDiRewardConfigCategory s = o as LingDiRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (LingDiRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public LingDiRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out LingDiRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (LingDiRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, LingDiRewardConfig> GetAll()
        {
            return this.dict;
        }

        public LingDiRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class LingDiRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>下一个兑换ID</summary>
		[ProtoMember(2)]
		public int NextID { get; set; }
		/// <summary>兑换道具名称</summary>
		[ProtoMember(3)]
		public int ItemID { get; set; }
		/// <summary>兑换道具ID</summary>
		[ProtoMember(4)]
		public int BuyItemID { get; set; }
		/// <summary>兑换道具价格</summary>
		[ProtoMember(5)]
		public int BuyPrice { get; set; }
		/// <summary>角色等级限制</summary>
		[ProtoMember(6)]
		public int RoseLvlimit { get; set; }
		/// <summary>国家等级限制</summary>
		[ProtoMember(7)]
		public int CountryLvlimit { get; set; }

	}
}
