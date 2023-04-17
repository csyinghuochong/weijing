using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskCommitRequestHandler : AMActorLocationRpcHandler<Unit, C2M_TaskCommitRequest, M2C_TaskCommitResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskCommitRequest request, M2C_TaskCommitResponse response, Action reply)
        {
            if (!TaskConfigCategory.Instance.Contain(request.TaskId))
            {
                reply();
                return;
            }

            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
            response.Error = taskComponent.OnCommitTask(request.TaskId);
            response.RoleComoleteTaskList = taskComponent.RoleComoleteTaskList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
