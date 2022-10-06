using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MulLanguageConfigCategory : ProtoObject, IMerge
    {
        public static MulLanguageConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MulLanguageConfig> dict = new Dictionary<int, MulLanguageConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MulLanguageConfig> list = new List<MulLanguageConfig>();
		
        public MulLanguageConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MulLanguageConfigCategory s = o as MulLanguageConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MulLanguageConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MulLanguageConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MulLanguageConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MulLanguageConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MulLanguageConfig> GetAll()
        {
            return this.dict;
        }

        public MulLanguageConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MulLanguageConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Chinese { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(3)]
		public string English { get; set; }

	}
}
