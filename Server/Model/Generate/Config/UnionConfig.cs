using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class UnionConfigCategory : ProtoObject, IMerge
    {
        public static UnionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, UnionConfig> dict = new Dictionary<int, UnionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<UnionConfig> list = new List<UnionConfig>();
		
        public UnionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            UnionConfigCategory s = o as UnionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (UnionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public UnionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out UnionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (UnionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, UnionConfig> GetAll()
        {
            return this.dict;
        }

        public UnionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class UnionConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>升级经验</summary>
		[ProtoMember(2)]
		public int Exp { get; set; }
		/// <summary>人员上限</summary>
		[ProtoMember(3)]
		public int PeopleNum { get; set; }
		/// <summary>捐献金币</summary>
		[ProtoMember(4)]
		public int DonateGold { get; set; }
		/// <summary>捐献增加经验</summary>
		[ProtoMember(5)]
		public int[] DonateExp { get; set; }
		/// <summary>捐献增加贡献值</summary>
		[ProtoMember(6)]
		public int[] DonateReward { get; set; }
		/// <summary>升级全员奖励</summary>
		[ProtoMember(7)]
		public string UpAllReward { get; set; }

	}
}
