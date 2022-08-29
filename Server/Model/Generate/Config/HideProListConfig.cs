using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class HideProListConfigCategory : ProtoObject, IMerge
    {
        public static HideProListConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, HideProListConfig> dict = new Dictionary<int, HideProListConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<HideProListConfig> list = new List<HideProListConfig>();
		
        public HideProListConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            HideProListConfigCategory s = o as HideProListConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (HideProListConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public HideProListConfig Get(int id)
        {
            this.dict.TryGetValue(id, out HideProListConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (HideProListConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, HideProListConfig> GetAll()
        {
            return this.dict;
        }

        public HideProListConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class HideProListConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>隐藏属性名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>下一ID</summary>
		[ProtoMember(3)]
		public int NtxtID { get; set; }
		/// <summary>洗炼属性出现部位</summary>
		[ProtoMember(4)]
		public int[] EquipSpace { get; set; }
		/// <summary>随机概率</summary>
		[ProtoMember(5)]
		public double TriggerPro { get; set; }
		/// <summary>隐藏属性类型</summary>
		[ProtoMember(6)]
		public int PropertyType { get; set; }
		/// <summary>是否根据等级成长</summary>
		[ProtoMember(7)]
		public int IfEquipLvUp { get; set; }
		/// <summary>隐藏属性类型</summary>
		[ProtoMember(8)]
		public int HideProValueType { get; set; }
		/// <summary>隐藏属性最小值</summary>
		[ProtoMember(9)]
		public string PropertyValueMin { get; set; }
		/// <summary>隐藏属性最大值</summary>
		[ProtoMember(10)]
		public string PropertyValueMax { get; set; }

	}
}
