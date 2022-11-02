using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MonsterPositionConfigCategory : ProtoObject, IMerge
    {
        public static MonsterPositionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MonsterPositionConfig> dict = new Dictionary<int, MonsterPositionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MonsterPositionConfig> list = new List<MonsterPositionConfig>();
		
        public MonsterPositionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MonsterPositionConfigCategory s = o as MonsterPositionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MonsterPositionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MonsterPositionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MonsterPositionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MonsterPositionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MonsterPositionConfig> GetAll()
        {
            return this.dict;
        }

        public MonsterPositionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MonsterPositionConfig: ProtoObject, IConfig
	{
		/// <summary>id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>下一个刷新ID</summary>
		[ProtoMember(2)]
		public int NextID { get; set; }
		/// <summary>类型</summary>
		[ProtoMember(3)]
		public int Type { get; set; }
		/// <summary>坐标点</summary>
		[ProtoMember(4)]
		public string Position { get; set; }
		/// <summary>怪物ID</summary>
		[ProtoMember(5)]
		public int MonsterID { get; set; }
		/// <summary>刷怪范围</summary>
		[ProtoMember(6)]
		public double CreateRange { get; set; }
		/// <summary>刷怪数量</summary>
		[ProtoMember(7)]
		public int CreateNum { get; set; }
		/// <summary>刷新朝向</summary>
		[ProtoMember(8)]
		public int Create { get; set; }
		/// <summary>其他参数</summary>
		[ProtoMember(9)]
		public string Par { get; set; }

	}
}
