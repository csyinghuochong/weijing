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
            response.OccRankId = rankSceneComponent.GetOccCombatRank(request.RankingInfo.UserId, request.RankingInfo.Occ);
            response.PetRankId = rankSceneComponent.GetPetRank(request.RankingInfo.UserId);
            if (rankSceneComponent.DBRankInfo.rankSoloInfo.Count > 0
             && rankSceneComponent.DBRankInfo.rankSoloInfo[0].UserId == request.RankingInfo.UserId)
            {
                response.SoloRankId = 1;
            }
            else
            {
                response.SoloRankId = 0;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
