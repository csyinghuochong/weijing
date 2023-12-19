using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ActivityGuessHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityGuessRequest, M2C_ActivityGuessResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityGuessRequest request, M2C_ActivityGuessResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
