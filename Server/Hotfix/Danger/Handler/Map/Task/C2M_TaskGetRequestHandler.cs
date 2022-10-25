using System;

namespace ET
{ 

    [ActorMessageHandler]
    public class C2M_TaskGetRequestHandler : AMActorLocationRpcHandler<Unit, C2M_TaskGetRequest, M2C_TaskGetResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskGetRequest request, M2C_TaskGetResponse response, Action reply)
        {
            bool value =  unit.GetComponent<TaskComponent>().OnGetTask(request, response);
            response.Error = value ? ErrorCore.ERR_Success : ErrorCore.ERR_TaskCanNotGet;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
