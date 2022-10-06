using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class NpcConfigCategory : ProtoObject, IMerge
    {
        public static NpcConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, NpcConfig> dict = new Dictionary<int, NpcConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<NpcConfig> list = new List<NpcConfig>();
		
        public NpcConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            NpcConfigCategory s = o as NpcConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (NpcConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public NpcConfig Get(int id)
        {
            this.dict.TryGetValue(id, out NpcConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (NpcConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, NpcConfig> GetAll()
        {
            return this.dict;
        }

        public NpcConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class NpcConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>商店值</summary>
		[ProtoMember(3)]
		public int ShopValue { get; set; }
		/// <summary>NPC类型</summary>
		[ProtoMember(4)]
		public int NpcType { get; set; }
		/// <summary>任务ID</summary>
		[ProtoMember(5)]
		public int[] TaskID { get; set; }
		/// <summary>剧情对话ID</summary>
		[ProtoMember(6)]
		public int[] StorySpeakID { get; set; }
		/// <summary>npc参数</summary>
		[ProtoMember(7)]
		public int[] NpcPar { get; set; }
		/// <summary>描述</summary>
		[ProtoMember(8)]
		public string Desc { get; set; }
		/// <summary>资源</summary>
		[ProtoMember(9)]
		public string Asset { get; set; }
		/// <summary>位置</summary>
		[ProtoMember(10)]
		public int[] Position { get; set; }
		/// <summary>方向</summary>
		[ProtoMember(11)]
		public int Rotation { get; set; }
		/// <summary>移动坐标</summary>
		[ProtoMember(12)]
		public string MovePosition { get; set; }
		/// <summary>摄像头是否拉近</summary>
		[ProtoMember(13)]
		public int ifCameraLaJin { get; set; }
		/// <summary>对话信息</summary>
		[ProtoMember(14)]
		public string SpeakText { get; set; }
		/// <summary>头部说话</summary>
		[ProtoMember(15)]
		public string NpcHeadSpeakText { get; set; }
		/// <summary>任务提示</summary>
		[ProtoMember(16)]
		public string TaskHint { get; set; }
		/// <summary>播放音效ID</summary>
		[ProtoMember(17)]
		public int SourceID { get; set; }
		/// <summary>展示等级</summary>
		[ProtoMember(18)]
		public int ShowRoseLv { get; set; }
		/// <summary>出现类型</summary>
		[ProtoMember(19)]
		public int ShowType { get; set; }
		/// <summary>出现值</summary>
		[ProtoMember(20)]
		public int ShowValue { get; set; }
		/// <summary>商店类型</summary>
		[ProtoMember(21)]
		public int ShopType { get; set; }

	}
}
