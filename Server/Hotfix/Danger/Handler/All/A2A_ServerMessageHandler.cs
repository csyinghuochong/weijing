using System;

namespace ET
{

    //服务器之间通用通信协议
    [ActorMessageHandler]
    public class A2A_ServerMessageHandler : AMActorRpcHandler<Scene, A2A_ServerMessageRequest, A2A_ServerMessageRResponse>
    {

        protected override async ETTask Run(Scene scene, A2A_ServerMessageRequest request, A2A_ServerMessageRResponse response, Action reply)
        {
            try
            {
                switch (scene.SceneType)
                {
                    case SceneType.Team:
                        if (request.MessageType == NoticeType.PlayerExit)
                        {
                            scene.GetComponent<TeamSceneComponent>().OnRecvUnitLeave(long.Parse(request.MessageValue), true);
                        }
                        break;
                    case SceneType.Solo:
                        if (request.MessageType == NoticeType.PlayerExit)
                        {
                            scene.GetComponent<SoloSceneComponent>().OnRecvUnitLeave(long.Parse(request.MessageValue));
                        }
                        break;
                    case SceneType.Battle:
                        break;
                    case SceneType.Rank:
                        if (request.MessageType == NoticeType.RankRefresh)
                        {
                            scene.GetComponent<RankSceneComponent>().UpdateCombat().Coroutine();
                        }
                        break;
                    case SceneType.Chat:
                        ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
                        if (request.MessageType == NoticeType.PlayerExit)
                        {
                            long unitid = long.Parse(request.MessageValue);
                            if (chatInfoUnitsComponent.ChatInfoUnitsDict.ContainsKey(unitid))
                            {
                                chatInfoUnitsComponent.ChatInfoUnitsDict.Remove(unitid);
                            }
                        }
                        else
                        {
                            M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo()
                            {
                                NoticeType = request.MessageType,
                                NoticeText = request.MessageValue
                            };
                            foreach (var otherUnit in chatInfoUnitsComponent.ChatInfoUnitsDict.Values)
                            {
                                MessageHelper.SendActor(otherUnit.GateSessionActorId, m2C_HorseNoticeInfo);
                            }
                        }
                        reply();
                        break;
                    case SceneType.AccountCenter:
                        string[] messagevalue = request.MessageValue.Split('_');
                        if (!messagevalue[1].Equals(DllHelper.Admin))
                        {
                            reply();
                            return;
                        }
                        
                        if (messagevalue[0] == "0")
                        {
                            scene.GetComponent<FangChenMiComponent>().StopServer = true;
                            LogHelper.OnStopServer();
                            Log.Console("StopServer = true");
                        }
                        if(messagevalue[0] == "1")
                        {
                            scene.GetComponent<FangChenMiComponent>().StopServer = false;
                            Log.Console("StopServer = false");
                        }
                        if (messagevalue[0] == "2")
                        {
                            //20230412 1
                            Log.Console("生成序列号");
                            scene.GetComponent<AccountCenterComponent>().GenerateSerials(3);
                        }
                        //if (yeardate == 20230412 && hour == 13 && self.DomainZone() == 3)
                        //{
                        //    //通知中心刷新序列号
                        //    LogHelper.LogWarning($"刷新序列号", true);
                        //    long centerid = DBHelper.GetAccountCenter();
                        //    A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        //                 (centerid, new A2A_ActivityUpdateRequest() { ActivityType = 1 });
                        //}
                        break;
                    default:
                        break;
                }

                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception e)
            { 
                Log.Error(e);
            }
        }
    }
}