using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SpiritConfigCategory : ProtoObject, IMerge
    {
        public static SpiritConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SpiritConfig> dict = new Dictionary<int, SpiritConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SpiritConfig> list = new List<SpiritConfig>();
		
        public SpiritConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SpiritConfigCategory s = o as SpiritConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SpiritConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SpiritConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SpiritConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SpiritConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SpiritConfig> GetAll()
        {
            return this.dict;
        }

        public SpiritConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SpiritConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>章节ID</summary>
		[ProtoMember(2)]
		public int ChapterID { get; set; }
		/// <summary>精灵Icon</summary>
		[ProtoMember(3)]
		public string Icon { get; set; }
		/// <summary>精灵类型</summary>
		[ProtoMember(4)]
		public string Type { get; set; }
		/// <summary>精灵名称</summary>
		[ProtoMember(5)]
		public string Name { get; set; }
		/// <summary>精灵名称</summary>
		[ProtoMember(6)]
		public string Name_EN { get; set; }
		/// <summary>精灵模型</summary>
		[ProtoMember(7)]
		public string ModelID { get; set; }
		/// <summary>精灵属性</summary>
		[ProtoMember(8)]
		public string Proprety { get; set; }
		/// <summary>被动触发技能</summary>
		[ProtoMember(9)]
		public string TriggerSkill { get; set; }
		/// <summary>主动触发技能</summary>
		[ProtoMember(10)]
		public string MainSkill { get; set; }
		/// <summary>掉落怪物</summary>
		[ProtoMember(11)]
		public string MonsterID { get; set; }
		/// <summary>精灵描述</summary>
		[ProtoMember(12)]
		public string Des { get; set; }
		/// <summary>精灵描述</summary>
		[ProtoMember(13)]
		public string Des_EN { get; set; }

	}
}
