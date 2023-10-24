using System;

namespace ET
{

    [ActorMessageHandler]
    public class A2M_PetMingRecordHandler : AMActorRpcHandler<Unit, A2M_PetMingRecordRequest, M2A_PetMingRecordResponse>
    {
        protected override async ETTask Run(Unit unit, A2M_PetMingRecordRequest request, M2A_PetMingRecordResponse response, Action reply)
        {
            unit.GetComponent<PetComponent>().OnPetMingRecord( request.PetMingRecord );

            ///红点
            unit.GetComponent<ReddotComponent>().AddReddont(601);
            //unit.GetComponent<ReddotComponent>().AddReddont(ReddotType.PetMine);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
