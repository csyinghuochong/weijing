using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class WorldSayConfigCategory : ProtoObject, IMerge
    {
        public static WorldSayConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, WorldSayConfig> dict = new Dictionary<int, WorldSayConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<WorldSayConfig> list = new List<WorldSayConfig>();
		
        public WorldSayConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            WorldSayConfigCategory s = o as WorldSayConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (WorldSayConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public WorldSayConfig Get(int id)
        {
            this.dict.TryGetValue(id, out WorldSayConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (WorldSayConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, WorldSayConfig> GetAll()
        {
            return this.dict;
        }

        public WorldSayConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class WorldSayConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>时间</summary>
		[ProtoMember(2)]
		public int Day { get; set; }
		/// <summary>世界广播</summary>
		[ProtoMember(3)]
		public string SayDes { get; set; }

	}
}
