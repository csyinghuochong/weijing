using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TaskCountryConfigCategory : ProtoObject, IMerge
    {
        public static TaskCountryConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TaskCountryConfig> dict = new Dictionary<int, TaskCountryConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TaskCountryConfig> list = new List<TaskCountryConfig>();
		
        public TaskCountryConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TaskCountryConfigCategory s = o as TaskCountryConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TaskCountryConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TaskCountryConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TaskCountryConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TaskCountryConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TaskCountryConfig> GetAll()
        {
            return this.dict;
        }

        public TaskCountryConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TaskCountryConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>任务名称</summary>
		[ProtoMember(2)]
		public string TaskName { get; set; }
		/// <summary>任务类型</summary>
		[ProtoMember(3)]
		public int TaskType { get; set; }
		/// <summary>图标</summary>
		[ProtoMember(4)]
		public int TaskIcon { get; set; }
		/// <summary>任务等级</summary>
		[ProtoMember(5)]
		public int TaskLv { get; set; }
		/// <summary>下个任务</summary>
		[ProtoMember(6)]
		public int NextTask { get; set; }
		/// <summary>触发概率</summary>
		[ProtoMember(7)]
		public double TriggerPro { get; set; }
		/// <summary>触发类型</summary>
		[ProtoMember(8)]
		public int TriggerType { get; set; }
		/// <summary>触发值</summary>
		[ProtoMember(9)]
		public int TriggerValue { get; set; }
		/// <summary>活跃度奖励</summary>
		[ProtoMember(10)]
		public int EveryTaskRewardNum { get; set; }
		/// <summary>奖励金币</summary>
		[ProtoMember(11)]
		public int RewardGold { get; set; }
		/// <summary>奖励道具</summary>
		[ProtoMember(12)]
		public string RewardItem { get; set; }
		/// <summary>目标类型</summary>
		[ProtoMember(13)]
		public int TargetType { get; set; }
		/// <summary>目标ID</summary>
		[ProtoMember(14)]
		public int Target { get; set; }
		/// <summary>目标值1</summary>
		[ProtoMember(15)]
		public int TargetValue { get; set; }
		/// <summary>任务描述</summary>
		[ProtoMember(16)]
		public string TaskDes { get; set; }

	}
}
