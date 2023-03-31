using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanInitRequest, M2C_JiaYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanInitRequest request, M2C_JiaYuanInitResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            response.PlanOpenList = jiaYuanComponent.InitOpenList();
            response.PurchaseItemList = jiaYuanComponent.PurchaseItemList_5;
            response.LearnMakeIds = jiaYuanComponent.LearnMakeIds_5;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
