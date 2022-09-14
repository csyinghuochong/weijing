using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetFubenBeginHandler : AMActorLocationRpcHandler<Unit, C2M_PetFubenBeginRequest, M2C_PetFubenBeginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetFubenBeginRequest request, M2C_PetFubenBeginResponse response, Action reply)
        {
            int petfubenId = unit.DomainScene().GetComponent<MapComponent>().SonSceneId;
            //unit.DomainScene().GetComponent<PetFubenSceneComponent>().GeneratePetFuben(unit, petfubenId).Coroutine();
            List<Unit> allunits = unit.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < allunits.Count; i++)
            {
                UnitInfoComponent unitInfoComponent = allunits[i].GetComponent<UnitInfoComponent>();
                if (unitInfoComponent.Type!= UnitType.Pet && unitInfoComponent.Type!= UnitType.Monster)
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
