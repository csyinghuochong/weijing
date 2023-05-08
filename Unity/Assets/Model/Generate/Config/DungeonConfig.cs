using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class DungeonConfigCategory : ProtoObject, IMerge
    {
        public static DungeonConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, DungeonConfig> dict = new Dictionary<int, DungeonConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<DungeonConfig> list = new List<DungeonConfig>();
		
        public DungeonConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            DungeonConfigCategory s = o as DungeonConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (DungeonConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public DungeonConfig Get(int id)
        {
            this.dict.TryGetValue(id, out DungeonConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (DungeonConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, DungeonConfig> GetAll()
        {
            return this.dict;
        }

        public DungeonConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class DungeonConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>章节名称</summary>
		[ProtoMember(2)]
		public string ChapterName { get; set; }
		/// <summary>音乐</summary>
		[ProtoMember(3)]
		public string Music { get; set; }
		/// <summary>进入等级限制</summary>
		[ProtoMember(4)]
		public int EnterLv { get; set; }
		/// <summary>章节BossIcon</summary>
		[ProtoMember(5)]
		public int BossIcon { get; set; }
		/// <summary>章节文本描述</summary>
		[ProtoMember(6)]
		public string ChapterDes { get; set; }
		/// <summary>地图ID</summary>
		[ProtoMember(7)]
		public int MapID { get; set; }
		/// <summary>出生点</summary>
		[ProtoMember(8)]
		public int[] BornPosLeft { get; set; }
		/// <summary>摄像机参数</summary>
		[ProtoMember(9)]
		public double[] CameraPos { get; set; }
		/// <summary>传送点</summary>
		[ProtoMember(10)]
		public int[] TransmitPos { get; set; }
		/// <summary>寻路</summary>
		[ProtoMember(11)]
		public string AutoPath { get; set; }
		/// <summary>NPC</summary>
		[ProtoMember(12)]
		public int[] NpcList { get; set; }
		/// <summary>野怪</summary>
		[ProtoMember(13)]
		public string CreateMonster { get; set; }
		/// <summary>野怪</summary>
		[ProtoMember(14)]
		public int MonsterGroup { get; set; }
		/// <summary>野怪</summary>
		[ProtoMember(15)]
		public int MonsterPosition { get; set; }

	}
}
