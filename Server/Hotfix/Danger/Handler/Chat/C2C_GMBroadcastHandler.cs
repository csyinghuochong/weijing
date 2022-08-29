using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2C_GMBroadcastHandler : AMActorRpcHandler<Scene, C2C_GMBroadcastRequest, C2C_GMBroadcastResponse>
    {
        protected override async ETTask Run(Scene scene, C2C_GMBroadcastRequest request, C2C_GMBroadcastResponse response, Action reply)
        {
            M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo() { NoticeText = request.NoticeText };
            ChatSceneComponent chatComponent = scene.GetComponent<ChatSceneComponent>();

            for (int i = 0; i < chatComponent.WordActorList.Count; i++)
            {
                MessageHelper.SendActor(chatComponent.WordActorList[i].GateSessionActorId, m2C_HorseNoticeInfo);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
