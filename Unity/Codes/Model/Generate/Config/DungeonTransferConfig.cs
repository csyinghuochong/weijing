using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class DungeonTransferConfigCategory : ProtoObject, IMerge
    {
        public static DungeonTransferConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, DungeonTransferConfig> dict = new Dictionary<int, DungeonTransferConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<DungeonTransferConfig> list = new List<DungeonTransferConfig>();
		
        public DungeonTransferConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            DungeonTransferConfigCategory s = o as DungeonTransferConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (DungeonTransferConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public DungeonTransferConfig Get(int id)
        {
            this.dict.TryGetValue(id, out DungeonTransferConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (DungeonTransferConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, DungeonTransferConfig> GetAll()
        {
            return this.dict;
        }

        public DungeonTransferConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class DungeonTransferConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>地图ID</summary>
		[ProtoMember(3)]
		public int MapID { get; set; }
		/// <summary>进入等级</summary>
		[ProtoMember(4)]
		public int EnterLv { get; set; }
		/// <summary>位置【进入新场景出生点】</summary>
		[ProtoMember(5)]
		public int[] BornPos { get; set; }
		/// <summary>位置[传送门]</summary>
		[ProtoMember(6)]
		public int[] Position { get; set; }

	}
}
