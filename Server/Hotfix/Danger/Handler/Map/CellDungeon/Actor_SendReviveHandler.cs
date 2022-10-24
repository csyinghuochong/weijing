using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_SendReviveHandler : AMActorLocationRpcHandler<Unit, Actor_SendReviveRequest, Actor_SendReviveResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_SendReviveRequest request, Actor_SendReviveResponse response, Action reply)
        {
            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            bool success = unit.GetComponent<BagComponent>().OnCostItemData(reviveCost);

            if (success)
            {
                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                numericComponent.ApplyValue(NumericType.Born_X, (long)(unit.Position.x * 10000));
                numericComponent.ApplyValue(NumericType.Born_Y, (long)(unit.Position.y * 10000));
                numericComponent.ApplyValue(NumericType.Born_Z, (long)(unit.Position.z * 10000));
                unit.GetComponent<HeroDataComponent>().OnRevive();
                unit.GetComponent<ChengJiuComponent>().OnRevive();
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
