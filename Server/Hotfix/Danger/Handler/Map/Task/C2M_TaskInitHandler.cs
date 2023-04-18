using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskInitHandler : AMActorLocationRpcHandler<Unit, C2M_TaskInitRequest, M2C_TaskInitResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskInitRequest request, M2C_TaskInitResponse response, Action reply)
        {
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();

            response.RoleTaskList = taskComponent.RoleTaskList;
            response.CampTaskList = taskComponent.CampTaskList;
            response.RoleComoleteTaskList = taskComponent.RoleComoleteTaskList;
            response.ReceiveHuoYueIds = taskComponent.ReceiveHuoYueIds;
            response.TaskCountryList = taskComponent.TaskCountryList;
            LogHelper.LogDebug($"登录获取任务:  {unit.Id} {unit.DomainZone()} {taskComponent.TaskCountryList.Count}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
