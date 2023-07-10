using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBServerMailInfo : Entity
    {
        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
        public Dictionary<int, ServerMailItem> ServerMailList = new Dictionary<int, ServerMailItem>();
    }
}
