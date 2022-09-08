using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class EquipQiangHuaConfigCategory : ProtoObject, IMerge
    {
        public static EquipQiangHuaConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, EquipQiangHuaConfig> dict = new Dictionary<int, EquipQiangHuaConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<EquipQiangHuaConfig> list = new List<EquipQiangHuaConfig>();
		
        public EquipQiangHuaConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            EquipQiangHuaConfigCategory s = o as EquipQiangHuaConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (EquipQiangHuaConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public EquipQiangHuaConfig Get(int id)
        {
            this.dict.TryGetValue(id, out EquipQiangHuaConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (EquipQiangHuaConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, EquipQiangHuaConfig> GetAll()
        {
            return this.dict;
        }

        public EquipQiangHuaConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class EquipQiangHuaConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>下一级强化</summary>
		[ProtoMember(2)]
		public int NextID { get; set; }
		/// <summary>强化等级</summary>
		[ProtoMember(3)]
		public int QiangHuaLv { get; set; }
		/// <summary>升级等级限制</summary>
		[ProtoMember(4)]
		public int UpLvLimit { get; set; }
		/// <summary>成功概率</summary>
		[ProtoMember(5)]
		public double SuccessPro { get; set; }
		/// <summary>消耗金币</summary>
		[ProtoMember(6)]
		public int CostGold { get; set; }
		/// <summary>强化消耗</summary>
		[ProtoMember(7)]
		public string CostItem { get; set; }
		/// <summary>强化属性</summary>
		[ProtoMember(8)]
		public string EquipPropreAdd { get; set; }
		/// <summary>强化属性</summary>
		[ProtoMember(9)]
		public string AddPropreListStr { get; set; }
		/// <summary>武器部位</summary>
		[ProtoMember(10)]
		public int ItemSubType { get; set; }
		/// <summary>失败附加成功概率</summary>
		[ProtoMember(11)]
		public double AdditionPro { get; set; }

	}
}
