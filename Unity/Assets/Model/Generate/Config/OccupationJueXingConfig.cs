using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class OccupationJueXingConfigCategory : ProtoObject, IMerge
    {
        public static OccupationJueXingConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, OccupationJueXingConfig> dict = new Dictionary<int, OccupationJueXingConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<OccupationJueXingConfig> list = new List<OccupationJueXingConfig>();
		
        public OccupationJueXingConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            OccupationJueXingConfigCategory s = o as OccupationJueXingConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (OccupationJueXingConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public OccupationJueXingConfig Get(int id)
        {
            this.dict.TryGetValue(id, out OccupationJueXingConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (OccupationJueXingConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, OccupationJueXingConfig> GetAll()
        {
            return this.dict;
        }

        public OccupationJueXingConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class OccupationJueXingConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>觉醒经验</summary>
		[ProtoMember(2)]
		public int costExp { get; set; }
		/// <summary>觉醒金币</summary>
		[ProtoMember(3)]
		public int costGold { get; set; }
		/// <summary>前置技能</summary>
		[ProtoMember(4)]
		public int[] Pre_Condition { get; set; }
		/// <summary>消耗道具</summary>
		[ProtoMember(5)]
		public string OccupationName { get; set; }

	}
}
