using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class DropConfigCategory : ProtoObject, IMerge
    {
        public static DropConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, DropConfig> dict = new Dictionary<int, DropConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<DropConfig> list = new List<DropConfig>();
		
        public DropConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            DropConfigCategory s = o as DropConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (DropConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public DropConfig Get(int id)
        {
            this.dict.TryGetValue(id, out DropConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (DropConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, DropConfig> GetAll()
        {
            return this.dict;
        }

        public DropConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class DropConfig: ProtoObject, IConfig
	{
		/// <summary>id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>掉落类型</summary>
		[ProtoMember(2)]
		public int DropType { get; set; }
		/// <summary>掉落限制</summary>
		[ProtoMember(3)]
		public int DropLimit { get; set; }
		/// <summary>是否直接进入背包</summary>
		[ProtoMember(4)]
		public int ifEnterBag { get; set; }
		/// <summary>继承掉落ID</summary>
		[ProtoMember(5)]
		public int DropSonID { get; set; }
		/// <summary>掉落道具1概率</summary>
		[ProtoMember(6)]
		public int DropChance1 { get; set; }
		/// <summary>掉落道具1ID</summary>
		[ProtoMember(7)]
		public int DropItemID1 { get; set; }
		/// <summary>掉落道具1最小数量</summary>
		[ProtoMember(8)]
		public int DropItemMinNum1 { get; set; }
		/// <summary>掉落道具1最大数量</summary>
		[ProtoMember(9)]
		public int DropItemMaxNum1 { get; set; }
		/// <summary>掉落道具2概率</summary>
		[ProtoMember(10)]
		public int DropChance2 { get; set; }
		/// <summary>掉落道具2ID</summary>
		[ProtoMember(11)]
		public int DropItemID2 { get; set; }
		/// <summary>掉落道具2最小数量</summary>
		[ProtoMember(12)]
		public int DropItemMinNum2 { get; set; }
		/// <summary>掉落道具2最大数量</summary>
		[ProtoMember(13)]
		public int DropItemMaxNum2 { get; set; }
		/// <summary>掉落道具3概率</summary>
		[ProtoMember(14)]
		public int DropChance3 { get; set; }
		/// <summary>掉落道具3ID</summary>
		[ProtoMember(15)]
		public int DropItemID3 { get; set; }
		/// <summary>掉落道具3最小数量</summary>
		[ProtoMember(16)]
		public int DropItemMinNum3 { get; set; }
		/// <summary>掉落道具3最大数量</summary>
		[ProtoMember(17)]
		public int DropItemMaxNum3 { get; set; }
		/// <summary>掉落道具4概率</summary>
		[ProtoMember(18)]
		public int DropChance4 { get; set; }
		/// <summary>掉落道4ID</summary>
		[ProtoMember(19)]
		public int DropItemID4 { get; set; }
		/// <summary>掉落道具4最小数量</summary>
		[ProtoMember(20)]
		public int DropItemMinNum4 { get; set; }
		/// <summary>掉落道具4最大数量</summary>
		[ProtoMember(21)]
		public int DropItemMaxNum4 { get; set; }
		/// <summary>掉落道具5概率</summary>
		[ProtoMember(22)]
		public int DropChance5 { get; set; }
		/// <summary>掉落道具5ID</summary>
		[ProtoMember(23)]
		public int DropItemID5 { get; set; }
		/// <summary>掉落道具5最小数量</summary>
		[ProtoMember(24)]
		public int DropItemMinNum5 { get; set; }
		/// <summary>掉落道具5最大数量</summary>
		[ProtoMember(25)]
		public int DropItemMaxNum5 { get; set; }
		/// <summary>掉落道具6概率</summary>
		[ProtoMember(26)]
		public int DropChance6 { get; set; }
		/// <summary>掉落道具6ID</summary>
		[ProtoMember(27)]
		public int DropItemID6 { get; set; }
		/// <summary>掉落道具6最小数量</summary>
		[ProtoMember(28)]
		public int DropItemMinNum6 { get; set; }
		/// <summary>掉落道具6最大数量</summary>
		[ProtoMember(29)]
		public int DropItemMaxNum6 { get; set; }
		/// <summary>掉落道具7概率</summary>
		[ProtoMember(30)]
		public int DropChance7 { get; set; }
		/// <summary>掉落道具7ID</summary>
		[ProtoMember(31)]
		public int DropItemID7 { get; set; }
		/// <summary>掉落道具7最小数量</summary>
		[ProtoMember(32)]
		public int DropItemMinNum7 { get; set; }
		/// <summary>掉落道具7最大数量</summary>
		[ProtoMember(33)]
		public int DropItemMaxNum7 { get; set; }
		/// <summary>掉落道具8概率</summary>
		[ProtoMember(34)]
		public int DropChance8 { get; set; }
		/// <summary>掉落道具8ID</summary>
		[ProtoMember(35)]
		public int DropItemID8 { get; set; }
		/// <summary>掉落道具8最小数量</summary>
		[ProtoMember(36)]
		public int DropItemMinNum8 { get; set; }
		/// <summary>掉落道具8最大数量</summary>
		[ProtoMember(37)]
		public int DropItemMaxNum8 { get; set; }
		/// <summary>掉落道具9概率</summary>
		[ProtoMember(38)]
		public int DropChance9 { get; set; }
		/// <summary>掉落道具9ID</summary>
		[ProtoMember(39)]
		public int DropItemID9 { get; set; }
		/// <summary>掉落道具9最小数量</summary>
		[ProtoMember(40)]
		public int DropItemMinNum9 { get; set; }
		/// <summary>掉落道具9最大数量</summary>
		[ProtoMember(41)]
		public int DropItemMaxNum9 { get; set; }
		/// <summary>掉落道具10概率</summary>
		[ProtoMember(42)]
		public int DropChance10 { get; set; }
		/// <summary>掉落道具10ID</summary>
		[ProtoMember(43)]
		public int DropItemID10 { get; set; }
		/// <summary>掉落道具10最小数量</summary>
		[ProtoMember(44)]
		public int DropItemMinNum10 { get; set; }
		/// <summary>掉落道具10最大数量</summary>
		[ProtoMember(45)]
		public int DropItemMaxNum10 { get; set; }

	}
}
