using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ZuoQiConfigCategory : ProtoObject, IMerge
    {
        public static ZuoQiConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ZuoQiConfig> dict = new Dictionary<int, ZuoQiConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ZuoQiConfig> list = new List<ZuoQiConfig>();
		
        public ZuoQiConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ZuoQiConfigCategory s = o as ZuoQiConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ZuoQiConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ZuoQiConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ZuoQiConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ZuoQiConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ZuoQiConfig> GetAll()
        {
            return this.dict;
        }

        public ZuoQiConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ZuoQiConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>图标显示</summary>
		[ProtoMember(3)]
		public int Icon { get; set; }
		/// <summary>下一级ID</summary>
		[ProtoMember(4)]
		public int NextID { get; set; }
		/// <summary>阶段名称</summary>
		[ProtoMember(5)]
		public string JieName { get; set; }
		/// <summary>等级</summary>
		[ProtoMember(6)]
		public int Lv { get; set; }
		/// <summary>升级需要</summary>
		[ProtoMember(7)]
		public int UpNeedLv { get; set; }
		/// <summary>消耗金币</summary>
		[ProtoMember(8)]
		public int UpZiZhiCostGold { get; set; }
		/// <summary>升级消耗</summary>
		[ProtoMember(9)]
		public int UpCostZiJin { get; set; }
		/// <summary>资质上限</summary>
		[ProtoMember(10)]
		public int ZiZhiMax { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(11)]
		public string AddProperty { get; set; }
		/// <summary>额外属性描述</summary>
		[ProtoMember(12)]
		public string Des { get; set; }

	}
}
