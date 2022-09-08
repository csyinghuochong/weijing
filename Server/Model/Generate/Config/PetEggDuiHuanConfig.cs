using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PetEggDuiHuanConfigCategory : ProtoObject, IMerge
    {
        public static PetEggDuiHuanConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PetEggDuiHuanConfig> dict = new Dictionary<int, PetEggDuiHuanConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PetEggDuiHuanConfig> list = new List<PetEggDuiHuanConfig>();
		
        public PetEggDuiHuanConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PetEggDuiHuanConfigCategory s = o as PetEggDuiHuanConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PetEggDuiHuanConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PetEggDuiHuanConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PetEggDuiHuanConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PetEggDuiHuanConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PetEggDuiHuanConfig> GetAll()
        {
            return this.dict;
        }

        public PetEggDuiHuanConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PetEggDuiHuanConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>消耗</summary>
		[ProtoMember(2)]
		public string CostItems { get; set; }
		/// <summary>掉落ID</summary>
		[ProtoMember(3)]
		public int DropID { get; set; }

	}
}
