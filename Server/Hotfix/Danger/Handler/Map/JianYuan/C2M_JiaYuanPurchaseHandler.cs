using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPurchaseHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPurchaseRequest, M2C_JiaYuanPurchaseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPurchaseRequest request, M2C_JiaYuanPurchaseResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
