using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class OccupationTwoConfigCategory : ProtoObject, IMerge
    {
        public static OccupationTwoConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, OccupationTwoConfig> dict = new Dictionary<int, OccupationTwoConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<OccupationTwoConfig> list = new List<OccupationTwoConfig>();
		
        public OccupationTwoConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            OccupationTwoConfigCategory s = o as OccupationTwoConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (OccupationTwoConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public OccupationTwoConfig Get(int id)
        {
            this.dict.TryGetValue(id, out OccupationTwoConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (OccupationTwoConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, OccupationTwoConfig> GetAll()
        {
            return this.dict;
        }

        public OccupationTwoConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class OccupationTwoConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>职业名称</summary>
		[ProtoMember(2)]
		public string OccupationName { get; set; }
		/// <summary>职业特点描述</summary>
		[ProtoMember(3)]
		public string OccDes { get; set; }
		/// <summary>初始化技能ID</summary>
		[ProtoMember(4)]
		public int[] SkillID { get; set; }
		/// <summary>天赋1级</summary>
		[ProtoMember(5)]
		public int[] Talent { get; set; }
		/// <summary>转职显示技能</summary>
		[ProtoMember(6)]
		public int[] ShowTalentSkill { get; set; }
		/// <summary>职业能力</summary>
		[ProtoMember(7)]
		public int[] Capacitys { get; set; }
		/// <summary>武器类型</summary>
		[ProtoMember(8)]
		public int WeaponType { get; set; }
		/// <summary>护甲专精</summary>
		[ProtoMember(9)]
		public int ArmorMastery { get; set; }
		/// <summary>转职显示被动技能</summary>
		[ProtoMember(10)]
		public int[] ShowPassiveSkill { get; set; }

	}
}
