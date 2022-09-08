using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ChengJiuRewardConfigCategory : ProtoObject, IMerge
    {
        public static ChengJiuRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ChengJiuRewardConfig> dict = new Dictionary<int, ChengJiuRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ChengJiuRewardConfig> list = new List<ChengJiuRewardConfig>();
		
        public ChengJiuRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ChengJiuRewardConfigCategory s = o as ChengJiuRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ChengJiuRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ChengJiuRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ChengJiuRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ChengJiuRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ChengJiuRewardConfig> GetAll()
        {
            return this.dict;
        }

        public ChengJiuRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ChengJiuRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>需要成就点</summary>
		[ProtoMember(2)]
		public int NeedPoint { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(3)]
		public string RewardItems { get; set; }
		/// <summary>成就Icon</summary>
		[ProtoMember(4)]
		public int Icon { get; set; }
		/// <summary>成就描述</summary>
		[ProtoMember(5)]
		public string Desc { get; set; }

	}
}
