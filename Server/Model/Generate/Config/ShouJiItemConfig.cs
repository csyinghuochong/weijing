using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ShouJiItemConfigCategory : ProtoObject, IMerge
    {
        public static ShouJiItemConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ShouJiItemConfig> dict = new Dictionary<int, ShouJiItemConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ShouJiItemConfig> list = new List<ShouJiItemConfig>();
		
        public ShouJiItemConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ShouJiItemConfigCategory s = o as ShouJiItemConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ShouJiItemConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ShouJiItemConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ShouJiItemConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ShouJiItemConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ShouJiItemConfig> GetAll()
        {
            return this.dict;
        }

        public ShouJiItemConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ShouJiItemConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>下一个道具ID</summary>
		[ProtoMember(2)]
		public int NextID { get; set; }
		/// <summary>道具ID</summary>
		[ProtoMember(3)]
		public int ItemID { get; set; }
		/// <summary>道具星数</summary>
		[ProtoMember(4)]
		public int StartNum { get; set; }
		/// <summary>章节</summary>
		[ProtoMember(5)]
		public int Chap { get; set; }
		/// <summary>激活数量</summary>
		[ProtoMember(6)]
		public int AcitveNum { get; set; }
		/// <summary>附加属性</summary>
		[ProtoMember(7)]
		public string AddPropreListStr { get; set; }

	}
}
