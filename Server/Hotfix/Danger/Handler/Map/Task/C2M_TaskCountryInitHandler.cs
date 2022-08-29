using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskCountryInitHandler : AMActorLocationRpcHandler<Unit, C2M_TaskCountryInitRequest, M2C_TaskCountryInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TaskCountryInitRequest request, M2C_TaskCountryInitResponse response, Action reply)
        {
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
            response.TaskCountryList = taskComponent.TaskCountryList;
            response.ReceiveHuoYueIds = taskComponent.ReceiveHuoYueIds;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
