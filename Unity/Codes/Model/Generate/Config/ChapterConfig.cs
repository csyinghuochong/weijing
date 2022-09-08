using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ChapterConfigCategory : ProtoObject, IMerge
    {
        public static ChapterConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ChapterConfig> dict = new Dictionary<int, ChapterConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ChapterConfig> list = new List<ChapterConfig>();
		
        public ChapterConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ChapterConfigCategory s = o as ChapterConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ChapterConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ChapterConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ChapterConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ChapterConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ChapterConfig> GetAll()
        {
            return this.dict;
        }

        public ChapterConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ChapterConfig: ProtoObject, IConfig
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
		/// <summary>生成范围</summary>
		[ProtoMember(4)]
		public int[] InitSize { get; set; }
		/// <summary>起始地块</summary>
		[ProtoMember(5)]
		public int StartArea { get; set; }
		/// <summary>终点地块</summary>
		[ProtoMember(6)]
		public int EndArea { get; set; }
		/// <summary>禁止通行地块</summary>
		[ProtoMember(7)]
		public int StopArea { get; set; }
		/// <summary>奇遇房间概率</summary>
		[ProtoMember(8)]
		public double[] SpecialRoomPro { get; set; }
		/// <summary>奇遇房间</summary>
		[ProtoMember(9)]
		public int[] SpecialRoom { get; set; }
		/// <summary>禁止通行地块</summary>
		[ProtoMember(10)]
		public int StopAreaNum { get; set; }
		/// <summary>随机地块</summary>
		[ProtoMember(11)]
		public int[] RandomArea { get; set; }
		/// <summary>进入等级限制</summary>
		[ProtoMember(12)]
		public int EnterLv { get; set; }
		/// <summary>章节BossIcon</summary>
		[ProtoMember(13)]
		public int BossIcon { get; set; }
		/// <summary>章节文本描述</summary>
		[ProtoMember(14)]
		public string ChapterDes { get; set; }
		/// <summary>通关经验奖励</summary>
		[ProtoMember(15)]
		public int RewardExp { get; set; }
		/// <summary>通关金币奖励</summary>
		[ProtoMember(16)]
		public int RewardGold { get; set; }
		/// <summary>翻卡掉落ID</summary>
		[ProtoMember(17)]
		public int BoxDropID { get; set; }

	}
}
