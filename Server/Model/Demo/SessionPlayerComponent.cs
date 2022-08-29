namespace ET
{
	public class SessionPlayerComponent : Entity, IAwake, IDestroy
	{
		public long PlayerId;
		public long PlayerInstanceId;
		public long AccountId;

		public int DisconnectType = 0;	//正常 1 重登  2顶号
	}
}