using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class HuoYueRewardConfigCategory : ProtoObject, IMerge
    {
        public static HuoYueRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, HuoYueRewardConfig> dict = new Dictionary<int, HuoYueRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<HuoYueRewardConfig> list = new List<HuoYueRewardConfig>();
		
        public HuoYueRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            HuoYueRewardConfigCategory s = o as HuoYueRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (HuoYueRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public HuoYueRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out HuoYueRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (HuoYueRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, HuoYueRewardConfig> GetAll()
        {
            return this.dict;
        }

        public HuoYueRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class HuoYueRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>需要活跃点数</summary>
		[ProtoMember(2)]
		public int NeedPoint { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(3)]
		public string RewardItems { get; set; }
		/// <summary>Icon</summary>
		[ProtoMember(4)]
		public int Icon { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(5)]
		public string Desc { get; set; }

	}
}
