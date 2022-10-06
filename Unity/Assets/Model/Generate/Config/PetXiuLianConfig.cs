using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PetXiuLianConfigCategory : ProtoObject, IMerge
    {
        public static PetXiuLianConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PetXiuLianConfig> dict = new Dictionary<int, PetXiuLianConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PetXiuLianConfig> list = new List<PetXiuLianConfig>();
		
        public PetXiuLianConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PetXiuLianConfigCategory s = o as PetXiuLianConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PetXiuLianConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PetXiuLianConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PetXiuLianConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PetXiuLianConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PetXiuLianConfig> GetAll()
        {
            return this.dict;
        }

        public PetXiuLianConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PetXiuLianConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>图标显示</summary>
		[ProtoMember(3)]
		public string Icon { get; set; }
		/// <summary>下一ID</summary>
		[ProtoMember(4)]
		public int NextID { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(5)]
		public int Lv { get; set; }
		/// <summary>成功概率</summary>
		[ProtoMember(6)]
		public string SuccessPro { get; set; }
		/// <summary>增加属性</summary>
		[ProtoMember(7)]
		public string AddPro { get; set; }
		/// <summary>消耗金币</summary>
		[ProtoMember(8)]
		public int CostMoney { get; set; }
		/// <summary>消耗道具</summary>
		[ProtoMember(9)]
		public string CostItem { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(10)]
		public string Des { get; set; }
		/// <summary>描述2</summary>
		[ProtoMember(11)]
		public string Des_EN { get; set; }

	}
}
