using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PetFubenConfigCategory : ProtoObject, IMerge
    {
        public static PetFubenConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PetFubenConfig> dict = new Dictionary<int, PetFubenConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PetFubenConfig> list = new List<PetFubenConfig>();
		
        public PetFubenConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PetFubenConfigCategory s = o as PetFubenConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PetFubenConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PetFubenConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PetFubenConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PetFubenConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PetFubenConfig> GetAll()
        {
            return this.dict;
        }

        public PetFubenConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PetFubenConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>推荐战力</summary>
		[ProtoMember(3)]
		public int Combat { get; set; }
		/// <summary>推荐等级</summary>
		[ProtoMember(4)]
		public int Lv { get; set; }
		/// <summary>格子1</summary>
		[ProtoMember(5)]
		public string Cell_1 { get; set; }
		/// <summary>格子2</summary>
		[ProtoMember(6)]
		public string Cell_2 { get; set; }
		/// <summary>格子3</summary>
		[ProtoMember(7)]
		public string Cell_3 { get; set; }
		/// <summary>格子4</summary>
		[ProtoMember(8)]
		public string Cell_4 { get; set; }
		/// <summary>格子5</summary>
		[ProtoMember(9)]
		public string Cell_5 { get; set; }
		/// <summary>格子6</summary>
		[ProtoMember(10)]
		public string Cell_6 { get; set; }
		/// <summary>格子7</summary>
		[ProtoMember(11)]
		public string Cell_7 { get; set; }
		/// <summary>格子8</summary>
		[ProtoMember(12)]
		public string Cell_8 { get; set; }
		/// <summary>格子9</summary>
		[ProtoMember(13)]
		public string Cell_9 { get; set; }
		/// <summary>展示Icon</summary>
		[ProtoMember(14)]
		public string ShowIcon { get; set; }

	}
}
