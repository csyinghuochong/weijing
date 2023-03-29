using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanPlanOpenHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPlanOpenRequest, M2C_JiaYuanPlanOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPlanOpenRequest request, M2C_JiaYuanPlanOpenResponse response, Action reply)
        {
            List<int> PlanOpenList_2 = unit.GetComponent<JiaYuanComponent>().PlanOpenList_3;
            if (PlanOpenList_2.Contains(request.CellIndex))
            {
                response.PlanOpenList = PlanOpenList_2; 
                reply();
                return;
            }
            int costNumber = ConfigHelper.JiaYuanFarmOpen[request.CellIndex];
            if (!unit.GetComponent<BagComponent>().CheckCostItem($"13;{costNumber}"))
            {
                response.PlanOpenList = PlanOpenList_2;
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            PlanOpenList_2.Add(request.CellIndex);
            unit.GetComponent<BagComponent>().OnCostItemData($"13;{costNumber}");

            response.PlanOpenList = PlanOpenList_2;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
