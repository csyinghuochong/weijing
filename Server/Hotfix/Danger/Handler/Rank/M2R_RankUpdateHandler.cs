using System;

namespace ET
{

    [ActorMessageHandler]

    public class M2R_RankUpdateHandler : AMActorRpcHandler<Scene, M2R_RankUpdateRequest, R2M_RankUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_RankUpdateRequest request, R2M_RankUpdateResponse response, Action reply)
        {
            scene.GetComponent<RankSceneComponent>().OnRecvRankUpdate(request.CampId, request.RankingInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
