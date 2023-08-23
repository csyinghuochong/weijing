using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2F_YeWaiSceneIdHandler : AMActorRpcHandler<Scene, M2F_YeWaiSceneIdRequest, F2M_YeWaiSceneIdResponse>
    {
        protected override async ETTask Run(Scene scene, M2F_YeWaiSceneIdRequest request, F2M_YeWaiSceneIdResponse response, Action reply)
        {
            if (scene.GetComponent<FubenCenterComponent>().YeWaiFubenList.ContainsKey(request.SceneId))
            {
                response.FubenInstanceId = scene.GetComponent<FubenCenterComponent>().YeWaiFubenList[request.SceneId];
                response.Message = scene.GetComponent<FubenCenterComponent>().GetScenePlayer(response.FubenInstanceId).ToString();
            }
            else
            {
                response.FubenInstanceId = 0;
                response.Message = "0";
            }
          
            reply();
            await ETTask.CompletedTask;
        }
    }
}
