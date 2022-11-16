using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SceneConfigCategory : ProtoObject, IMerge
    {
        public static SceneConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SceneConfig> dict = new Dictionary<int, SceneConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SceneConfig> list = new List<SceneConfig>();
		
        public SceneConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            SceneConfigCategory s = o as SceneConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (SceneConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public SceneConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SceneConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SceneConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SceneConfig> GetAll()
        {
            return this.dict;
        }

        public SceneConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SceneConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>章节名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>图标显示</summary>
		[ProtoMember(3)]
		public string Icon { get; set; }
		/// <summary>摆摊区域</summary>
		[ProtoMember(4)]
		public int[] StallArea { get; set; }
		/// <summary>出生坐标点</summary>
		[ProtoMember(5)]
		public int[] InitPos { get; set; }
		/// <summary>NPC</summary>
		[ProtoMember(6)]
		public int[] NpcList { get; set; }
		/// <summary>地图类型</summary>
		[ProtoMember(7)]
		public int MapType { get; set; }
		/// <summary>地图ID</summary>
		[ProtoMember(8)]
		public int MapID { get; set; }
		/// <summary>loading图</summary>
		[ProtoMember(9)]
		public string LoadingRes { get; set; }
		/// <summary>是否有小地图</summary>
		[ProtoMember(10)]
		public int ifShowMinMap { get; set; }
		/// <summary>是否可以使用复活</summary>
		[ProtoMember(11)]
		public int IfUseRes { get; set; }
		/// <summary>是否允许PVP</summary>
		[ProtoMember(12)]
		public int IfPVP { get; set; }
		/// <summary>音乐</summary>
		[ProtoMember(13)]
		public string Music { get; set; }
		/// <summary>创建等级限制</summary>
		[ProtoMember(14)]
		public int CreateLv { get; set; }
		/// <summary>进入等级限制</summary>
		[ProtoMember(15)]
		public int EnterLv { get; set; }
		/// <summary>推荐等级</summary>
		[ProtoMember(16)]
		public int[] TuiJianLv { get; set; }
		/// <summary>进入人数限制</summary>
		[ProtoMember(17)]
		public int PlayerLimit { get; set; }
		/// <summary>进入次数限制</summary>
		[ProtoMember(18)]
		public int DayEnterNum { get; set; }
		/// <summary>章节BossId</summary>
		[ProtoMember(19)]
		public int BossId { get; set; }
		/// <summary>怪物生成坐标点</summary>
		[ProtoMember(20)]
		public string CreateMonster { get; set; }
		/// <summary>怪物生成坐标点</summary>
		[ProtoMember(21)]
		public int[] CreateMonsterPosi { get; set; }
		/// <summary>章节文本描述</summary>
		[ProtoMember(22)]
		public string ChapterDes { get; set; }
		/// <summary>奖励展示</summary>
		[ProtoMember(23)]
		public string RewardShow { get; set; }
		/// <summary>通关经验奖励</summary>
		[ProtoMember(24)]
		public int RewardExp { get; set; }
		/// <summary>通关金币奖励</summary>
		[ProtoMember(25)]
		public int RewardGold { get; set; }
		/// <summary>翻卡掉落ID</summary>
		[ProtoMember(26)]
		public int BoxDropID { get; set; }
		/// <summary>摄像机参数</summary>
		[ProtoMember(27)]
		public double[] CameraPos { get; set; }

	}
}
