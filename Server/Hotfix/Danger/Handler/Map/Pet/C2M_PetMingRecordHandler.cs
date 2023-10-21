using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetMingRecordHandler : AMActorLocationRpcHandler<Unit, C2M_PetMingRecordRequest, M2C_PetMingRecordResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetMingRecordRequest request, M2C_PetMingRecordResponse response, Action reply)
        {
            response.PetMingRecords = unit.GetComponent<PetComponent>().PetMingRecordList;
            reply();
            await ETTask.CompletedTask;
        } 
    }
}
