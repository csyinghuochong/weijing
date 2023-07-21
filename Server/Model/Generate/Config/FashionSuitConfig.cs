using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class FashionSuitConfigCategory : ProtoObject, IMerge
    {
        public static FashionSuitConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, FashionSuitConfig> dict = new Dictionary<int, FashionSuitConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<FashionSuitConfig> list = new List<FashionSuitConfig>();
		
        public FashionSuitConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            FashionSuitConfigCategory s = o as FashionSuitConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (FashionSuitConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public FashionSuitConfig Get(int id)
        {
            this.dict.TryGetValue(id, out FashionSuitConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (FashionSuitConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, FashionSuitConfig> GetAll()
        {
            return this.dict;
        }

        public FashionSuitConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class FashionSuitConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>套装名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>套装模型</summary>
		[ProtoMember(3)]
		public string Model { get; set; }
		/// <summary>激活条件</summary>
		[ProtoMember(4)]
		public int[] ActiveCost { get; set; }
		/// <summary>套装属性加成Key</summary>
		[ProtoMember(5)]
		public int[] ItemModelID { get; set; }

	}
}
