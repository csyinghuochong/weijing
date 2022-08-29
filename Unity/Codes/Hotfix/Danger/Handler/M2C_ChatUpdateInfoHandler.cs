namespace ET
{

    [MessageHandler]
    public class M2C_ChatUpdateInfoHandler : AMHandler<M2C_SyncChatInfo>
    {

        protected override  void Run(Session session, M2C_SyncChatInfo message)
        {
            if (message.ChatInfo.ChannelId == (int)ChannelEnum.Friend)
            {
                session.ZoneScene().GetComponent<FriendComponent>().OnRecvChat(message.ChatInfo);
            }
            else
            {
                session.ZoneScene().GetComponent<ChatComponent>().OnRecvChat(message.ChatInfo);
            }
        }

    }
}
