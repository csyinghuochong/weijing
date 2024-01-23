using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2F_YeWaiSceneIdHandler : AMActorRpcHandler<Scene, M2F_YeWaiSceneIdRequest, F2M_YeWaiSceneIdResponse>
    {
        protected override async ETTask Run(Scene scene, M2F_YeWaiSceneIdRequest request, F2M_YeWaiSceneIdResponse response, Action reply)
        {
            if (request.SceneId == 6000002 || request.SceneId == 6000003)
            {
                if (request.UnitId == 0)
                {
                    return;
                }
                int functionId = request.SceneId == 6000002 ? 1058 : 1059;
                response.FubenInstanceId = scene.GetComponent<FubenCenterComponent>().GetFunctionFubenId(functionId, request.UnitId);
                response.Message = "0";
            }
            else if (scene.GetComponent<FubenCenterComponent>().YeWaiFubenList.ContainsKey(request.SceneId))
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
