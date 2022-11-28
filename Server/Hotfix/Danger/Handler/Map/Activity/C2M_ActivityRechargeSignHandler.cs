using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityRechargeSignHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityRechargeSignRequest, M2C_ActivityRechargeSignResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityRechargeSignRequest request, M2C_ActivityRechargeSignResponse response, Action reply)
        {
            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(request.ActivityId);
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.RechargeSign) == 1)
            {
                numericComponent.ApplyValue(NumericType.RechargeSign, 2);
                unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_2, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
            }
            else
            {
                response.Error = ErrorCore.ERR_CanNotGet;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
