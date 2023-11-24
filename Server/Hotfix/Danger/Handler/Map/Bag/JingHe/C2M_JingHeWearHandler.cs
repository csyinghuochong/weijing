using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingHeWearHandler : AMActorLocationRpcHandler<Unit, C2M_JingHeWearRequest, M2C_JingHeWearResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingHeWearRequest request, M2C_JingHeWearResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
