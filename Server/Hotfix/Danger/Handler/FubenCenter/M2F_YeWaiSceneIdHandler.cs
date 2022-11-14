using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2F_YeWaiSceneIdHandler : AMActorRpcHandler<Scene, M2F_YeWaiSceneIdRequest, F2M_YeWaiSceneIdResponse>
    {
        protected override async ETTask Run(Scene scene, M2F_YeWaiSceneIdRequest request, F2M_YeWaiSceneIdResponse response, Action reply)
        {
            response.FubenInstanceId = scene.GetComponent<FubenCenterComponent>().YeWaiFubenList[request.SceneId];
            reply();
            await ETTask.CompletedTask;
        }
    }
}
