using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ActivityConfigCategory : ProtoObject, IMerge
    {
        public static ActivityConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ActivityConfig> dict = new Dictionary<int, ActivityConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ActivityConfig> list = new List<ActivityConfig>();
		
        public ActivityConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ActivityConfigCategory s = o as ActivityConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ActivityConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ActivityConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ActivityConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ActivityConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ActivityConfig> GetAll()
        {
            return this.dict;
        }

        public ActivityConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ActivityConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>活动类型</summary>
		[ProtoMember(2)]
		public int ActivityType { get; set; }
		/// <summary>参数_1</summary>
		[ProtoMember(3)]
		public string Par_1 { get; set; }
		/// <summary>参数_2</summary>
		[ProtoMember(4)]
		public string Par_2 { get; set; }
		/// <summary>参数_3</summary>
		[ProtoMember(5)]
		public string Par_3 { get; set; }
		/// <summary>参数_4</summary>
		[ProtoMember(6)]
		public string Par_4 { get; set; }

	}
}
