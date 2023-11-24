using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingHePlanHandler : AMActorLocationRpcHandler<Unit, C2M_JingHePlanRequest, M2C_JingHePlanResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingHePlanRequest request, M2C_JingHePlanResponse response, Action reply)
        {
            unit.GetComponent<BagComponent>().SeasonJingHePlan = request.JingHePlan;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
