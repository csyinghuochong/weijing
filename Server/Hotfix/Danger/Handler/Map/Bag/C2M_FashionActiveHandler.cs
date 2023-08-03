using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_FashionActiveHandler : AMActorLocationRpcHandler<Unit, C2M_FashionActiveRequest, M2C_FashionActiveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FashionActiveRequest request, M2C_FashionActiveResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
