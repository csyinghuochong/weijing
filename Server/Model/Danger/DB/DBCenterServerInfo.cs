using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Options;

namespace ET
{ 
    [BsonIgnoreExtraElements]
    public class DBCenterServerInfo : Entity
    {
        public int RechageOpen;

        public List<long> GmWhiteList = new List<long>();

        public List<int> RechageDic = new List<int>();
    }
}
