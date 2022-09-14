using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EquipXiLianConfigCategory : ProtoObject, IMerge
    {
        public static EquipXiLianConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EquipXiLianConfig> dict = new Dictionary<int, EquipXiLianConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EquipXiLianConfig> list = new List<EquipXiLianConfig>();
		
        public EquipXiLianConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EquipXiLianConfigCategory s = o as EquipXiLianConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EquipXiLianConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EquipXiLianConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EquipXiLianConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EquipXiLianConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EquipXiLianConfig> GetAll()
        {
            return this.dict;
        }

        public EquipXiLianConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EquipXiLianConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>洗练类型</summary>
		[ProtoMember(2)]
		public int XiLianType { get; set; }
		/// <summary>洗练等级</summary>
		[ProtoMember(3)]
		public int XiLianLevel { get; set; }
		/// <summary>需要熟练度</summary>
		[ProtoMember(4)]
		public int NeedShuLianDu { get; set; }
		/// <summary>称号</summary>
		[ProtoMember(5)]
		public string Title { get; set; }
		/// <summary>属性类型</summary>
		[ProtoMember(6)]
		public int[] ProList_Type { get; set; }
		/// <summary>属性值</summary>
		[ProtoMember(7)]
		public int[] ProList_Value { get; set; }
		/// <summary>达成奖励</summary>
		[ProtoMember(8)]
		public string RewardList { get; set; }

	}
}
