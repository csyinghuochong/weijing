using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskCommitRequestHandler : AMActorLocationRpcHandler<Unit, C2M_TaskCommitRequest, M2C_TaskCommitResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskCommitRequest request, M2C_TaskCommitResponse response, Action reply)
        {
            response.Error = unit.GetComponent<TaskComponent>().OnCommitTask(request.TaskId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
