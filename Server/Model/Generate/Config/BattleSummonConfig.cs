using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class BattleSummonConfigCategory : ProtoObject, IMerge
    {
        public static BattleSummonConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, BattleSummonConfig> dict = new Dictionary<int, BattleSummonConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<BattleSummonConfig> list = new List<BattleSummonConfig>();
		
        public BattleSummonConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            BattleSummonConfigCategory s = o as BattleSummonConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (BattleSummonConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public BattleSummonConfig Get(int id)
        {
            this.dict.TryGetValue(id, out BattleSummonConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (BattleSummonConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, BattleSummonConfig> GetAll()
        {
            return this.dict;
        }

        public BattleSummonConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class BattleSummonConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>士兵名字</summary>
		[ProtoMember(2)]
		public string ItemName { get; set; }
		/// <summary>士兵Id</summary>
		[ProtoMember(3)]
		public int[] MonsterIds { get; set; }
		/// <summary>士兵人口数量</summary>
		[ProtoMember(4)]
		public int MonsterNumber { get; set; }
		/// <summary>消耗金币</summary>
		[ProtoMember(5)]
		public int CostGold { get; set; }
		/// <summary>免费重置时间(s)</summary>
		[ProtoMember(6)]
		public int FreeResetTime { get; set; }

	}
}
