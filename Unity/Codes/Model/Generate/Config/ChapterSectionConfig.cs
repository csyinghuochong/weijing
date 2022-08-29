using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ChapterSectionConfigCategory : ProtoObject, IMerge
    {
        public static ChapterSectionConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ChapterSectionConfig> dict = new Dictionary<int, ChapterSectionConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ChapterSectionConfig> list = new List<ChapterSectionConfig>();
		
        public ChapterSectionConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ChapterSectionConfigCategory s = o as ChapterSectionConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ChapterSectionConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ChapterSectionConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ChapterSectionConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ChapterSectionConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ChapterSectionConfig> GetAll()
        {
            return this.dict;
        }

        public ChapterSectionConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ChapterSectionConfig: ProtoObject, IConfig
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

	}
}
