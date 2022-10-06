using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ChapterSonConfigCategory : ProtoObject, IMerge
    {
        public static ChapterSonConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ChapterSonConfig> dict = new Dictionary<int, ChapterSonConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ChapterSonConfig> list = new List<ChapterSonConfig>();
		
        public ChapterSonConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ChapterSonConfigCategory s = o as ChapterSonConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ChapterSonConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ChapterSonConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ChapterSonConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ChapterSonConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ChapterSonConfig> GetAll()
        {
            return this.dict;
        }

        public ChapterSonConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ChapterSonConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>关卡名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>地块类型</summary>
		[ProtoMember(3)]
		public int Type { get; set; }
		/// <summary>地图ID</summary>
		[ProtoMember(4)]
		public int MapID { get; set; }
		/// <summary>NPC</summary>
		[ProtoMember(5)]
		public int[] NpcList { get; set; }
		/// <summary>出生点</summary>
		[ProtoMember(6)]
		public int[] BornPosLeft { get; set; }
		/// <summary>出生点</summary>
		[ProtoMember(7)]
		public int[] BornPosUp { get; set; }
		/// <summary>出生点</summary>
		[ProtoMember(8)]
		public int[] BornPosDwon { get; set; }
		/// <summary>出生点</summary>
		[ProtoMember(9)]
		public int[] BornPosRight { get; set; }
		/// <summary>传送门坐标</summary>
		[ProtoMember(10)]
		public string TransmitPosi { get; set; }
		/// <summary>特殊场景怪物生成坐标点</summary>
		[ProtoMember(11)]
		public string CreateScenceMonsterPro { get; set; }
		/// <summary>特殊场景怪物生成坐标点</summary>
		[ProtoMember(12)]
		public string CreateScenceMonster { get; set; }
		/// <summary>怪物生成坐标点</summary>
		[ProtoMember(13)]
		public string CreateMonster { get; set; }

	}
}
