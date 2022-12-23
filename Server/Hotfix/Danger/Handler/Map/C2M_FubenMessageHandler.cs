using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_FubenMessageHandler : AMActorLocationRpcHandler<Unit, C2M_FubenMessageRequest, M2C_FubenMessageResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FubenMessageRequest request, M2C_FubenMessageResponse response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}
