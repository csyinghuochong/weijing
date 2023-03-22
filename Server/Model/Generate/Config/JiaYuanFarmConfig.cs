using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class JiaYuanFarmConfigCategory : ProtoObject, IMerge
    {
        public static JiaYuanFarmConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, JiaYuanFarmConfig> dict = new Dictionary<int, JiaYuanFarmConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<JiaYuanFarmConfig> list = new List<JiaYuanFarmConfig>();
		
        public JiaYuanFarmConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            JiaYuanFarmConfigCategory s = o as JiaYuanFarmConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (JiaYuanFarmConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public JiaYuanFarmConfig Get(int id)
        {
            this.dict.TryGetValue(id, out JiaYuanFarmConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (JiaYuanFarmConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, JiaYuanFarmConfig> GetAll()
        {
            return this.dict;
        }

        public JiaYuanFarmConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class JiaYuanFarmConfig: ProtoObject, IConfig
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
		/// <summary>模型ID</summary>
		[ProtoMember(4)]
		public int ModelID { get; set; }
		/// <summary>成长时间</summary>
		[ProtoMember(5)]
		public int[] UpTime { get; set; }
		/// <summary>人口数量</summary>
		[ProtoMember(6)]
		public int PeopleNum { get; set; }
		/// <summary>购买价格</summary>
		[ProtoMember(7)]
		public int BuyGold { get; set; }
		/// <summary>出售价格</summary>
		[ProtoMember(8)]
		public int SellGold { get; set; }
		/// <summary>收获道具ID</summary>
		[ProtoMember(9)]
		public int GetItemID { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(10)]
		public string Speak { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(11)]
		public string Des { get; set; }
		/// <summary>收货间隔时间</summary>
		[ProtoMember(12)]
		public int GetItemTime { get; set; }
		/// <summary>收货次数上限</summary>
		[ProtoMember(13)]
		public int GetItemNum { get; set; }

	}
}
