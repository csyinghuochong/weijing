using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class RandomTowerRewardConfigCategory : ProtoObject, IMerge
    {
        public static RandomTowerRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, RandomTowerRewardConfig> dict = new Dictionary<int, RandomTowerRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<RandomTowerRewardConfig> list = new List<RandomTowerRewardConfig>();
		
        public RandomTowerRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            RandomTowerRewardConfigCategory s = o as RandomTowerRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (RandomTowerRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public RandomTowerRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out RandomTowerRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (RandomTowerRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, RandomTowerRewardConfig> GetAll()
        {
            return this.dict;
        }

        public RandomTowerRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class RandomTowerRewardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>层数</summary>
		[ProtoMember(3)]
		public int[] CengNum { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(4)]
		public string RewardList { get; set; }

	}
}
