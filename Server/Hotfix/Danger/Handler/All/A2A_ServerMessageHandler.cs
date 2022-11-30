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
                    case SceneType.Account:
                        scene.GetComponent<FangChenMiComponent>().StopServer = true;
                        break;
                    case SceneType.Battle:
                        if (request.MessageType == NoticeType.BattleClose)
                        {
                            scene.GetComponent<BattleSceneComponent>().OnBattleOver();
                        }
                        break;
                    case SceneType.Chat:
                        M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo() { 
                            NoticeType = request.MessageType,
                            NoticeText = request.MessageValue };
                        ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
                        foreach (var otherUnit in chatInfoUnitsComponent.ChatInfoUnitsDict.Values)
                        {
                            MessageHelper.SendActor(otherUnit.GateSessionActorId, m2C_HorseNoticeInfo);
                        }
                        reply();
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