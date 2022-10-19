using System;
using System.IO;

namespace ET
{
    [SessionStreamDispatcher(SessionStreamDispatcherType.SessionStreamDispatcherServerOuter)]
    public class SessionStreamDispatcherServerOuter: ISessionStreamDispatcher
    {
        public void Dispatch(Session session, MemoryStream memoryStream)
        {
            ushort opcode = BitConverter.ToUInt16(memoryStream.GetBuffer(), Packet.KcpOpcodeIndex);
            Type type = OpcodeTypeComponent.Instance.GetType(opcode);
            object message = MessageSerializeHelper.DeserializeFrom(opcode, type, memoryStream);

            if (message is IResponse response)
            {
                session.OnRead(opcode, response);
                return;
            }

            OpcodeHelper.LogMsg(session.DomainZone(), opcode, message);
			
            DispatchAsync(session, opcode, message).Coroutine();
        }
		
        public async ETTask DispatchAsync(Session session, ushort opcode, object message)
        {
            // 根据消息接口判断是不是Actor消息，不同的接口做不同的处理
            switch (message)
            {
                case IActorLocationRequest actorLocationRequest: // gate session收到actor rpc消息，先向actor 发送rpc请求，再将请求结果返回客户端
                {
					if (session.GetComponent<SessionPlayerComponent>() == null)
					{
						Log.Debug($"SessionDispatcher session.InstanceId:{session.InstanceId} opcode: {opcode}");
						return;
					}
					long unitId = session.GetComponent<SessionPlayerComponent>().PlayerId;
                    int rpcId = actorLocationRequest.RpcId; // 这里要保存客户端的rpcId
                    long instanceId = session.InstanceId;
                    IResponse response = await ActorLocationSenderComponent.Instance.Call(unitId, actorLocationRequest);
                    response.RpcId = rpcId;
                    // session可能已经断开了，所以这里需要判断
                    if (session.InstanceId == instanceId)
                    {
                        session.Reply(response);
                    }
                    break;
                }
                case IActorLocationMessage actorLocationMessage:
                {
					if (session.GetComponent<SessionPlayerComponent>() == null)
					{
						Log.Debug($"SessionDispatcher session.InstanceId:{session.InstanceId} opcode: {opcode}");
						return;
					}
					long unitId = session.GetComponent<SessionPlayerComponent>().PlayerId;
                    ActorLocationSenderComponent.Instance.Send(unitId, actorLocationMessage);
                    break;
                }
				case IDBCacheActorRequest cacheActorRequest:
				{
					int rpcId = cacheActorRequest.RpcId;
					long instanceId = session.InstanceId;
					long dbCacheId = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().DBCacheId;
					IResponse response = await ActorMessageSenderComponent.Instance.Call(dbCacheId, cacheActorRequest);
					if (response == null)
					{
						break;
					}
					response.RpcId = rpcId;
					if (session.InstanceId == instanceId)
					{
						session.Reply(response);
					}
					break;
				}
				case IChatActorRequest actorChatInfoRequest:
					{
						Player player = Game.EventSystem.Get(session.GetComponent<SessionPlayerComponent>().PlayerInstanceId) as Player;
						if (player == null || player.IsDisposed || player.ChatInfoInstanceId == 0)
						{
							break;
						}

						int rpcId = actorChatInfoRequest.RpcId; // 这里要保存客户端的rpcId
						long instanceId = session.InstanceId;
						IResponse response = await ActorMessageSenderComponent.Instance.Call(player.ChatInfoInstanceId, actorChatInfoRequest);
						response.RpcId = rpcId;
						// session可能已经断开了，所以这里需要判断
						if (session.InstanceId == instanceId)
						{
							session.Reply(response);
						}
						break;
					}
				case IChatActorMessage actorChatInfoMessage:
					{
						Player player = Game.EventSystem.Get(session.GetComponent<SessionPlayerComponent>().PlayerInstanceId) as Player;
						if (player == null || player.IsDisposed || player.ChatInfoInstanceId == 0)
						{
							break;
						}

						ActorMessageSenderComponent.Instance.Send(player.ChatInfoInstanceId, actorChatInfoMessage);
						break;
					}
				case IActorRequest actorRequest:  // 分发IActorRequest消息，目前没有用到，需要的自己添加
                {
						IResponse response = null;
						int rpcId = actorRequest.RpcId;
						long instanceId = session.InstanceId;
						if (actorRequest is IMailActorRequest mailActorRequest)
						{
							long chatId = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().MailServerID;
							response = await ActorMessageSenderComponent.Instance.Call(chatId, mailActorRequest);
						}
						else if (actorRequest is IRankActorRequest iRankActorRequest)
						{
							long rankId = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().RankServerID;
							response = await ActorMessageSenderComponent.Instance.Call(rankId, iRankActorRequest);
						}
						else if (actorRequest is IPaiMaiListRequest iPaiMaiRequest)
						{
							long paimaiServer = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().PaiMaiServerID;
							response = await ActorMessageSenderComponent.Instance.Call(paimaiServer, iPaiMaiRequest);
						}
						else if (actorRequest is IActivityActorRequest iActivityRequest)
						{
							long activityID = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().ActivityServerID;
							response = await ActorMessageSenderComponent.Instance.Call(activityID, iActivityRequest);
						}
						else if (actorRequest is ICenterActorRequest iGmActorRequest)
						{
							long gmServerID = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().CenterServerID;
							response = await ActorMessageSenderComponent.Instance.Call(gmServerID, iGmActorRequest);
						}
						else if (actorRequest is ITeamActorRequest iTeamActorRequest)
						{
							long teamServerID = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().TeamServerID;
							response = await ActorMessageSenderComponent.Instance.Call(teamServerID, iTeamActorRequest);
						}
						else if (actorRequest is IFriendActorRequest iFriendActorRequest)
						{
							long friendServerID = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().FriendServerID;
							response = await ActorMessageSenderComponent.Instance.Call(friendServerID, iFriendActorRequest);
						}
						else if(actorRequest is IUnionActorRequest iUnionActorRequest)
						{
							long unionServerID = session.GetComponent<SessionPlayerComponent>().GetMyPlayer().UnionServerID;
							response = await ActorMessageSenderComponent.Instance.Call(unionServerID, iUnionActorRequest);
						}
						if (response == null)
						{
							break;
						}
						response.RpcId = rpcId;
						if (session.InstanceId == instanceId)
						{
							session.Reply(response);
						}
						break;
                }
                case IActorMessage actorMessage:  // 分发IActorMessage消息，目前没有用到，需要的自己添加
                {
                    break;
                }
				
                default:
                {
                    // 非Actor消息
                    MessageDispatcherComponent.Instance.Handle(session, opcode, message);
                    break;
                }
            }
        }
    }
}