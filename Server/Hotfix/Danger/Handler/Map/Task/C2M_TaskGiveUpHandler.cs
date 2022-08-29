
using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskGiveUpHandler : AMActorLocationRpcHandler<Unit, C2M_TaskGiveUpRequest, M2C_TaskGiveUpResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TaskGiveUpRequest request, M2C_TaskGiveUpResponse response, Action reply)
        {
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
            taskComponent.OnRecvGiveUpTask(request.TaskId);
            reply();
            await ETTask.CompletedTask;
        }

    }
}
