using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EffectConfigCategory : ProtoObject, IMerge
    {
        public static EffectConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EffectConfig> dict = new Dictionary<int, EffectConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EffectConfig> list = new List<EffectConfig>();
		
        public EffectConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EffectConfigCategory s = o as EffectConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EffectConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EffectConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EffectConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EffectConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EffectConfig> GetAll()
        {
            return this.dict;
        }

        public EffectConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EffectConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>特效类型</summary>
		[ProtoMember(2)]
		public int EffectType { get; set; }
		/// <summary>特效是否跟随绑定</summary>
		[ProtoMember(3)]
		public int IfFollowCollider { get; set; }
		/// <summary>特效名称</summary>
		[ProtoMember(4)]
		public string EffectName { get; set; }
		/// <summary>技能效果延迟时间</summary>
		[ProtoMember(5)]
		public double SkillEffectDelayTime { get; set; }
		/// <summary>绑定父级</summary>
		[ProtoMember(6)]
		public int SkillParent { get; set; }
		/// <summary>绑定父级位置</summary>
		[ProtoMember(7)]
		public string SkillParentPosition { get; set; }
		/// <summary>隐藏间隔时间</summary>
		[ProtoMember(8)]
		public int HideTime { get; set; }
		/// <summary>技能特效存在时间[毫秒]</summary>
		[ProtoMember(9)]
		public int SkillEffectLiveTime { get; set; }

	}
}
