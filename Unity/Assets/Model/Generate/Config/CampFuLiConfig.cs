using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class CampFuLiConfigCategory : ProtoObject, IMerge
    {
        public static CampFuLiConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, CampFuLiConfig> dict = new Dictionary<int, CampFuLiConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<CampFuLiConfig> list = new List<CampFuLiConfig>();
		
        public CampFuLiConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            CampFuLiConfigCategory s = o as CampFuLiConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (CampFuLiConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public CampFuLiConfig Get(int id)
        {
            this.dict.TryGetValue(id, out CampFuLiConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (CampFuLiConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, CampFuLiConfig> GetAll()
        {
            return this.dict;
        }

        public CampFuLiConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class CampFuLiConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>职位</summary>
		[ProtoMember(2)]
		public string Postion { get; set; }
		/// <summary>胜利阵营币</summary>
		[ProtoMember(3)]
		public int Win_Reward { get; set; }
		/// <summary>失败阵营币</summary>
		[ProtoMember(4)]
		public int Fail_Reward { get; set; }

	}
}
