using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class RandomTowerConfigCategory : ProtoObject, IMerge
    {
        public static RandomTowerConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, RandomTowerConfig> dict = new Dictionary<int, RandomTowerConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<RandomTowerConfig> list = new List<RandomTowerConfig>();
		
        public RandomTowerConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            RandomTowerConfigCategory s = o as RandomTowerConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (RandomTowerConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public RandomTowerConfig Get(int id)
        {
            this.dict.TryGetValue(id, out RandomTowerConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (RandomTowerConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, RandomTowerConfig> GetAll()
        {
            return this.dict;
        }

        public RandomTowerConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class RandomTowerConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>层数</summary>
		[ProtoMember(3)]
		public int CengNum { get; set; }
		/// <summary>出现怪物</summary>
		[ProtoMember(4)]
		public string MonsterSet { get; set; }
		/// <summary>强制刷新下一波时间</summary>
		[ProtoMember(5)]
		public int NextTime { get; set; }

	}
}
