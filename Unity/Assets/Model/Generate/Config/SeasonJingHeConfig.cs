using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SeasonJingHeConfigCategory : ProtoObject, IMerge
    {
        public static SeasonJingHeConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SeasonJingHeConfig> dict = new Dictionary<int, SeasonJingHeConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SeasonJingHeConfig> list = new List<SeasonJingHeConfig>();
		
        public SeasonJingHeConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SeasonJingHeConfigCategory s = o as SeasonJingHeConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SeasonJingHeConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SeasonJingHeConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SeasonJingHeConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SeasonJingHeConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SeasonJingHeConfig> GetAll()
        {
            return this.dict;
        }

        public SeasonJingHeConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SeasonJingHeConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>开启消耗</summary>
		[ProtoMember(2)]
		public string Cost { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(3)]
		public string AddProperty { get; set; }

	}
}
