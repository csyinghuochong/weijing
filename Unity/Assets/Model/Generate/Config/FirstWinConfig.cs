using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class FirstWinConfigCategory : ProtoObject, IMerge
    {
        public static FirstWinConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, FirstWinConfig> dict = new Dictionary<int, FirstWinConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<FirstWinConfig> list = new List<FirstWinConfig>();
		
        public FirstWinConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            FirstWinConfigCategory s = o as FirstWinConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (FirstWinConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public FirstWinConfig Get(int id)
        {
            this.dict.TryGetValue(id, out FirstWinConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (FirstWinConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, FirstWinConfig> GetAll()
        {
            return this.dict;
        }

        public FirstWinConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class FirstWinConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>ChatperId</summary>
		[ProtoMember(2)]
		public int ChatperId { get; set; }
		/// <summary>BossID</summary>
		[ProtoMember(3)]
		public int BossID { get; set; }
		/// <summary>普通奖励</summary>
		[ProtoMember(4)]
		public string RewardList_1 { get; set; }
		/// <summary>挑战奖励</summary>
		[ProtoMember(5)]
		public string RewardList_2 { get; set; }
		/// <summary>地狱奖励</summary>
		[ProtoMember(6)]
		public string RewardList_3 { get; set; }
		/// <summary>个人普通奖励</summary>
		[ProtoMember(7)]
		public string Self_RewardList_1 { get; set; }
		/// <summary>个人挑战奖励</summary>
		[ProtoMember(8)]
		public string Self_RewardList_2 { get; set; }
		/// <summary>个人地狱奖励</summary>
		[ProtoMember(9)]
		public string Self_RewardList_3 { get; set; }

	}
}
