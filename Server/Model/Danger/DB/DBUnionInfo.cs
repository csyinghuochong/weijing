using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;


namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBUnionInfo : Entity
    {
        public UnionInfo UnionInfo = new UnionInfo();

        public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

        public long MysteryFreshTime = 0;
    }
}
