using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskCommitRequestHandler : AMActorLocationRpcHandler<Unit, C2M_CommitTaskRequest, M2C_CommitTaskResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_CommitTaskRequest request, M2C_CommitTaskResponse response, Action reply)
        {
            response.Error = unit.GetComponent<TaskComponent>().OnCommitTask(request.TaskId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
