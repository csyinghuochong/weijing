using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;


namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBUnionInfo : Entity
    {
        public UnionInfo UnionInfo = new UnionInfo();
    }
}
