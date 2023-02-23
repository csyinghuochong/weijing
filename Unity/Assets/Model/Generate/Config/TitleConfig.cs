using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class TitleConfigCategory : ProtoObject, IMerge
    {
        public static TitleConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, TitleConfig> dict = new Dictionary<int, TitleConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<TitleConfig> list = new List<TitleConfig>();
		
        public TitleConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            TitleConfigCategory s = o as TitleConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (TitleConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public TitleConfig Get(int id)
        {
            this.dict.TryGetValue(id, out TitleConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (TitleConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, TitleConfig> GetAll()
        {
            return this.dict;
        }

        public TitleConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class TitleConfig: ProtoObject, IConfig
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
		/// <summary>额外属性</summary>
		[ProtoMember(4)]
		public string AddProperty { get; set; }
		/// <summary>序列帧动画</summary>
		[ProtoMember(5)]
		public string AnimatorAsset { get; set; }
		/// <summary>序列帧动画数量</summary>
		[ProtoMember(6)]
		public int AnimatorNumber { get; set; }
		/// <summary>有效期(秒)</summary>
		[ProtoMember(7)]
		public int ValidityTime { get; set; }
		/// <summary>额外属性描述</summary>
		[ProtoMember(8)]
		public string Des { get; set; }

	}
}
