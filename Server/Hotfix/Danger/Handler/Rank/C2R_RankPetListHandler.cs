using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2R_RankPetListHandler : AMActorRpcHandler<Scene, C2R_RankPetListRequest, R2C_RankPetListResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankPetListRequest request, R2C_RankPetListResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();
            response.RankNumber = rankComponent.GetPetRank(request.UserId);
            response.RankPetList = rankComponent.GetRankPetList((int)response.RankNumber);

            reply();
            await ETTask.CompletedTask;
        }
    }

}
