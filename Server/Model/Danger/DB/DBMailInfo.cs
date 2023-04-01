using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;


namespace ET
{
    [BsonIgnoreExtraElements]
    public class DBMailInfo : Entity
    {
        public List<MailInfo> MailInfoList = new List<MailInfo>();
    }
}
