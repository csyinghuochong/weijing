using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBServerMailInfo : Entity
    {
        public Dictionary<int, KeyValuePair> ServerMailList = new Dictionary<int, KeyValuePair>();
    }
}
