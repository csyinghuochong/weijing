using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class RankRewardConfigCategory : ProtoObject, IMerge
    {
        public static RankRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, RankRewardConfig> dict = new Dictionary<int, RankRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<RankRewardConfig> list = new List<RankRewardConfig>();
		
        public RankRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            RankRewardConfigCategory s = o as RankRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (RankRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public RankRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out RankRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (RankRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, RankRewardConfig> GetAll()
        {
            return this.dict;
        }

        public RankRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class RankRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>排名类型</summary>
		[ProtoMember(2)]
		public int Type { get; set; }
		/// <summary>排行名次</summary>
		[ProtoMember(3)]
		public int[] NeedPoint { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(4)]
		public string RewardItems { get; set; }

	}
}
