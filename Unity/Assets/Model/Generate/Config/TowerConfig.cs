using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TowerConfigCategory : ProtoObject, IMerge
    {
        public static TowerConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TowerConfig> dict = new Dictionary<int, TowerConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TowerConfig> list = new List<TowerConfig>();
		
        public TowerConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TowerConfigCategory s = o as TowerConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TowerConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TowerConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TowerConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TowerConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TowerConfig> GetAll()
        {
            return this.dict;
        }

        public TowerConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TowerConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>地图类型</summary>
		[ProtoMember(3)]
		public int MapType { get; set; }
		/// <summary>层数</summary>
		[ProtoMember(4)]
		public int CengNum { get; set; }
		/// <summary>出现怪物</summary>
		[ProtoMember(5)]
		public string MonsterSet { get; set; }
		/// <summary>强制刷新下一波时间</summary>
		[ProtoMember(6)]
		public int NextTime { get; set; }
		/// <summary>掉落展示</summary>
		[ProtoMember(7)]
		public int DropId { get; set; }

	}
}
