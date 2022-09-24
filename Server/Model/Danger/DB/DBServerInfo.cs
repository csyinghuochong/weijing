using MongoDB.Bson.Serialization.Attributes;

namespace ET
{

	//RankServer
    [BsonIgnoreExtraElements]
	public class DBServerInfo : Entity
	{
		public ServerInfo ServerInfo = new ServerInfo();
	}

}
