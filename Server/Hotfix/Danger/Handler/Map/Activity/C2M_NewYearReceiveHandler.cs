using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_NewYearReceiveHandler : AMActorLocationRpcHandler<Unit, C2M_NewYearReceiveRequest, M2C_NewYearReceiveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_NewYearReceiveRequest request, M2C_NewYearReceiveResponse response, Action reply)
        {


            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            if (activityComponent.ActivityReceiveIds.Contains(request.ActivityId))
            {
                reply();
                return;
            }


            reply();
            await ETTask.CompletedTask;
        }
    }
}
