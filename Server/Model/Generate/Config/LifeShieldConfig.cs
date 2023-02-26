using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LifeShieldConfigCategory : ProtoObject, IMerge
    {
        public static LifeShieldConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, LifeShieldConfig> dict = new Dictionary<int, LifeShieldConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<LifeShieldConfig> list = new List<LifeShieldConfig>();
		
        public LifeShieldConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LifeShieldConfigCategory s = o as LifeShieldConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (LifeShieldConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public LifeShieldConfig Get(int id)
        {
            this.dict.TryGetValue(id, out LifeShieldConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (LifeShieldConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, LifeShieldConfig> GetAll()
        {
            return this.dict;
        }

        public LifeShieldConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class LifeShieldConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>生命之盾类型</summary>
		[ProtoMember(2)]
		public int ShieldType { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(3)]
		public string ShieldName { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(4)]
		public int ShieldLevel { get; set; }
		/// <summary>生命之盾经验</summary>
		[ProtoMember(5)]
		public int ShieldExp { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(6)]
		public string AddProperty { get; set; }

	}
}
