using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_RolePetTeamHandler : AMActorLocationRpcHandler<Unit, C2M_RankPetTeamRequest, M2C_RankPetTeamResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RankPetTeamRequest request, M2C_RankPetTeamResponse response, Action reply)
        {
            unit.GetComponent<PetComponent>().TeamPetList = request.PetIds;

            reply();
            await ETTask.CompletedTask;
        }    
    }
}
