using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MonsterGroupConfigCategory : ProtoObject, IMerge
    {
        public static MonsterGroupConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MonsterGroupConfig> dict = new Dictionary<int, MonsterGroupConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MonsterGroupConfig> list = new List<MonsterGroupConfig>();
		
        public MonsterGroupConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MonsterGroupConfigCategory s = o as MonsterGroupConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MonsterGroupConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MonsterGroupConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MonsterGroupConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MonsterGroupConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MonsterGroupConfig> GetAll()
        {
            return this.dict;
        }

        public MonsterGroupConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MonsterGroupConfig: ProtoObject, IConfig
	{
		/// <summary>id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>野怪</summary>
		[ProtoMember(2)]
		public string CreateMonster { get; set; }

	}
}
