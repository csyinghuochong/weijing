using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{

	//RankServer
    [BsonIgnoreExtraElements]
	public class DBServerInfo : Entity
	{
		public ServerInfo ServerInfo = new ServerInfo();
	}

}
