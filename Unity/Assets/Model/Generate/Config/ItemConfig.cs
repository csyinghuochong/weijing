using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ItemConfigCategory : ProtoObject, IMerge
    {
        public static ItemConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ItemConfig> dict = new Dictionary<int, ItemConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ItemConfig> list = new List<ItemConfig>();
		
        public ItemConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ItemConfigCategory s = o as ItemConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ItemConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ItemConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ItemConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ItemConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ItemConfig> GetAll()
        {
            return this.dict;
        }

        public ItemConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ItemConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>道具名称</summary>
		[ProtoMember(2)]
		public string ItemName { get; set; }
		/// <summary>道具Icon</summary>
		[ProtoMember(3)]
		public string Icon { get; set; }
		/// <summary>道具模型ID</summary>
		[ProtoMember(4)]
		public string ItemModelID { get; set; }
		/// <summary>道具品质</summary>
		[ProtoMember(5)]
		public int ItemQuality { get; set; }
		/// <summary>使用等级</summary>
		[ProtoMember(6)]
		public int UseLv { get; set; }
		/// <summary>使用职业</summary>
		[ProtoMember(7)]
		public int UseOcc { get; set; }
		/// <summary>道具类型</summary>
		[ProtoMember(8)]
		public int ItemType { get; set; }
		/// <summary>道具子类</summary>
		[ProtoMember(9)]
		public int ItemSubType { get; set; }
		/// <summary>装备类型</summary>
		[ProtoMember(10)]
		public int EquipType { get; set; }
		/// <summary>道具堆叠最大数量</summary>
		[ProtoMember(11)]
		public int ItemPileSum { get; set; }
		/// <summary>出售货币类型</summary>
		[ProtoMember(12)]
		public int SellMoneyType { get; set; }
		/// <summary>出售货币值</summary>
		[ProtoMember(13)]
		public int SellMoneyValue { get; set; }
		/// <summary>装备ID</summary>
		[ProtoMember(14)]
		public int ItemEquipID { get; set; }
		/// <summary>宠物之核合成新道具</summary>
		[ProtoMember(15)]
		public int PetHeXinHeChengID { get; set; }
		/// <summary>道具使用参数</summary>
		[ProtoMember(16)]
		public string ItemUsePar { get; set; }
		/// <summary>道具技能</summary>
		[ProtoMember(17)]
		public string SkillID { get; set; }
		/// <summary>道具Tips显示技能</summary>
		[ProtoMember(18)]
		public int SkillIDIfShow { get; set; }
		/// <summary>洗练石数量</summary>
		[ProtoMember(19)]
		public int[] XiLianStone { get; set; }
		/// <summary>回收获取物品</summary>
		[ProtoMember(20)]
		public string HuiShouGetItem { get; set; }
		/// <summary>道具描述</summary>
		[ProtoMember(21)]
		public string ItemDes { get; set; }
		/// <summary>道具背景描述</summary>
		[ProtoMember(22)]
		public string ItemBlackDes { get; set; }
		/// <summary>是否自动使用</summary>
		[ProtoMember(23)]
		public int IfAutoUse { get; set; }
		/// <summary>是否禁止拍卖行上架</summary>
		[ProtoMember(24)]
		public int IfStopPaiMai { get; set; }
		/// <summary>获取是否绑定</summary>
		[ProtoMember(25)]
		public int IfLock { get; set; }

	}
}
