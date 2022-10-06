using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TakeCardRewardConfigCategory : ProtoObject, IMerge
    {
        public static TakeCardRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TakeCardRewardConfig> dict = new Dictionary<int, TakeCardRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TakeCardRewardConfig> list = new List<TakeCardRewardConfig>();
		
        public TakeCardRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TakeCardRewardConfigCategory s = o as TakeCardRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TakeCardRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TakeCardRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TakeCardRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TakeCardRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TakeCardRewardConfig> GetAll()
        {
            return this.dict;
        }

        public TakeCardRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TakeCardRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>抽卡次数</summary>
		[ProtoMember(2)]
		public int RoseLvLimit { get; set; }
		/// <summary>奖励道具</summary>
		[ProtoMember(3)]
		public string RewardItems { get; set; }
		/// <summary>奖励钻石</summary>
		[ProtoMember(4)]
		public int[] RewardDiamond { get; set; }

	}
}
