using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2R_PetRankUpdateHandler : AMActorRpcHandler<Scene, M2R_PetRankUpdateRequest, R2M_PetRankUpdateResponse>
    {

        protected override async ETTask Run(Scene scene, M2R_PetRankUpdateRequest request, R2M_PetRankUpdateResponse response, Action reply)
        {
            scene.GetComponent<RankSceneComponent>().OnRecvPetRank(request);

            reply();
            await ETTask.CompletedTask;
        }

    }
}
