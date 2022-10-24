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
                switch (request.SceneType)
                {
                    case (int)SceneType.Team:
                        //处理下线逻辑
                        TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
                        teamSceneComponent.OnUnitDisconnect(request).Coroutine();
                        break;
                    case (int)SceneType.Chat:
                        if (request.MessageType == -1)
                        {
                            M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo() { NoticeType = HorseType.StopSever, NoticeText = "停服维护" };
                            ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
                            foreach (var otherUnit in chatInfoUnitsComponent.ChatInfoUnitsDict.Values)
                            {
                                MessageHelper.SendActor(otherUnit.GateSessionActorId, m2C_HorseNoticeInfo);
                            }
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