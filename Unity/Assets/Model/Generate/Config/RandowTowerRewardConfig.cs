using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class RandowTowerRewardConfigCategory : ProtoObject, IMerge
    {
        public static RandowTowerRewardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, RandowTowerRewardConfig> dict = new Dictionary<int, RandowTowerRewardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<RandowTowerRewardConfig> list = new List<RandowTowerRewardConfig>();
		
        public RandowTowerRewardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            RandowTowerRewardConfigCategory s = o as RandowTowerRewardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (RandowTowerRewardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public RandowTowerRewardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out RandowTowerRewardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (RandowTowerRewardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, RandowTowerRewardConfig> GetAll()
        {
            return this.dict;
        }

        public RandowTowerRewardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class RandowTowerRewardConfig: ProtoObject, IConfig
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
