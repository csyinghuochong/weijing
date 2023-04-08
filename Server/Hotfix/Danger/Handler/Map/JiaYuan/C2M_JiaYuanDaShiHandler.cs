using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanDaShiHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanDaShiRequest, M2C_JiaYuanDaShiResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanDaShiRequest request, M2C_JiaYuanDaShiResponse response, Action reply)
        {

            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
