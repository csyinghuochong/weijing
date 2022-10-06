using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ChengJiuConfigCategory : ProtoObject, IMerge
    {
        public static ChengJiuConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ChengJiuConfig> dict = new Dictionary<int, ChengJiuConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ChengJiuConfig> list = new List<ChengJiuConfig>();
		
        public ChengJiuConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ChengJiuConfigCategory s = o as ChengJiuConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ChengJiuConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ChengJiuConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ChengJiuConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ChengJiuConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ChengJiuConfig> GetAll()
        {
            return this.dict;
        }

        public ChengJiuConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ChengJiuConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>成就类型</summary>
		[ProtoMember(2)]
		public int ChengjiuType { get; set; }
		/// <summary>章节ID</summary>
		[ProtoMember(3)]
		public int ChapterId { get; set; }
		/// <summary>成就名称</summary>
		[ProtoMember(4)]
		public string Name { get; set; }
		/// <summary>称号图片</summary>
		[ProtoMember(5)]
		public int Icon { get; set; }
		/// <summary>奖励成就点数</summary>
		[ProtoMember(6)]
		public int RewardNum { get; set; }
		/// <summary>目标要求类型</summary>
		[ProtoMember(7)]
		public int TargetType { get; set; }
		/// <summary>目标要求值</summary>
		[ProtoMember(8)]
		public int TargetID { get; set; }
		/// <summary>目标要求值</summary>
		[ProtoMember(9)]
		public int TargetValue { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(10)]
		public string Des { get; set; }

	}
}
