namespace ET
{

    [MessageHandler]
    public class M2C_FriendApplyHandler : AMHandler<M2C_FriendApplyResult>
    {
        protected override  void Run(Session session, M2C_FriendApplyResult message)
        {
            session.ZoneScene().GetComponent<FriendComponent>().OnRecvFriendApplyResult(message);
        }
    }
}
