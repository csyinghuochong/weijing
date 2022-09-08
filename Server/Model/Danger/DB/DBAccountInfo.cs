using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ET
{


	[BsonIgnoreExtraElements]
	public class DBAccountInfo : Entity, IAwake
	{
		//用户名
		public string Account { get; set; }

		//密码
		public string Password { get; set; }

		//UserList列表
		public List<long> UserList = new List<long>();

		//删除UserList列表
		public List<long> DeleteUserList = new List<long>();

		public int AccountType; //账号类型

		public long CreateTime;	//创建时间
	}
}
