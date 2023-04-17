using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetShouHuHandler : AMActorLocationRpcHandler<Unit, C2M_PetShouHuRequest, M2C_PetShouHuResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetShouHuRequest request, M2C_PetShouHuResponse response, Action reply)
        {
            RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
            if (rolePetInfo == null || rolePetInfo.ShouHuPos == 0)
            {
                reply();
                return;
            }


            List<long> shouhulist = unit.GetComponent<PetComponent>().PetShouHuList;
            shouhulist[rolePetInfo.ShouHuPos - 1] = request.PetInfoId;
            response.PetShouHuList = shouhulist;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
