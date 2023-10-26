using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_WelfareDrawRewardHandler : AMActorLocationRpcHandler<Unit, C2M_WelfareDrawRewardRequest, M2C_WelfareDrawRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareDrawRewardRequest request, M2C_WelfareDrawRewardResponse response, Action reply)
        {
            int index = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.DrawIndex);
            if (index == 0 || index >= ConfigHelper.WelfareDrawList.Count)
            {
                reply();
                return;
            }

            string reward = ConfigHelper.WelfareDrawList[index - 1].Value;
            unit.GetComponent<BagComponent>().OnAddItemData(  reward, $"{ItemGetWay.Welfare}_{TimeHelper.ServerNow()}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
