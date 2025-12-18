using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityOrderOperateHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityOrderOperateRequest, M2C_ActivityOrderOperateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityOrderOperateRequest request, M2C_ActivityOrderOperateResponse response, Action reply)
        {
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();


            response.ActivityV1Info = unit.GetComponent<ActivityComponent>().ActivityV1Info;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
