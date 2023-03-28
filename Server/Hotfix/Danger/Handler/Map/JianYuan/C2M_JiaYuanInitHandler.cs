using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanInitRequest, M2C_JiaYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanInitRequest request, M2C_JiaYuanInitResponse response, Action reply)
        {
            List<int> PlanOpenList_2 = unit.GetComponent<JiaYuanComponent>().PlanOpenList_2;
            if (!PlanOpenList_2.Contains(0))
            {
                PlanOpenList_2.AddRange(new List<int>() {0,1,2,3,4 });
            }
            response.PlanOpenList = PlanOpenList_2;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
