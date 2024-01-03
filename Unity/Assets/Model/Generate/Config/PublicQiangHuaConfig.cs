using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PublicQiangHuaConfigCategory : ProtoObject, IMerge
    {
        public static PublicQiangHuaConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PublicQiangHuaConfig> dict = new Dictionary<int, PublicQiangHuaConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PublicQiangHuaConfig> list = new List<PublicQiangHuaConfig>();
		
        public PublicQiangHuaConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PublicQiangHuaConfigCategory s = o as PublicQiangHuaConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PublicQiangHuaConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PublicQiangHuaConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PublicQiangHuaConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PublicQiangHuaConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PublicQiangHuaConfig> GetAll()
        {
            return this.dict;
        }

        public PublicQiangHuaConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PublicQiangHuaConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>装备名称</summary>
		[ProtoMember(2)]
		public string EquipSpaceName { get; set; }
		/// <summary>图标</summary>
		[ProtoMember(3)]
		public string Icon { get; set; }
		/// <summary>强化类型</summary>
		[ProtoMember(4)]
		public int ItemSubType { get; set; }
		/// <summary>下一级强化</summary>
		[ProtoMember(5)]
		public int NextID { get; set; }
		/// <summary>强化等级</summary>
		[ProtoMember(6)]
		public int QiangHuaLv { get; set; }
		/// <summary>升级等级限制</summary>
		[ProtoMember(7)]
		public int UpLvLimit { get; set; }
		/// <summary>成功概率</summary>
		[ProtoMember(8)]
		public double SuccessPro { get; set; }
		/// <summary>消耗金币</summary>
		[ProtoMember(9)]
		public int CostGold { get; set; }
		/// <summary>强化消耗</summary>
		[ProtoMember(10)]
		public string CostItem { get; set; }
		/// <summary>强化属性</summary>
		[ProtoMember(11)]
		public string EquipPropreAdd { get; set; }
		/// <summary>失败附加成功概率</summary>
		[ProtoMember(12)]
		public double AdditionPro { get; set; }

	}
}
