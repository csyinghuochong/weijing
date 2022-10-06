using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class DungeonSectionConfigCategory : ProtoObject, IMerge
    {
        public static DungeonSectionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, DungeonSectionConfig> dict = new Dictionary<int, DungeonSectionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<DungeonSectionConfig> list = new List<DungeonSectionConfig>();
		
        public DungeonSectionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            DungeonSectionConfigCategory s = o as DungeonSectionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (DungeonSectionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public DungeonSectionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out DungeonSectionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (DungeonSectionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, DungeonSectionConfig> GetAll()
        {
            return this.dict;
        }

        public DungeonSectionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class DungeonSectionConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>章节名称</summary>
		[ProtoMember(2)]
		public string ChapterName { get; set; }
		/// <summary>名称</summary>
		[ProtoMember(3)]
		public string Name { get; set; }
		/// <summary>章节关卡</summary>
		[ProtoMember(4)]
		public int[] RandomArea { get; set; }
		/// <summary>开启等级</summary>
		[ProtoMember(5)]
		public int[] OpenLevel { get; set; }

	}
}
