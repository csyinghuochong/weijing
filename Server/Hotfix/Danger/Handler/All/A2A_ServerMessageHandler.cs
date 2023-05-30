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
                        if (request.MessageType == NoticeType.TeamExit)
                        {
                            scene.GetComponent<TeamSceneComponent>().OnRecvUnitLeave(long.Parse(request.MessageValue), true);
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
                        M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo()
                        {
                            NoticeType = request.MessageType,
                            NoticeText = request.MessageValue
                        };
                        ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
                        foreach (var otherUnit in chatInfoUnitsComponent.ChatInfoUnitsDict.Values)
                        {
                            MessageHelper.SendActor(otherUnit.GateSessionActorId, m2C_HorseNoticeInfo);
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
                            Log.Console("StopServer = true");
                        }
                        else
                        {
                            scene.GetComponent<FangChenMiComponent>().StopServer = false;
                            Log.Console("StopServer = false");
                        }
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