using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_WelfareInvestRewardHandler : AMActorLocationRpcHandler<Unit, C2M_WelfareInvestRewardRequest, M2C_WelfareInvestRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareInvestRewardRequest request, M2C_WelfareInvestRewardResponse response, Action reply)
        {
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
