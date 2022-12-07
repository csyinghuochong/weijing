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
            int itemNumber = activityConfig.Par_2.Split('@').Length;

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetSpaceNumber() <= itemNumber)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.RechargeSign) != 1)
            {
                response.Error = ErrorCore.ERR_TaskCanNotGet;
                reply();
                return;
            }

            Log.Debug($"充值签到成功1：{unit.Id} { bagComponent.GetItemNumber(10010043)}");
            numericComponent.ApplyValue(NumericType.RechargeSign, 2);
            unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_2, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
            Log.Debug($"充值签到成功2：{unit.Id} { bagComponent.GetItemNumber(10010043)}");
    
            reply();
            await ETTask.CompletedTask;
        }
    }
}
