using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class GlobalValueConfigCategory : ProtoObject, IMerge
    {
        public static GlobalValueConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, GlobalValueConfig> dict = new Dictionary<int, GlobalValueConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<GlobalValueConfig> list = new List<GlobalValueConfig>();
		
        public GlobalValueConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            GlobalValueConfigCategory s = o as GlobalValueConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (GlobalValueConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public GlobalValueConfig Get(int id)
        {
            this.dict.TryGetValue(id, out GlobalValueConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (GlobalValueConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, GlobalValueConfig> GetAll()
        {
            return this.dict;
        }

        public GlobalValueConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class GlobalValueConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>值</summary>
		[ProtoMember(2)]
		public string Value { get; set; }
		/// <summary>值2</summary>
		[ProtoMember(3)]
		public int Value2 { get; set; }

	}
}
