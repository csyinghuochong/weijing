using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TaskOnLoginHandler: AMActorLocationRpcHandler<Unit, C2M_TaskOnLoginRequest, M2C_TaskOnLoginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TaskOnLoginRequest request, M2C_TaskOnLoginResponse response, Action reply)
        {
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
            taskComponent.OnLogin();
            reply();
            await ETTask.CompletedTask;
        }
    }
}