using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_FubenReviveHandler : AMActorLocationRpcHandler<Unit, Actor_SendReviveRequest, Actor_SendReviveResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_SendReviveRequest request, Actor_SendReviveResponse response, Action reply)
        {
            string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
            bool success = unit.GetComponent<BagComponent>().OnCostItemData(reviveCost);
            if (success)
            {
                unit.GetComponent<HeroDataComponent>().OnRevive();
                unit.GetComponent<ChengJiuComponent>().OnRevive();
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
