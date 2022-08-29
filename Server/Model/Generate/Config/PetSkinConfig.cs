using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PetSkinConfigCategory : ProtoObject, IMerge
    {
        public static PetSkinConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PetSkinConfig> dict = new Dictionary<int, PetSkinConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PetSkinConfig> list = new List<PetSkinConfig>();
		
        public PetSkinConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PetSkinConfigCategory s = o as PetSkinConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PetSkinConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PetSkinConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PetSkinConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PetSkinConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PetSkinConfig> GetAll()
        {
            return this.dict;
        }

        public PetSkinConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PetSkinConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名称</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>皮肤图标</summary>
		[ProtoMember(3)]
		public int IconID { get; set; }
		/// <summary>皮肤ID</summary>
		[ProtoMember(4)]
		public int SkinID { get; set; }
		/// <summary>激活属性(暂时不用)</summary>
		[ProtoMember(5)]
		public string PripertySet { get; set; }

	}
}
