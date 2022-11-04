using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class RobotConfigCategory : ProtoObject, IMerge
    {
        public static RobotConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, RobotConfig> dict = new Dictionary<int, RobotConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<RobotConfig> list = new List<RobotConfig>();
		
        public RobotConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            RobotConfigCategory s = o as RobotConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (RobotConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public RobotConfig Get(int id)
        {
            this.dict.TryGetValue(id, out RobotConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (RobotConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, RobotConfig> GetAll()
        {
            return this.dict;
        }

        public RobotConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class RobotConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(2)]
		public int Level { get; set; }
		/// <summary>行为</summary>
		[ProtoMember(3)]
		public int Behaviour { get; set; }
		/// <summary>第一职业</summary>
		[ProtoMember(4)]
		public int Occ { get; set; }
		/// <summary>第二职业</summary>
		[ProtoMember(5)]
		public int OccTwo { get; set; }
		/// <summary>装备</summary>
		[ProtoMember(6)]
		public int[] EquipList { get; set; }
		/// <summary>属性点</summary>
		[ProtoMember(7)]
		public int[] PointList { get; set; }
		/// <summary>参数</summary>
		[ProtoMember(8)]
		public string AIParameter { get; set; }

	}
}
