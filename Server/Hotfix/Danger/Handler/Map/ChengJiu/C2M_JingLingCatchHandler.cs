using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingLingCatchHandler : AMActorLocationRpcHandler<Unit, C2M_JingLingCatchRequest, M2C_JingLingCatchResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingLingCatchRequest request, M2C_JingLingCatchResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }

}