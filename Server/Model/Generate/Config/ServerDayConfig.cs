using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ServerDayConfigCategory : ProtoObject, IMerge
    {
        public static ServerDayConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ServerDayConfig> dict = new Dictionary<int, ServerDayConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ServerDayConfig> list = new List<ServerDayConfig>();
		
        public ServerDayConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ServerDayConfigCategory s = o as ServerDayConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ServerDayConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ServerDayConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ServerDayConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ServerDayConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ServerDayConfig> GetAll()
        {
            return this.dict;
        }

        public ServerDayConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ServerDayConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>天数</summary>
		[ProtoMember(2)]
		public int Day { get; set; }
		/// <summary>世界BOSS刷新ID</summary>
		[ProtoMember(3)]
		public string RewardItems { get; set; }

	}
}
