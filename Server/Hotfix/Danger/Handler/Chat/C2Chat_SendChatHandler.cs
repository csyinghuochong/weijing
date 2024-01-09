using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2Chat_SendChatHandler : AMActorRpcHandler<ChatInfoUnit, C2C_SendChatRequest, C2C_SendChatResponse>
    {

        protected override async ETTask Run(ChatInfoUnit chatInfoUnit, C2C_SendChatRequest request, C2C_SendChatResponse response, Action reply)
        {
            if (string.IsNullOrEmpty(request.ChatInfo.ChatMsg))
            {
                reply();
                return;
            }
            long serverTime = TimeHelper.ServerNow();
            if (serverTime - chatInfoUnit.LastSendChat < TimeHelper.Second * 2)
            {
                response.Error = ErrorCode.ERR_OperationOften;
                reply();
                return;
            }

            M2C_SyncChatInfo m2C_SyncChatInfo = new M2C_SyncChatInfo();
            request.ChatInfo.Time = TimeHelper.ServerNow();
            m2C_SyncChatInfo.ChatInfo = request.ChatInfo;
            switch (request.ChatInfo.ChannelId)
            {
                case (int)ChannelEnum.PaiMai:
                case (int)ChannelEnum.Word:
                    ChatSceneComponent chatInfoUnitsComponent = chatInfoUnit.DomainScene().GetComponent<ChatSceneComponent>();
                    foreach (var otherUnit in chatInfoUnitsComponent.ChatInfoUnitsDict.Values)
                    {
                        MessageHelper.SendActor(otherUnit.GateSessionActorId, m2C_SyncChatInfo);
                    }
                    chatInfoUnitsComponent.WordChatInfos.Add(request.ChatInfo);
                    if (chatInfoUnitsComponent.WordChatInfos.Count>10)
                    {
                        chatInfoUnitsComponent.WordChatInfos.RemoveAt(chatInfoUnitsComponent.WordChatInfos.Count - 1);
                    }
                    break;
                case (int)ChannelEnum.Team:
                    long teamServerId = StartSceneConfigCategory.Instance.GetBySceneName(chatInfoUnit.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
                    T2C_GetTeamInfoResponse g_SendChatRequest1 = (T2C_GetTeamInfoResponse)await ActorMessageSenderComponent.Instance.Call
                        (teamServerId, new C2T_GetTeamInfoRequest() { UserID = request.ChatInfo.UserId });

                    long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(chatInfoUnit.DomainZone(), "Gate1").InstanceId;
                    G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = null;
                    if (g_SendChatRequest1.Error == 0 && g_SendChatRequest1.TeamInfo != null)
                    {
                        for (int i = 0; i < g_SendChatRequest1.TeamInfo.PlayerList.Count; i++)
                        {
                           g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                           (gateServerId, new T2G_GateUnitInfoRequest()
                           {
                               UserID = g_SendChatRequest1.TeamInfo.PlayerList[i].UserID
                           });

                            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                            {
                                MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_SyncChatInfo);
                            }
                        }
                    }
                    break;
                case (int)ChannelEnum.Union:
                    long unionid = request.ChatInfo.ParamId;
                    if (unionid == 0)
                    {
                        response.Error = ErrorCode.ERR_Union_Not_Exist;
                        reply();
                        return;
                    }
                    chatInfoUnitsComponent = chatInfoUnit.DomainScene().GetComponent<ChatSceneComponent>();
                    foreach (var otherUnit in chatInfoUnitsComponent.ChatInfoUnitsDict.Values)
                    {
                        if (otherUnit.UnionId == unionid)
                        {
                            MessageHelper.SendActor(otherUnit.GateSessionActorId, m2C_SyncChatInfo);
                        }
                    }
                    break;

                case (int)ChannelEnum.Friend:
                    gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(chatInfoUnit.DomainZone(), "Gate1").InstanceId;
                    g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                          (gateServerId, new T2G_GateUnitInfoRequest()
                          {
                              UserID = request.ChatInfo.ParamId
                          });

                    //发给好友()
                    if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                    {
                        MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_SyncChatInfo);
                    }
                    else
                    {
                        //存入到离线消息
                        long dbCacheId = DBHelper.GetDbCacheId(chatInfoUnit.DomainZone());
                        DBFriendInfo dBFriendInfo = await DBHelper.GetComponentCache<DBFriendInfo>(chatInfoUnit.DomainZone(), request.ChatInfo.ParamId);
                        if (dBFriendInfo != null && dBFriendInfo.FriendChats.Count < 10)
                        {
                            dBFriendInfo.FriendChats.Add(request.ChatInfo);
                            DBHelper.SaveComponent(chatInfoUnit.DomainZone(), request.ChatInfo.ParamId, dBFriendInfo).Coroutine();
                        }
                    }

                    //发给自己
                    g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                          (gateServerId, new T2G_GateUnitInfoRequest()
                          {
                              UserID = request.ChatInfo.UserId
                          });
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_SyncChatInfo);
                    break;
            }
            reply();
        }
    }
}
