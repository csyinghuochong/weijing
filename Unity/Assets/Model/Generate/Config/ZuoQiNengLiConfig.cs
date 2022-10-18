using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ZuoQiNengLiConfigCategory : ProtoObject, IMerge
    {
        public static ZuoQiNengLiConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ZuoQiNengLiConfig> dict = new Dictionary<int, ZuoQiNengLiConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ZuoQiNengLiConfig> list = new List<ZuoQiNengLiConfig>();
		
        public ZuoQiNengLiConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ZuoQiNengLiConfigCategory s = o as ZuoQiNengLiConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ZuoQiNengLiConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ZuoQiNengLiConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ZuoQiNengLiConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ZuoQiNengLiConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ZuoQiNengLiConfig> GetAll()
        {
            return this.dict;
        }

        public ZuoQiNengLiConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ZuoQiNengLiConfig: ProtoObject, IConfig
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
		/// <summary>下一级ID</summary>
		[ProtoMember(4)]
		public int NextID { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(5)]
		public int Lv { get; set; }
		/// <summary>经验值</summary>
		[ProtoMember(6)]
		public int Exp { get; set; }
		/// <summary>升级消耗</summary>
		[ProtoMember(7)]
		public int UpCostItemID { get; set; }
		/// <summary>升级消耗</summary>
		[ProtoMember(8)]
		public int UpCostZiJin { get; set; }
		/// <summary>升级消耗</summary>
		[ProtoMember(9)]
		public int UpCostGold { get; set; }
		/// <summary>升级经验</summary>
		[ProtoMember(10)]
		public int UpAddExp { get; set; }
		/// <summary>坐骑能力等级属性</summary>
		[ProtoMember(11)]
		public string AddProperty { get; set; }

	}
}
