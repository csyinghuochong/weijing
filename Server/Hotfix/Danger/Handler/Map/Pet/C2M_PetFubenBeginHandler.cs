using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetFubenBeginHandler : AMActorLocationRpcHandler<Unit, C2M_PetFubenBeginRequest, M2C_PetFubenBeginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetFubenBeginRequest request, M2C_PetFubenBeginResponse response, Action reply)
        {
            Scene domainScene = unit.DomainScene();
            List<Unit> allunits = domainScene.GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < allunits.Count; i++)
            {
                if (allunits[i].Type!= UnitType.Pet && allunits[i].Type!= UnitType.Monster)
                {
                    continue;
                }
                allunits[i].GetComponent<AIComponent>().StopAI = false;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
