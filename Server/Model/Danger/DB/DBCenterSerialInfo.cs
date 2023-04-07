using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Options;

namespace ET
{

    [BsonIgnoreExtraElements]
    public class DBCenterSerialInfo : Entity
    {

        public List<KeyValuePair> SerialList = new List<KeyValuePair>();

    }
}
