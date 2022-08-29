using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2A_MysteryListHandler : AMActorRpcHandler<Scene, C2A_MysteryListRequest, A2C_MysteryListResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_MysteryListRequest request, A2C_MysteryListResponse response, Action reply)
        {
            response.MysteryItemInfos = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.MysteryItemInfos;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
