using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TianFuPlanHandler : AMActorLocationRpcHandler<Unit, C2M_TianFuPlanRequest, M2C_TianFuPlanResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TianFuPlanRequest request, M2C_TianFuPlanResponse response, Action reply)
        {
            SkillSetComponent skillSetComponent = unit.GetComponent<SkillSetComponent>();
            skillSetComponent.UpdateTianFuPlan ( request.TianFuPlan);  

            reply();
            await ETTask.CompletedTask;
        }
    }
}
