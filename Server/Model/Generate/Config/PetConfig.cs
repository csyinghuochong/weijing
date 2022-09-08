using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PetConfigCategory : ProtoObject, IMerge
    {
        public static PetConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PetConfig> dict = new Dictionary<int, PetConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PetConfig> list = new List<PetConfig>();
		
        public PetConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PetConfigCategory s = o as PetConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PetConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PetConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PetConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PetConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PetConfig> GetAll()
        {
            return this.dict;
        }

        public PetConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PetConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>宠物名称</summary>
		[ProtoMember(2)]
		public string PetName { get; set; }
		/// <summary>头像Icon</summary>
		[ProtoMember(3)]
		public string HeadIcon { get; set; }
		/// <summary>宠物Model</summary>
		[ProtoMember(4)]
		public int PetModel { get; set; }
		/// <summary>洗炼变异</summary>
		[ProtoMember(5)]
		public int PetBianYiID { get; set; }
		/// <summary>宠物显示的位置</summary>
		[ProtoMember(6)]
		public string ModelShowPosi { get; set; }
		/// <summary>宠物类型</summary>
		[ProtoMember(7)]
		public int PetType { get; set; }
		/// <summary>宠物等级</summary>
		[ProtoMember(8)]
		public int PetLv { get; set; }
		/// <summary>宠物品质</summary>
		[ProtoMember(9)]
		public int PetQuality { get; set; }
		/// <summary>出战等级</summary>
		[ProtoMember(10)]
		public int FightLv { get; set; }
		/// <summary>默认星数</summary>
		[ProtoMember(11)]
		public int[] InitStartNum { get; set; }
		/// <summary>基础评分</summary>
		[ProtoMember(12)]
		public string Base_PingFen { get; set; }
		/// <summary>宠物种族</summary>
		[ProtoMember(13)]
		public int PetRace { get; set; }
		/// <summary>血量资质</summary>
		[ProtoMember(14)]
		public int ZiZhi_Hp_Min { get; set; }
		/// <summary>血量资质</summary>
		[ProtoMember(15)]
		public int ZiZhi_Hp_Max { get; set; }
		/// <summary>攻击资质</summary>
		[ProtoMember(16)]
		public int ZiZhi_Act_Min { get; set; }
		/// <summary>攻击资质</summary>
		[ProtoMember(17)]
		public int ZiZhi_Act_Max { get; set; }
		/// <summary>攻击资质</summary>
		[ProtoMember(18)]
		public int ZiZhi_MageAct_Min { get; set; }
		/// <summary>攻击资质</summary>
		[ProtoMember(19)]
		public int ZiZhi_MageAct_Max { get; set; }
		/// <summary>物防资质</summary>
		[ProtoMember(20)]
		public int ZiZhi_Def_Min { get; set; }
		/// <summary>物防资质</summary>
		[ProtoMember(21)]
		public int ZiZhi_Def_Max { get; set; }
		/// <summary>法防资质</summary>
		[ProtoMember(22)]
		public int ZiZhi_Adf_Min { get; set; }
		/// <summary>法防资质</summary>
		[ProtoMember(23)]
		public int ZiZhi_Adf_Max { get; set; }
		/// <summary>攻速资质</summary>
		[ProtoMember(24)]
		public int ZiZhi_ActSpeed_Min { get; set; }
		/// <summary>攻速资质</summary>
		[ProtoMember(25)]
		public int ZiZhi_ActSpeed_Max { get; set; }
		/// <summary>成长资质</summary>
		[ProtoMember(26)]
		public double ZiZhi_ChengZhang_Min { get; set; }
		/// <summary>成长资质</summary>
		[ProtoMember(27)]
		public double ZiZhi_ChengZhang_Max { get; set; }
		/// <summary>血量</summary>
		[ProtoMember(28)]
		public int Base_Hp { get; set; }
		/// <summary>攻击</summary>
		[ProtoMember(29)]
		public int Base_Act { get; set; }
		/// <summary>魔法攻击</summary>
		[ProtoMember(30)]
		public int Base_MageAct { get; set; }
		/// <summary>物防</summary>
		[ProtoMember(31)]
		public int Base_Def { get; set; }
		/// <summary>魔防</summary>
		[ProtoMember(32)]
		public int Base_Adf { get; set; }
		/// <summary>暴击</summary>
		[ProtoMember(33)]
		public double Base_Cri { get; set; }
		/// <summary>抗暴</summary>
		[ProtoMember(34)]
		public int Base_Res { get; set; }
		/// <summary>命中</summary>
		[ProtoMember(35)]
		public double Base_Hit { get; set; }
		/// <summary>闪避</summary>
		[ProtoMember(36)]
		public double Base_Dodge { get; set; }
		/// <summary>物理免伤</summary>
		[ProtoMember(37)]
		public int Base_DefAdd { get; set; }
		/// <summary>魔法免伤</summary>
		[ProtoMember(38)]
		public int Base_AdfAdd { get; set; }
		/// <summary>怪物免伤</summary>
		[ProtoMember(39)]
		public int Base_DamgeAdd { get; set; }
		/// <summary>移动速度</summary>
		[ProtoMember(40)]
		public int Base_MoveSpeed { get; set; }
		/// <summary>攻击速度</summary>
		[ProtoMember(41)]
		public int Base_ActSpeed { get; set; }
		/// <summary>攻击距离</summary>
		[ProtoMember(42)]
		public double ActDistance { get; set; }
		/// <summary>等级成长血量</summary>
		[ProtoMember(43)]
		public double Lv_Hp { get; set; }
		/// <summary>等级成长攻击</summary>
		[ProtoMember(44)]
		public double Lv_Act { get; set; }
		/// <summary>等级成长魔法攻击</summary>
		[ProtoMember(45)]
		public double Lv_MageAct { get; set; }
		/// <summary>等级成长物防</summary>
		[ProtoMember(46)]
		public double Lv_Def { get; set; }
		/// <summary>等级成长魔防</summary>
		[ProtoMember(47)]
		public double Lv_Adf { get; set; }
		/// <summary>监视范围</summary>
		[ProtoMember(48)]
		public int PatrolRange { get; set; }
		/// <summary>追击范围</summary>
		[ProtoMember(49)]
		public int ChaseRange { get; set; }
		/// <summary>攻击范围</summary>
		[ProtoMember(50)]
		public int ActRunRange { get; set; }
		/// <summary>抓捕狂暴概率</summary>
		[ProtoMember(51)]
		public double Exp { get; set; }
		/// <summary>选中条大小</summary>
		[ProtoMember(52)]
		public int SelectSize { get; set; }
		/// <summary>放生奖励</summary>
		[ProtoMember(53)]
		public int[] ReleaseReward { get; set; }
		/// <summary>专注技能</summary>
		[ProtoMember(54)]
		public string ZhuanZhuSkillID { get; set; }
		/// <summary>怪物普通攻击</summary>
		[ProtoMember(55)]
		public int ActSkillID { get; set; }
		/// <summary>宠物必带技能ID</summary>
		[ProtoMember(56)]
		public string BaseSkillID { get; set; }
		/// <summary>宠物随机技能ID</summary>
		[ProtoMember(57)]
		public string RandomSkillID { get; set; }
		/// <summary>宠物皮肤</summary>
		[ProtoMember(58)]
		public int[] Skin { get; set; }
		/// <summary>宠物皮肤激活概率</summary>
		[ProtoMember(59)]
		public int[] SkinPro { get; set; }

	}
}
