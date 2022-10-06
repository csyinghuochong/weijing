using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class CampLieShouConfigCategory : ProtoObject, IMerge
    {
        public static CampLieShouConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, CampLieShouConfig> dict = new Dictionary<int, CampLieShouConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<CampLieShouConfig> list = new List<CampLieShouConfig>();
		
        public CampLieShouConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            CampLieShouConfigCategory s = o as CampLieShouConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (CampLieShouConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public CampLieShouConfig Get(int id)
        {
            this.dict.TryGetValue(id, out CampLieShouConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (CampLieShouConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, CampLieShouConfig> GetAll()
        {
            return this.dict;
        }

        public CampLieShouConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class CampLieShouConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>任务名称</summary>
		[ProtoMember(2)]
		public string TaskName { get; set; }
		/// <summary>目标类型</summary>
		[ProtoMember(3)]
		public int TargetType { get; set; }
		/// <summary>目标ID</summary>
		[ProtoMember(4)]
		public int[] Target { get; set; }
		/// <summary>目标值</summary>
		[ProtoMember(5)]
		public int[] TargetValue { get; set; }

	}
}
