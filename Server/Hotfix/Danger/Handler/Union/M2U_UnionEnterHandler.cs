using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2U_UnionEnterHandler : AMActorRpcHandler<Scene, M2U_UnionEnterRequest, U2M_UnionEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionEnterRequest request, U2M_UnionEnterResponse response, Action reply)
        {
            UnionSceneComponent unionSceneComponent = scene.GetComponent<UnionSceneComponent>();
            if (request.MasterId == 0 && request.UnitId == 0)
            {
                response.FubenInstanceId = unionSceneComponent.UnionRaceScene.InstanceId;
            }
            else
            {
                response.FubenInstanceId = unionSceneComponent.GetUnionFubenId(request.MasterId, request.UnitId);
            }
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
