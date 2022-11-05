using System.Collections.Generic;

namespace ET
{
    public class AccountInfoComponent: Entity, IAwake
    {
        public long MyId;

		public string NoticeStr;                //公告缓存内容
		public List<int> MyServerList;          //服务器缓存内容
		public List<ServerItem> AllServerList;         //服务器列表存内容

		//当前角色列表数据
		public List<CreateRoleListInfo> CreateRoleList = new List<CreateRoleListInfo>();

		public PlayerInfo PlayerInfo;

		public long AccountId = 0;

		public string Token;

		public string RealmKey;
		public string RealmAddress;

		//当前登录角色
		public int CurrentServerId;
		public string ServerIp;
		public string Account;
		public string Password;
		public string LoginType;
		public long CurrentRoleId;

		public long LastTime = 0;
	}
}