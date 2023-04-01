namespace ET
{
	public class SessionPlayerComponent : Entity, IAwake, IDestroy
	{
		public long PlayerId;
		public long PlayerInstanceId;	//用来通信的
		public long AccountId;

		public bool isLoginAgain = false;

		public long LastRecvTime;
	}
}