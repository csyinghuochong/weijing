using System;

namespace ET
{

    [ActorMessageHandler]

    public class M2R_RankUpdateHandler : AMActorRpcHandler<Scene, M2R_RankUpdateRequest, R2M_RankUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_RankUpdateRequest request, R2M_RankUpdateResponse response, Action reply)
        {
            RankSceneComponent rankSceneComponent = scene.GetComponent<RankSceneComponent>();
            rankSceneComponent.OnRecvRankUpdate(request.CampId, request.RankingInfo);
            response.RankId = rankSceneComponent.GetCombatRank(request.RankingInfo.UserId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
