using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class GuideConfigCategory : ProtoObject, IMerge
    {
        public static GuideConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, GuideConfig> dict = new Dictionary<int, GuideConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<GuideConfig> list = new List<GuideConfig>();
		
        public GuideConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            GuideConfigCategory s = o as GuideConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (GuideConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public GuideConfig Get(int id)
        {
            this.dict.TryGetValue(id, out GuideConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (GuideConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, GuideConfig> GetAll()
        {
            return this.dict;
        }

        public GuideConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class GuideConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>组</summary>
		[ProtoMember(2)]
		public int GroupId { get; set; }
		/// <summary>下一步</summary>
		[ProtoMember(3)]
		public int NextID { get; set; }
		/// <summary>是否保存</summary>
		[ProtoMember(4)]
		public int Save { get; set; }
		/// <summary>触发条件</summary>
		[ProtoMember(5)]
		public int TrigerType { get; set; }
		/// <summary>触发目标</summary>
		[ProtoMember(6)]
		public string TrigerParams { get; set; }
		/// <summary>行为类型</summary>
		[ProtoMember(7)]
		public int ActionType { get; set; }
		/// <summary>行为对象</summary>
		[ProtoMember(8)]
		public string ActionTarget { get; set; }
		/// <summary>行为参数</summary>
		[ProtoMember(9)]
		public string ActionParams { get; set; }
		/// <summary>是否强引导</summary>
		[ProtoMember(10)]
		public int Force { get; set; }
		/// <summary>引导文本</summary>
		[ProtoMember(11)]
		public string Text { get; set; }
		/// <summary>文本位置[相对于按钮]</summary>
		[ProtoMember(12)]
		public int TextPosition { get; set; }

	}
}
