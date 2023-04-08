using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanPlanOpenHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPlanOpenRequest, M2C_JiaYuanPlanOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPlanOpenRequest request, M2C_JiaYuanPlanOpenResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            List<int> PlanOpenList_2 = jiaYuanComponent.PlanOpenList_7;
            if (PlanOpenList_2.Contains(request.CellIndex))
            {
                response.PlanOpenList = PlanOpenList_2; 
                reply();
                return;
            }
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfoComponent.UserInfo.JiaYuanLv);
            if (jiaYuanComponent.GetOpenPlanNumber() >= jiaYuanConfig.FarmNumMax)
            {
                response.Error = ErrorCore.ERR_JiaYuanLevel;
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
            response.PlanOpenList = PlanOpenList_2;
            unit.GetComponent<BagComponent>().OnCostItemData($"13;{costNumber}");
            unit.GetComponent<DBSaveComponent>().UpdateCacheDB();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
