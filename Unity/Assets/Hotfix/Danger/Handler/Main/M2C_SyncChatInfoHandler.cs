namespace ET
{

    [MessageHandler]
    public class M2C_SyncChatInfoHandler : AMHandler<M2C_SyncChatInfo>
    {

        protected override  void Run(Session session, M2C_SyncChatInfo message)
        {
            ChatInfo chatInfo = message.ChatInfo;   
            Scene zoneScene = session.ZoneScene();
            long selfId = UnitHelper.GetMyUnitId(zoneScene);

            if (chatInfo.ChannelId == ChannelEnum.Friend)
            {
                zoneScene.GetComponent<FriendComponent>().OnRecvChat(chatInfo);
            }
            else
            {
                zoneScene.GetComponent<ChatComponent>().OnRecvChat(chatInfo);
            }


#if !SERVER && NOT_UNITY
            
#else
            //玩家自己的拾取
            if (chatInfo.ChannelId == ChannelEnum.Pick && chatInfo.UserId == selfId)
            {
                zoneScene.GetComponent<BattleMessageComponent>().PickItemIds.Add(chatInfo.ParamId);
            }
#endif
        }

    }
}
