using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SkillWeaponConfigCategory : ProtoObject, IMerge
    {
        public static SkillWeaponConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SkillWeaponConfig> dict = new Dictionary<int, SkillWeaponConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SkillWeaponConfig> list = new List<SkillWeaponConfig>();
		
        public SkillWeaponConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SkillWeaponConfigCategory s = o as SkillWeaponConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SkillWeaponConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SkillWeaponConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SkillWeaponConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SkillWeaponConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SkillWeaponConfig> GetAll()
        {
            return this.dict;
        }

        public SkillWeaponConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SkillWeaponConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>技能名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>默认技能ID</summary>
		[ProtoMember(3)]
		public int InitSkillID { get; set; }
		/// <summary>剑武器技能</summary>
		[ProtoMember(4)]
		public int InitSkillID_1 { get; set; }
		/// <summary>刀武器技能</summary>
		[ProtoMember(5)]
		public int InitSkillID_2 { get; set; }
		/// <summary>法杖</summary>
		[ProtoMember(6)]
		public int InitSkillID_3 { get; set; }
		/// <summary>魔法书</summary>
		[ProtoMember(7)]
		public int InitSkillID_4 { get; set; }

	}
}
