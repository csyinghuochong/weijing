using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class JingLingConfigCategory : ProtoObject, IMerge
    {
        public static JingLingConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, JingLingConfig> dict = new Dictionary<int, JingLingConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<JingLingConfig> list = new List<JingLingConfig>();
		
        public JingLingConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            JingLingConfigCategory s = o as JingLingConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (JingLingConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public JingLingConfig Get(int id)
        {
            this.dict.TryGetValue(id, out JingLingConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (JingLingConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, JingLingConfig> GetAll()
        {
            return this.dict;
        }

        public JingLingConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class JingLingConfig: ProtoObject, IConfig
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
		/// <summary>模型</summary>
		[ProtoMember(4)]
		public string Assets { get; set; }
		/// <summary>额外属性</summary>
		[ProtoMember(5)]
		public string AddProperty { get; set; }
		/// <summary>序列帧动画</summary>
		[ProtoMember(6)]
		public string AnimatorAsset { get; set; }
		/// <summary>序列帧动画数量</summary>
		[ProtoMember(7)]
		public int AnimatorNumber { get; set; }
		/// <summary>有效期(秒)</summary>
		[ProtoMember(8)]
		public int ValidityTime { get; set; }
		/// <summary>额外属性描述</summary>
		[ProtoMember(9)]
		public string Des { get; set; }
		/// <summary>缩放大小</summary>
		[ProtoMember(10)]
		public double size { get; set; }
		/// <summary>X偏移</summary>
		[ProtoMember(11)]
		public double MoveX { get; set; }
		/// <summary>Y便宜</summary>
		[ProtoMember(12)]
		public double MoveY { get; set; }
		/// <summary>额外属性描述</summary>
		[ProtoMember(13)]
		public string GetDes { get; set; }
		/// <summary>功能类型</summary>
		[ProtoMember(14)]
		public int FunctionType { get; set; }
		/// <summary>功能参数</summary>
		[ProtoMember(15)]
		public string FunctionValue { get; set; }

	}
}
