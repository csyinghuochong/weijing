using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MonsterConfigCategory : ProtoObject, IMerge
    {
        public static MonsterConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MonsterConfig> dict = new Dictionary<int, MonsterConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MonsterConfig> list = new List<MonsterConfig>();
		
        public MonsterConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            MonsterConfigCategory s = o as MonsterConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (MonsterConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MonsterConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MonsterConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MonsterConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MonsterConfig> GetAll()
        {
            return this.dict;
        }

        public MonsterConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MonsterConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>怪物名称</summary>
		[ProtoMember(2)]
		public string MonsterName { get; set; }
		/// <summary>怪物类型</summary>
		[ProtoMember(3)]
		public int MonsterType { get; set; }
		/// <summary>怪物子类</summary>
		[ProtoMember(4)]
		public int MonsterSonType { get; set; }
		/// <summary>阵营</summary>
		[ProtoMember(5)]
		public int MonsterCamp { get; set; }
		/// <summary>怪物种族</summary>
		[ProtoMember(6)]
		public int MonsterRace { get; set; }
		/// <summary>怪物头像</summary>
		[ProtoMember(7)]
		public string MonsterHeadIcon { get; set; }
		/// <summary>怪物模型ID</summary>
		[ProtoMember(8)]
		public int MonsterModelID { get; set; }
		/// <summary>触发精灵概率</summary>
		[ProtoMember(9)]
		public double SpiritPro { get; set; }
		/// <summary>触发精灵ID</summary>
		[ProtoMember(10)]
		public int SpiritID { get; set; }
		/// <summary>怪物等级</summary>
		[ProtoMember(11)]
		public int Lv { get; set; }
		/// <summary>移动速度</summary>
		[ProtoMember(12)]
		public double MoveSpeed { get; set; }
		/// <summary>攻击距离</summary>
		[ProtoMember(13)]
		public double ActDistance { get; set; }
		/// <summary>攻击速度</summary>
		[ProtoMember(14)]
		public int ActSpeed { get; set; }
		/// <summary>巡逻速度</summary>
		[ProtoMember(15)]
		public int WalkSpeed { get; set; }
		/// <summary>怪物生命</summary>
		[ProtoMember(16)]
		public int Hp { get; set; }
		/// <summary>攻击</summary>
		[ProtoMember(17)]
		public int Act { get; set; }
		/// <summary>魔法攻击</summary>
		[ProtoMember(18)]
		public int MageAct { get; set; }
		/// <summary>物理防御</summary>
		[ProtoMember(19)]
		public int Def { get; set; }
		/// <summary>魔法防御</summary>
		[ProtoMember(20)]
		public int Adf { get; set; }
		/// <summary>暴击概率</summary>
		[ProtoMember(21)]
		public double Cri { get; set; }
		/// <summary>抗暴概率</summary>
		[ProtoMember(22)]
		public double Res { get; set; }
		/// <summary>附加命中概率</summary>
		[ProtoMember(23)]
		public double Hit { get; set; }
		/// <summary>附加闪避概率</summary>
		[ProtoMember(24)]
		public double Dodge { get; set; }
		/// <summary>怪物物理免伤</summary>
		[ProtoMember(25)]
		public double DefAdd { get; set; }
		/// <summary>怪物魔法免伤</summary>
		[ProtoMember(26)]
		public double AdfAdd { get; set; }
		/// <summary>怪物免伤</summary>
		[ProtoMember(27)]
		public double DamgeAdd { get; set; }
		/// <summary>怪物复活时间</summary>
		[ProtoMember(28)]
		public double ReviveTime { get; set; }
		/// <summary>巡逻范围</summary>
		[ProtoMember(29)]
		public double PatrolRange { get; set; }
		/// <summary>追击范围</summary>
		[ProtoMember(30)]
		public double ChaseRange { get; set; }
		/// <summary>攻击范围</summary>
		[ProtoMember(31)]
		public double ActRange { get; set; }
		/// <summary>攻击间隔时间</summary>
		[ProtoMember(32)]
		public int ActInterValTime { get; set; }
		/// <summary>怪物经验</summary>
		[ProtoMember(33)]
		public int Exp { get; set; }
		/// <summary>是否显示大血条</summary>
		[ProtoMember(34)]
		public int IfBoss { get; set; }
		/// <summary>选中条大小</summary>
		[ProtoMember(35)]
		public double SelectSize { get; set; }
		/// <summary>掉落类型</summary>
		[ProtoMember(36)]
		public int DropType { get; set; }
		/// <summary>掉落ID</summary>
		[ProtoMember(37)]
		public int[] DropID { get; set; }
		/// <summary>分级掉落</summary>
		[ProtoMember(38)]
		public string LvDropID { get; set; }
		/// <summary>极品掉落概率</summary>
		[ProtoMember(39)]
		public double HideDropPro { get; set; }
		/// <summary>怪物出现概率</summary>
		[ProtoMember(40)]
		public double MonsterShowPro { get; set; }
		/// <summary>普通攻击ID</summary>
		[ProtoMember(41)]
		public int ActSkillID { get; set; }
		/// <summary>技能ID</summary>
		[ProtoMember(42)]
		public int[] SkillID { get; set; }
		/// <summary>怪物参数</summary>
		[ProtoMember(43)]
		public int[] Parameter { get; set; }
		/// <summary>AI</summary>
		[ProtoMember(44)]
		public int AI { get; set; }
		/// <summary>AI相关参数</summary>
		[ProtoMember(45)]
		public string AIParameter { get; set; }
		/// <summary>怪物出生自动死亡时间</summary>
		[ProtoMember(46)]
		public int DeathTime { get; set; }

	}
}
