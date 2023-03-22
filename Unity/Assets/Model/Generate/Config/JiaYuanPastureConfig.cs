using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class JiaYuanPastureConfigCategory : ProtoObject, IMerge
    {
        public static JiaYuanPastureConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, JiaYuanPastureConfig> dict = new Dictionary<int, JiaYuanPastureConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<JiaYuanPastureConfig> list = new List<JiaYuanPastureConfig>();
		
        public JiaYuanPastureConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            JiaYuanPastureConfigCategory s = o as JiaYuanPastureConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (JiaYuanPastureConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public JiaYuanPastureConfig Get(int id)
        {
            this.dict.TryGetValue(id, out JiaYuanPastureConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (JiaYuanPastureConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, JiaYuanPastureConfig> GetAll()
        {
            return this.dict;
        }

        public JiaYuanPastureConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class JiaYuanPastureConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(3)]
		public int Lv { get; set; }
		/// <summary>成长时间</summary>
		[ProtoMember(4)]
		public int[] UpTime { get; set; }
		/// <summary>人口数量</summary>
		[ProtoMember(5)]
		public int PeopleNum { get; set; }
		/// <summary>购买价格</summary>
		[ProtoMember(6)]
		public int BuyGold { get; set; }
		/// <summary>出售价格</summary>
		[ProtoMember(7)]
		public int SellGold { get; set; }
		/// <summary>掉落间隔时间</summary>
		[ProtoMember(8)]
		public int DropTime { get; set; }
		/// <summary>掉落概率</summary>
		[ProtoMember(9)]
		public double GetPro { get; set; }
		/// <summary>收获道具ID</summary>
		[ProtoMember(10)]
		public int GetItemID { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(11)]
		public string Speak { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(12)]
		public string Des { get; set; }
		/// <summary>购买家园限制</summary>
		[ProtoMember(13)]
		public int BuyJiaYuanLv { get; set; }
		/// <summary>购买家园权重</summary>
		[ProtoMember(14)]
		public int BuyJiaYuanPro { get; set; }

	}
}
