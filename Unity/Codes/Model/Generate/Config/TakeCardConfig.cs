using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TakeCardConfigCategory : ProtoObject, IMerge
    {
        public static TakeCardConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TakeCardConfig> dict = new Dictionary<int, TakeCardConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TakeCardConfig> list = new List<TakeCardConfig>();
		
        public TakeCardConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TakeCardConfigCategory s = o as TakeCardConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TakeCardConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TakeCardConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TakeCardConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TakeCardConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TakeCardConfig> GetAll()
        {
            return this.dict;
        }

        public TakeCardConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TakeCardConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>抽卡等级</summary>
		[ProtoMember(2)]
		public int RoseLvLimit { get; set; }
		/// <summary>抽卡消耗钻石</summary>
		[ProtoMember(3)]
		public int ZuanShiNum { get; set; }
		/// <summary>抽卡消耗钻石</summary>
		[ProtoMember(4)]
		public int ZuanShiNum_Ten { get; set; }
		/// <summary>掉落ID</summary>
		[ProtoMember(5)]
		public int DropID { get; set; }
		/// <summary>掉落展示ID</summary>
		[ProtoMember(6)]
		public string DropShow { get; set; }

	}
}
