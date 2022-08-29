using System;

namespace ET
{ 

    [ActorMessageHandler]
    public class C2M_TaskGetRequestHandler : AMActorLocationRpcHandler<Unit, C2M_GetTaskRequest, M2C_GetTaskResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_GetTaskRequest request, M2C_GetTaskResponse response, Action reply)
        {
            bool value =  unit.GetComponent<TaskComponent>().OnGetTask(request, response);
            response.Error = value ? ErrorCore.ERR_Success : ErrorCore.ERR_TaskCanNotGet;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
