using System;
using System.IO;

namespace ET
{

	//判断每秒收到的消息数量，超过一定数量就断开session，这个判断可以放到SessionStreamDispatcherServerOuter中去判断，
	//不需要修改session的代码，要注意软路由会自动重连的情况，会导致一瞬间出现大量消息，
	//不过一般也不会超过100个，基本上限制成100就行了
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

			long serverTime = TimeHelper.ServerNow();
			SessionPlayerComponent sessionPlayer = session.GetComponent<SessionPlayerComponent>();
            session.PackageNumber = sessionPlayer != null ? session.PackageNumber + 1 : 0;
            if (sessionPlayer != null && serverTime - sessionPlayer.LastRecvTime >= TimeHelper.Second)
			{
                int lastNumber = session.PackageNumber;
                sessionPlayer.LastRecvTime = serverTime;
                session.PackageNumber = 0;
               
                if (lastNumber > 500)
                {
                    Log.Warning($"session.PackageNumber too large: {lastNumber} {sessionPlayer.PlayerId}");
                    session?.Send(new A2C_Disconnect() { Error = ErrorCode.ERR_PackageFrequent });
                    session.Disconnect().Coroutine();
					return;
                }
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
						Player player = session.GetComponent<SessionPlayerComponent>().GetMyPlayer();
						if (player == null)
						{
							break; 
						}

                        if (actorRequest is IMailActorRequest mailActorRequest)
						{
							long chatId = player.MailServerID;
							response = await ActorMessageSenderComponent.Instance.Call(chatId, mailActorRequest);
						}
						else if (actorRequest is IRankActorRequest iRankActorRequest)
						{
							long rankId = player.RankServerID;
							response = await ActorMessageSenderComponent.Instance.Call(rankId, iRankActorRequest);
						}
						else if (actorRequest is IPaiMaiListRequest iPaiMaiRequest)
						{
							long paimaiServer = player.PaiMaiServerID;
							response = await ActorMessageSenderComponent.Instance.Call(paimaiServer, iPaiMaiRequest);
						}
						else if (actorRequest is IActivityActorRequest iActivityRequest)
						{
                            if (actorRequest is C2A_PetMingListRequest infoRequest)
                            {
                                infoRequest.ActorId = player.UnitId;
                            }
                            if (actorRequest is C2A_PetMingChanChuRequest infoRequest2)
                            {
                                infoRequest2.ActorId = player.UnitId;
                            }

                            long activityID = player.ActivityServerID;
							response = await ActorMessageSenderComponent.Instance.Call(activityID, iActivityRequest);
						}
						else if (actorRequest is ICenterActorRequest iGmActorRequest)
						{
							long gmServerID = player.CenterServerID;
							response = await ActorMessageSenderComponent.Instance.Call(gmServerID, iGmActorRequest);
						}
						else if (actorRequest is ITeamActorRequest iTeamActorRequest)
						{
							long teamServerID = player.TeamServerID;
							response = await ActorMessageSenderComponent.Instance.Call(teamServerID, iTeamActorRequest);
						}
						else if (actorRequest is IFriendActorRequest iFriendActorRequest)
						{
							long friendServerID = player.FriendServerID;
							response = await ActorMessageSenderComponent.Instance.Call(friendServerID, iFriendActorRequest);
						}
						else if (actorRequest is IUnionActorRequest iUnionActorRequest)
						{
                            if (actorRequest is C2U_UnionKeJiActiteRequest infoRequest)
                            {
                                infoRequest.ActorId = player.UnitId;
                            }
                            if (actorRequest is C2U_UnionKeJiQuickRequest infoRequest2)
                            {
                                infoRequest2.ActorId = player.UnitId;
                            }
                            long unionServerID = player.UnionServerID;
							response = await ActorMessageSenderComponent.Instance.Call(unionServerID, iUnionActorRequest);
						}
						else if (actorRequest is ISoloActorRequest iSoloActorRequest)
						{
                            if (actorRequest is C2S_SoloMyInfoRequest infoRequest)
							{ 
								infoRequest.ActorId = player.UnitId;
                            }

							long soloServerID = player.SoloServerID;
                            response = await ActorMessageSenderComponent.Instance.Call(soloServerID, iSoloActorRequest);
						}
						else if (actorRequest is IRechargeActorRequest iRechargeActorRequest)
						{
							long reChargeServerID = player.ReChargeServerID;
							response = await ActorMessageSenderComponent.Instance.Call(reChargeServerID, iRechargeActorRequest);
						}
						else if (actorRequest is IPopularizeActorRequest popularizeActorRequest)
						{
							long popularizeServerID = player.PopularizeServerID;
							response = await ActorMessageSenderComponent.Instance.Call(popularizeServerID, popularizeActorRequest);
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