using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetShouHuHandler : AMActorLocationRpcHandler<Unit, C2M_PetShouHuRequest, M2C_PetShouHuResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetShouHuRequest request, M2C_PetShouHuResponse response, Action reply)
        {
            unit.GetComponent<PetComponent>().PetShouHuList = request.PetShouHuList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
