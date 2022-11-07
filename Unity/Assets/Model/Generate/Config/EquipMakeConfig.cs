using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EquipMakeConfigCategory : ProtoObject, IMerge
    {
        public static EquipMakeConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EquipMakeConfig> dict = new Dictionary<int, EquipMakeConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EquipMakeConfig> list = new List<EquipMakeConfig>();
		
        public EquipMakeConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EquipMakeConfigCategory s = o as EquipMakeConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EquipMakeConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EquipMakeConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EquipMakeConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EquipMakeConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EquipMakeConfig> GetAll()
        {
            return this.dict;
        }

        public EquipMakeConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EquipMakeConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>制造类型</summary>
		[ProtoMember(2)]
		public int ProficiencyType { get; set; }
		/// <summary>制造装备</summary>
		[ProtoMember(3)]
		public int MakeItemID { get; set; }
		/// <summary>学习类型</summary>
		[ProtoMember(4)]
		public int LearnType { get; set; }
		/// <summary>学习等级</summary>
		[ProtoMember(5)]
		public int LearnLv { get; set; }
		/// <summary>学习消耗金币</summary>
		[ProtoMember(6)]
		public int LearnGoldValue { get; set; }
		/// <summary>消耗活力值</summary>
		[ProtoMember(7)]
		public int CostVitality { get; set; }
		/// <summary>学习需要道具</summary>
		[ProtoMember(8)]
		public string LearnNeedItems { get; set; }
		/// <summary>制造装备数量</summary>
		[ProtoMember(9)]
		public int MakeEquipNum { get; set; }
		/// <summary>制作成功概率</summary>
		[ProtoMember(10)]
		public double MakeSuccesPro { get; set; }
		/// <summary>领悟概率</summary>
		[ProtoMember(11)]
		public double LearnPro { get; set; }
		/// <summary>触发隐藏属性概率</summary>
		[ProtoMember(12)]
		public string MakeHintPro { get; set; }
		/// <summary>制造装备等级</summary>
		[ProtoMember(13)]
		public int MakeLv { get; set; }
		/// <summary>制造装备最大等级</summary>
		[ProtoMember(14)]
		public int MakeLvMax { get; set; }
		/// <summary>制造星级</summary>
		[ProtoMember(15)]
		public int MakeStar { get; set; }
		/// <summary>需要熟练度</summary>
		[ProtoMember(16)]
		public int NeedProficiencyValue { get; set; }
		/// <summary>增长熟练度上限</summary>
		[ProtoMember(17)]
		public int ProficiencyMax { get; set; }
		/// <summary>增长熟练点数</summary>
		[ProtoMember(18)]
		public int[] ProficiencyValue { get; set; }
		/// <summary>熟练度转换概率生效值</summary>
		[ProtoMember(19)]
		public double ProficiencyStartProValue { get; set; }
		/// <summary>熟练点数转换概率</summary>
		[ProtoMember(20)]
		public double ProficiencyProValue { get; set; }
		/// <summary>制造冷却时间</summary>
		[ProtoMember(21)]
		public int MakeTime { get; set; }
		/// <summary>制造消耗金币</summary>
		[ProtoMember(22)]
		public int MakeNeedGold { get; set; }
		/// <summary>需要道具</summary>
		[ProtoMember(23)]
		public string NeedItems { get; set; }

	}
}
