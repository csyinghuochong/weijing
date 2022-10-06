using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LingDiConfigCategory : ProtoObject, IMerge
    {
        public static LingDiConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, LingDiConfig> dict = new Dictionary<int, LingDiConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<LingDiConfig> list = new List<LingDiConfig>();
		
        public LingDiConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LingDiConfigCategory s = o as LingDiConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (LingDiConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public LingDiConfig Get(int id)
        {
            this.dict.TryGetValue(id, out LingDiConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (LingDiConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, LingDiConfig> GetAll()
        {
            return this.dict;
        }

        public LingDiConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class LingDiConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>领地名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>升级经验</summary>
		[ProtoMember(3)]
		public int UpExp { get; set; }
		/// <summary>每次消耗金币</summary>
		[ProtoMember(4)]
		public int GoldUp { get; set; }
		/// <summary>消耗增加经验</summary>
		[ProtoMember(5)]
		public int AddExp { get; set; }
		/// <summary>每小时产出经验</summary>
		[ProtoMember(6)]
		public int HoureExp { get; set; }
		/// <summary>每小时产出荣誉</summary>
		[ProtoMember(7)]
		public int HoureHonor { get; set; }

	}
}
