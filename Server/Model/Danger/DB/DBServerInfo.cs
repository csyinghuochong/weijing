using MongoDB.Bson.Serialization.Attributes;

namespace ET
{

    [BsonIgnoreExtraElements]
	public class DBServerInfo : Entity
	{
		public ServerInfo ServerInfo = new ServerInfo();
	}

}
