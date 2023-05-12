using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2U_UnionEnterHandler : AMActorRpcHandler<Scene, M2U_UnionEnterRequest, U2M_UnionEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionEnterRequest request, U2M_UnionEnterResponse response, Action reply)
        {
            UnionSceneComponent unionSceneComponent = scene.GetComponent<UnionSceneComponent>();
            if (request.OperateType == 1)
            {
                response.FubenInstanceId = unionSceneComponent.UnionRaceScene.InstanceId;
                unionSceneComponent.OnJoinUnionRace(request.UnionId, request.UnitId);
            }
            else
            {
                response.FubenInstanceId = unionSceneComponent.GetUnionFubenId(request.UnionId, request.UnitId);
            }
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
