using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class FuntionConfigCategory : ProtoObject, IMerge
    {
        public static FuntionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, FuntionConfig> dict = new Dictionary<int, FuntionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<FuntionConfig> list = new List<FuntionConfig>();
		
        public FuntionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            FuntionConfigCategory s = o as FuntionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (FuntionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public FuntionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out FuntionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (FuntionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, FuntionConfig> GetAll()
        {
            return this.dict;
        }

        public FuntionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class FuntionConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>UI</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>开启条件类型</summary>
		[ProtoMember(3)]
		public int[] ConditionType { get; set; }
		/// <summary>开启条件参数</summary>
		[ProtoMember(4)]
		public int[] ConditionParam { get; set; }

	}
}
