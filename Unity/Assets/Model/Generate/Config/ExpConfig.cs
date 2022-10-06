using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ExpConfigCategory : ProtoObject, IMerge
    {
        public static ExpConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ExpConfig> dict = new Dictionary<int, ExpConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ExpConfig> list = new List<ExpConfig>();
		
        public ExpConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ExpConfigCategory s = o as ExpConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ExpConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ExpConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ExpConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ExpConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ExpConfig> GetAll()
        {
            return this.dict;
        }

        public ExpConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ExpConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>角色升级经验</summary>
		[ProtoMember(2)]
		public int UpExp { get; set; }
		/// <summary>宠物升级经验</summary>
		[ProtoMember(3)]
		public int PetUpExp { get; set; }
		/// <summary>宠物经验道具</summary>
		[ProtoMember(4)]
		public int PetItemUpExp { get; set; }
		/// <summary>每级对应经验产出</summary>
		[ProtoMember(5)]
		public int RoseExpPro { get; set; }
		/// <summary>每级对应金币产出</summary>
		[ProtoMember(6)]
		public int RoseGoldPro { get; set; }
		/// <summary>基础怪物血量</summary>
		[ProtoMember(7)]
		public int BaseHp { get; set; }
		/// <summary>攻击</summary>
		[ProtoMember(8)]
		public int BaseAct { get; set; }
		/// <summary>物防</summary>
		[ProtoMember(9)]
		public int BaseDef { get; set; }
		/// <summary>魔防</summary>
		[ProtoMember(10)]
		public int BaseAdf { get; set; }

	}
}
