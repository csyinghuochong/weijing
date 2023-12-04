using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SeasonLevelConfigCategory : ProtoObject, IMerge
    {
        public static SeasonLevelConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SeasonLevelConfig> dict = new Dictionary<int, SeasonLevelConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SeasonLevelConfig> list = new List<SeasonLevelConfig>();
		
        public SeasonLevelConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SeasonLevelConfigCategory s = o as SeasonLevelConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SeasonLevelConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SeasonLevelConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SeasonLevelConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SeasonLevelConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SeasonLevelConfig> GetAll()
        {
            return this.dict;
        }

        public SeasonLevelConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SeasonLevelConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>升级经验</summary>
		[ProtoMember(2)]
		public int UpExp { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(3)]
		public string Reward { get; set; }
		/// <summary>赛季属性</summary>
		[ProtoMember(4)]
		public string PripertySet { get; set; }

	}
}
