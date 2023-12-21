using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetTakeOutBagHandler : AMActorLocationRpcHandler<Unit, C2M_PetTakeOutBag, M2C_PetTakeOutBag>
    {
        protected override async ETTask Run(Unit unit, C2M_PetTakeOutBag request, M2C_PetTakeOutBag response, Action reply)
        {
            unit.GetComponent<PetComponent>().TakeOutBag(request.PetInfoId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
