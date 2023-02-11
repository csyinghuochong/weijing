using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ZuoQiShowConfigCategory : ProtoObject, IMerge
    {
        public static ZuoQiShowConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ZuoQiShowConfig> dict = new Dictionary<int, ZuoQiShowConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ZuoQiShowConfig> list = new List<ZuoQiShowConfig>();
		
        public ZuoQiShowConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ZuoQiShowConfigCategory s = o as ZuoQiShowConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ZuoQiShowConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ZuoQiShowConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ZuoQiShowConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ZuoQiShowConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ZuoQiShowConfig> GetAll()
        {
            return this.dict;
        }

        public ZuoQiShowConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ZuoQiShowConfig: ProtoObject, IConfig
	{
		/// <summary>ID</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>品质</summary>
		[ProtoMember(3)]
		public int Quality { get; set; }
		/// <summary>图标显示</summary>
		[ProtoMember(4)]
		public string Icon { get; set; }
		/// <summary>模型ID</summary>
		[ProtoMember(5)]
		public string ModelID { get; set; }
		/// <summary>拖尾特效ID</summary>
		[ProtoMember(6)]
		public string TuoWeiEffectID { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(7)]
		public string Des { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(8)]
		public string AddProperty { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(9)]
		public string GetDes { get; set; }
		/// <summary>对应骑乘Buff</summary>
		[ProtoMember(10)]
		public int MoveBuffID { get; set; }

	}
}
