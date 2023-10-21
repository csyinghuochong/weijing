using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetMingRewardHandler : AMActorLocationRpcHandler<Unit, C2M_PetMingRewardRequest, M2C_PetMingRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetMingRewardRequest request, M2C_PetMingRewardResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
