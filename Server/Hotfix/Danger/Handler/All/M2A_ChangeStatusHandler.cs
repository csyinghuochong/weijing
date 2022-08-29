using System;

namespace ET
{

    //目前只处理了上下线
    [ActorMessageHandler]
    public class M2A_ChangeStatusHandler : AMActorRpcHandler<Scene, M2A_ChangeStatusRequest, A2M_ChangeStatusResponse>
    {

        protected override async ETTask Run(Scene scene, M2A_ChangeStatusRequest request, A2M_ChangeStatusResponse response, Action reply)
        {
            switch (request.SceneType)
            {
                case (int)SceneType.Chat:
                    ChatSceneComponent chatComponent = scene.GetComponent<ChatSceneComponent>();
                    chatComponent.OnUnitChangeStatus(request);
                    break;
                case (int)SceneType.Team:
                    //处理下线逻辑
                    TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
                    teamSceneComponent.OnUnitChangeStatus(request).Coroutine();
                    break;
                case -1:
  
                    M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo() { NoticeType = HorseType.StopSever,  NoticeText = "停服维护" };
                    chatComponent = scene.GetComponent<ChatSceneComponent>();
                    for (int i = 0; i < chatComponent.WordActorList.Count; i++)
                    {
                        MessageHelper.SendActor(chatComponent.WordActorList[i].GateSessionActorId, m2C_HorseNoticeInfo);
                    }
                    reply();
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}