using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EquipSuitConfigCategory : ProtoObject, IMerge
    {
        public static EquipSuitConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EquipSuitConfig> dict = new Dictionary<int, EquipSuitConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EquipSuitConfig> list = new List<EquipSuitConfig>();
		
        public EquipSuitConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EquipSuitConfigCategory s = o as EquipSuitConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EquipSuitConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EquipSuitConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EquipSuitConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EquipSuitConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EquipSuitConfig> GetAll()
        {
            return this.dict;
        }

        public EquipSuitConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EquipSuitConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>套装名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>需要装备ID</summary>
		[ProtoMember(3)]
		public string NeedEquipID { get; set; }
		/// <summary>套装属性</summary>
		[ProtoMember(4)]
		public string SuitPropertyID { get; set; }

	}
}
