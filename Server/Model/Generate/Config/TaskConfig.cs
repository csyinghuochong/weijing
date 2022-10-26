using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TaskConfigCategory : ProtoObject, IMerge
    {
        public static TaskConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TaskConfig> dict = new Dictionary<int, TaskConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TaskConfig> list = new List<TaskConfig>();
		
        public TaskConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TaskConfigCategory s = o as TaskConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TaskConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TaskConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TaskConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TaskConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TaskConfig> GetAll()
        {
            return this.dict;
        }

        public TaskConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TaskConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>任务名称</summary>
		[ProtoMember(2)]
		public string TaskName { get; set; }
		/// <summary>任务等级</summary>
		[ProtoMember(3)]
		public int TaskLv { get; set; }
		/// <summary>最大接取等级</summary>
		[ProtoMember(4)]
		public int TaskMaxLv { get; set; }
		/// <summary>任务类型</summary>
		[ProtoMember(5)]
		public int TaskType { get; set; }
		/// <summary>任务子类</summary>
		[ProtoMember(6)]
		public int TaskSonType { get; set; }
		/// <summary>触发类型</summary>
		[ProtoMember(7)]
		public int TriggerType { get; set; }
		/// <summary>触发值</summary>
		[ProtoMember(8)]
		public int TriggerValue { get; set; }
		/// <summary>任务经验</summary>
		[ProtoMember(9)]
		public int TaskExp { get; set; }
		/// <summary>任务金币</summary>
		[ProtoMember(10)]
		public int TaskCoin { get; set; }
		/// <summary>奖励道具ID</summary>
		[ProtoMember(11)]
		public string ItemID { get; set; }
		/// <summary>奖励道具数量</summary>
		[ProtoMember(12)]
		public string ItemNum { get; set; }
		/// <summary>接取任务的NPC</summary>
		[ProtoMember(13)]
		public int GetNpcID { get; set; }
		/// <summary>交任务的Npc</summary>
		[ProtoMember(14)]
		public int CompleteNpcID { get; set; }
		/// <summary>目标类型</summary>
		[ProtoMember(15)]
		public int TargetType { get; set; }
		/// <summary>目标ID</summary>
		[ProtoMember(16)]
		public int[] Target { get; set; }
		/// <summary>目标值</summary>
		[ProtoMember(17)]
		public int[] TargetValue { get; set; }
		/// <summary>目标点</summary>
		[ProtoMember(18)]
		public int TargetPosition { get; set; }
		/// <summary>任务描述</summary>
		[ProtoMember(19)]
		public string TaskDes { get; set; }

	}
}
