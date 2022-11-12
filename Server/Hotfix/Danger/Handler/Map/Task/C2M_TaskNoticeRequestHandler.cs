
using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskNoticeRequestHandler : AMActorLocationRpcHandler<Unit, C2M_TaskNoticeRequest, M2C_TaskNoticeResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskNoticeRequest request, M2C_TaskNoticeResponse response, Action reply)
        {
            unit.GetComponent<TaskComponent>().OnTaskNotice(request);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
