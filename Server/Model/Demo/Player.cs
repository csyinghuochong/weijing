namespace ET
{
	public enum PlayerState : int
	{
		None = 0,
		Disconnect,
		Gate,
		Game,
	}

	public sealed class Player : Entity, IAwake<string>, IAwake<long,long>
	{ 
		public long AccountId { get; set; }

		public Session ClientSession { get; set; }

		public long UnitId { get; set; }		//unitid  ==  userid

		public PlayerState PlayerState { get; set; }

		public long DBCacheId { get; set; }

		public long ChatServerID { get; set; }

		public long MailServerID { get; set; }

		public long ReChargeServerID { get; set; }

		public long RankServerID { get; set; }

		public long PaiMaiServerID { get; set; }

		public long ActivityServerID { get; set; }

		public long CenterServerID { get; set; }

		public long TeamServerID { get; set; }

		public long FriendServerID { get; set; }

		public long UnionServerID { get; set; }

		public string RemoteAddress { get; set; }
	}
}