using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ShouJiConfigCategory : ProtoObject, IMerge
    {
        public static ShouJiConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ShouJiConfig> dict = new Dictionary<int, ShouJiConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ShouJiConfig> list = new List<ShouJiConfig>();
		
        public ShouJiConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ShouJiConfigCategory s = o as ShouJiConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ShouJiConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ShouJiConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ShouJiConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ShouJiConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ShouJiConfig> GetAll()
        {
            return this.dict;
        }

        public ShouJiConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ShouJiConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>开启等级</summary>
		[ProtoMember(2)]
		public int OpenLv { get; set; }
		/// <summary>章节ID</summary>
		[ProtoMember(3)]
		public int ChapterNum { get; set; }
		/// <summary>章节描述</summary>
		[ProtoMember(4)]
		public string ChapterDes { get; set; }
		/// <summary>物品ID</summary>
		[ProtoMember(5)]
		public int ItemListID { get; set; }
		/// <summary>星级1</summary>
		[ProtoMember(6)]
		public int ProList1_StartNum { get; set; }
		/// <summary>星级1属性类型</summary>
		[ProtoMember(7)]
		public int[] ProList1_Type { get; set; }
		/// <summary>星级1属性值</summary>
		[ProtoMember(8)]
		public long[] ProList1_Value { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(9)]
		public string RewardList_1 { get; set; }
		/// <summary>星级2</summary>
		[ProtoMember(10)]
		public int ProList2_StartNum { get; set; }
		/// <summary>星级2属性类型</summary>
		[ProtoMember(11)]
		public int[] ProList2_Type { get; set; }
		/// <summary>星级2属性值</summary>
		[ProtoMember(12)]
		public long[] ProList2_Value { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(13)]
		public string RewardList_2 { get; set; }
		/// <summary>星级3</summary>
		[ProtoMember(14)]
		public int ProList3_StartNum { get; set; }
		/// <summary>星级3属性类型</summary>
		[ProtoMember(15)]
		public int[] ProList3_Type { get; set; }
		/// <summary>星级3属性值</summary>
		[ProtoMember(16)]
		public long[] ProList3_Value { get; set; }
		/// <summary>奖励</summary>
		[ProtoMember(17)]
		public string RewardList_3 { get; set; }

	}
}
