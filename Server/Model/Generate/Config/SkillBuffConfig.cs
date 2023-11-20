using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SkillBuffConfigCategory : ProtoObject, IMerge
    {
        public static SkillBuffConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SkillBuffConfig> dict = new Dictionary<int, SkillBuffConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SkillBuffConfig> list = new List<SkillBuffConfig>();
		
        public SkillBuffConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SkillBuffConfigCategory s = o as SkillBuffConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SkillBuffConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SkillBuffConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SkillBuffConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SkillBuffConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SkillBuffConfig> GetAll()
        {
            return this.dict;
        }

        public SkillBuffConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SkillBuffConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>状态名称</summary>
		[ProtoMember(2)]
		public string BuffName { get; set; }
		/// <summary>广播目标类型</summary>
		[ProtoMember(3)]
		public int BroadcastType { get; set; }
		/// <summary>Buff等级</summary>
		[ProtoMember(4)]
		public int BuffLv { get; set; }
		/// <summary>切换场景保留</summary>
		[ProtoMember(5)]
		public int Transfer { get; set; }
		/// <summary>Buff图标</summary>
		[ProtoMember(7)]
		public string BuffIcon { get; set; }
		/// <summary>Buff存在时间</summary>
		[ProtoMember(8)]
		public int BuffTime { get; set; }
		/// <summary>Buff延迟生效时间</summary>
		[ProtoMember(9)]
		public int BuffDelayTime { get; set; }
		/// <summary>循环触发时间</summary>
		[ProtoMember(10)]
		public int BuffLoopTime { get; set; }
		/// <summary>Buff目标类型</summary>
		[ProtoMember(11)]
		public int TargetType { get; set; }
		/// <summary>Buff脚本</summary>
		[ProtoMember(12)]
		public string BuffScript { get; set; }
		/// <summary>Buff类型</summary>
		[ProtoMember(13)]
		public int BuffType { get; set; }
		/// <summary>Buff增益减益</summary>
		[ProtoMember(14)]
		public int BuffBenefitType { get; set; }
		/// <summary>Buff参数操作类型</summary>
		[ProtoMember(15)]
		public int buffParameterType { get; set; }
		/// <summary>Buff参数操作值</summary>
		[ProtoMember(16)]
		public double buffParameterValue { get; set; }
		/// <summary>Buff参数操作值2</summary>
		[ProtoMember(17)]
		public string buffParameterValue2 { get; set; }
		/// <summary>buff操作参数值类型</summary>
		[ProtoMember(18)]
		public int buffParameterValueType { get; set; }
		/// <summary>buff操作参数值类型定义</summary>
		[ProtoMember(19)]
		public int buffParameterValueDef { get; set; }
		/// <summary>Buff是否叠加</summary>
		[ProtoMember(20)]
		public int BuffAddClass { get; set; }
		/// <summary>Buff是叠加层数上限</summary>
		[ProtoMember(21)]
		public int BuffAddClassMax { get; set; }
		/// <summary>唯一buffID</summary>
		[ProtoMember(22)]
		public string WeiYiBuffID { get; set; }
		/// <summary>伤害类型</summary>
		[ProtoMember(23)]
		public int DamgeType { get; set; }
		/// <summary>伤害系数</summary>
		[ProtoMember(24)]
		public double DamgePro { get; set; }
		/// <summary>固定伤害值</summary>
		[ProtoMember(25)]
		public int DamgeValue { get; set; }
		/// <summary>是否立即释放</summary>
		[ProtoMember(26)]
		public int IfImmediatelyUse { get; set; }
		/// <summary>是否在主界面显示BuffIcon</summary>
		[ProtoMember(27)]
		public int IfShowIconTips { get; set; }
		/// <summary>buff特效</summary>
		[ProtoMember(28)]
		public int BuffEffectID { get; set; }
		/// <summary>Buff描述</summary>
		[ProtoMember(29)]
		public string BuffDescribe { get; set; }
		/// <summary>附加目标类型</summary>
		[ProtoMember(30)]
		public int[] BuffTargetType { get; set; }
		/// <summary>移除机制</summary>
		[ProtoMember(31)]
		public int Remove { get; set; }
		/// <summary>移动触发</summary>
		[ProtoMember(32)]
		public int MoveAction { get; set; }

	}
}
