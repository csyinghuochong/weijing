using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PointChouKaRewardHandler : AMActorLocationRpcHandler<Unit, C2M_PointChouKaRewardRequest, M2C_PointChouKaRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_PointChouKaRewardRequest request, M2C_PointChouKaRewardResponse response, Action reply)
        {

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            int choukaindex = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1PointsChouKaIndex);
            if (choukaindex <= 0 || choukaindex > ActivityConfigHelper.PointsChouKaList.Count)
            {
                response.Error = ErrorCode.ERR_Parameter;
                reply();
                return;
            }

            string itmeinfo = ActivityConfigHelper.PointsChouKaList[choukaindex - 1].ItemInfo;
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.V1PointsChouKaIndex, 0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData( UserDataType.V1TotalPoints, "-200");
            unit.GetComponent<BagComponent>().OnAddItemData(itmeinfo, $"{ItemGetWay.ActivityChouKa}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
