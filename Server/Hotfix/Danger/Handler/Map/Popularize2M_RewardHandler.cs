using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Popularize2M_RewardHandler : AMActorRpcHandler<Unit, Popularize2M_RewardRequest, M2Popularize_RewardResponse>
    {
        protected override async ETTask Run(Unit unit, Popularize2M_RewardRequest request, M2Popularize_RewardResponse response, Action reply)
        {
            Log.Debug("111");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
