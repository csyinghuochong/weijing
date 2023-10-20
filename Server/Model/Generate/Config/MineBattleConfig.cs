using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MineBattleConfigCategory : ProtoObject, IMerge
    {
        public static MineBattleConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MineBattleConfig> dict = new Dictionary<int, MineBattleConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MineBattleConfig> list = new List<MineBattleConfig>();
		
        public MineBattleConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MineBattleConfigCategory s = o as MineBattleConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MineBattleConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MineBattleConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MineBattleConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MineBattleConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MineBattleConfig> GetAll()
        {
            return this.dict;
        }

        public MineBattleConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MineBattleConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>地图类型(未用)</summary>
		[ProtoMember(3)]
		public int Type { get; set; }
		/// <summary>图标</summary>
		[ProtoMember(4)]
		public string Icon { get; set; }
		/// <summary>金币产出/小时</summary>
		[ProtoMember(5)]
		public int GoldOutPut { get; set; }

	}
}
