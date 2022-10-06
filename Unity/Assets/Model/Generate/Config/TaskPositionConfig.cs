using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TaskPositionConfigCategory : ProtoObject, IMerge
    {
        public static TaskPositionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TaskPositionConfig> dict = new Dictionary<int, TaskPositionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TaskPositionConfig> list = new List<TaskPositionConfig>();
		
        public TaskPositionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TaskPositionConfigCategory s = o as TaskPositionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TaskPositionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TaskPositionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TaskPositionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TaskPositionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TaskPositionConfig> GetAll()
        {
            return this.dict;
        }

        public TaskPositionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TaskPositionConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>传送点名称</summary>
		[ProtoMember(2)]
		public string MapName { get; set; }
		/// <summary>传送地图</summary>
		[ProtoMember(3)]
		public int MapID { get; set; }
		/// <summary>传送坐标点</summary>
		[ProtoMember(4)]
		public string PositionName { get; set; }
		/// <summary>其余地图</summary>
		[ProtoMember(5)]
		public string OtherMapMove { get; set; }

	}
}
