using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PetFubenRewardConfigCategory : ProtoObject, IMerge
    {
        public static PetFubenRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PetFubenRewardConfig> dict = new Dictionary<int, PetFubenRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PetFubenRewardConfig> list = new List<PetFubenRewardConfig>();
		
        public PetFubenRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PetFubenRewardConfigCategory s = o as PetFubenRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PetFubenRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PetFubenRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PetFubenRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PetFubenRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PetFubenRewardConfig> GetAll()
        {
            return this.dict;
        }

        public PetFubenRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PetFubenRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>需要副本星数</summary>
		[ProtoMember(2)]
		public int NeedStar { get; set; }
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
