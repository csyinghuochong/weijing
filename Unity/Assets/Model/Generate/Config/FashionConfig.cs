using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class FashionConfigCategory : ProtoObject, IMerge
    {
        public static FashionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, FashionConfig> dict = new Dictionary<int, FashionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<FashionConfig> list = new List<FashionConfig>();
		
        public FashionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            FashionConfigCategory s = o as FashionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (FashionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public FashionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out FashionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (FashionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, FashionConfig> GetAll()
        {
            return this.dict;
        }

        public FashionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class FashionConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>职业</summary>
		[ProtoMember(2)]
		public int[] Occ { get; set; }
		/// <summary>时装部位</summary>
		[ProtoMember(3)]
		public int Position { get; set; }
		/// <summary>时装子类</summary>
		[ProtoMember(4)]
		public int SubType { get; set; }
		/// <summary>时装名字</summary>
		[ProtoMember(5)]
		public string Name { get; set; }
		/// <summary>时装模型</summary>
		[ProtoMember(6)]
		public string Model { get; set; }
		/// <summary>激活条件</summary>
		[ProtoMember(7)]
		public string ActiveCost { get; set; }
		/// <summary>时装属性加成Key</summary>
		[ProtoMember(8)]
		public int[] ItemModelID { get; set; }
		/// <summary>摄像机参数</summary>
		[ProtoMember(9)]
		public double[] Camera { get; set; }

	}
}
