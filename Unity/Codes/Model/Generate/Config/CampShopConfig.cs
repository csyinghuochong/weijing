using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class CampShopConfigCategory : ProtoObject, IMerge
    {
        public static CampShopConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, CampShopConfig> dict = new Dictionary<int, CampShopConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<CampShopConfig> list = new List<CampShopConfig>();
		
        public CampShopConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            CampShopConfigCategory s = o as CampShopConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (CampShopConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public CampShopConfig Get(int id)
        {
            this.dict.TryGetValue(id, out CampShopConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (CampShopConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, CampShopConfig> GetAll()
        {
            return this.dict;
        }

        public CampShopConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class CampShopConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>出售道具</summary>
		[ProtoMember(2)]
		public int SellItemID { get; set; }
		/// <summary>出售道具</summary>
		[ProtoMember(3)]
		public int SellItemNum { get; set; }
		/// <summary>出售价格</summary>
		[ProtoMember(4)]
		public int SellValue { get; set; }

	}
}
