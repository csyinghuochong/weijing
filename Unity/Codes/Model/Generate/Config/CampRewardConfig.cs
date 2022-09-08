using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class CampRewardConfigCategory : ProtoObject, IMerge
    {
        public static CampRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, CampRewardConfig> dict = new Dictionary<int, CampRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<CampRewardConfig> list = new List<CampRewardConfig>();
		
        public CampRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            CampRewardConfigCategory s = o as CampRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (CampRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public CampRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out CampRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (CampRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, CampRewardConfig> GetAll()
        {
            return this.dict;
        }

        public CampRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class CampRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名次</summary>
		[ProtoMember(2)]
		public int[] RankRange { get; set; }
		/// <summary>胜利奖励</summary>
		[ProtoMember(3)]
		public string Win_RewardList { get; set; }
		/// <summary>失败奖励</summary>
		[ProtoMember(4)]
		public string Fail_RewardList { get; set; }

	}
}
