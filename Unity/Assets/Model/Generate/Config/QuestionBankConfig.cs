using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class QuestionBankConfigCategory : ProtoObject, IMerge
    {
        public static QuestionBankConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, QuestionBankConfig> dict = new Dictionary<int, QuestionBankConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<QuestionBankConfig> list = new List<QuestionBankConfig>();
		
        public QuestionBankConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            QuestionBankConfigCategory s = o as QuestionBankConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (QuestionBankConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public QuestionBankConfig Get(int id)
        {
            this.dict.TryGetValue(id, out QuestionBankConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (QuestionBankConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, QuestionBankConfig> GetAll()
        {
            return this.dict;
        }

        public QuestionBankConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class QuestionBankConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>正确答案</summary>
		[ProtoMember(2)]
		public string Right { get; set; }
		/// <summary>错误答案</summary>
		[ProtoMember(3)]
		public string Error { get; set; }
		/// <summary>问题</summary>
		[ProtoMember(4)]
		public string Question { get; set; }

	}
}
