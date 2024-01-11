namespace ET
{

    [MessageHandler]
    public class M2C_FirstWinSelfUpdateHandler : AMHandler<M2C_FirstWinSelfUpdateMessage>
    {
        protected override void Run(Session session, M2C_FirstWinSelfUpdateMessage message)
        {
            session.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.FirstWinSelf = message.FirstWinInfos;
        }
    }
}
