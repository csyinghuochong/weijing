using System;

namespace ET
{ 

    [ActorMessageHandler]
    public class C2M_TaskGetRequestHandler : AMActorLocationRpcHandler<Unit, C2M_TaskGetRequest, M2C_TaskGetResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskGetRequest request, M2C_TaskGetResponse response, Action reply)
        {
            TaskPro taskPro =  unit.GetComponent<TaskComponent>().OnGetTask(request.TaskId);
            response.Error = taskPro!=null ? ErrorCore.ERR_Success : ErrorCore.ERR_CanNotGet;
            response.TaskPro  = taskPro;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
