using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemOneSellHandler : AMActorLocationRpcHandler<Unit, C2M_ItemOneSellRequest, M2C_ItemOneSellResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemOneSellRequest request, M2C_ItemOneSellResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
