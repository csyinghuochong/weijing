using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ReddotReadHandler : AMActorLocationRpcHandler<Unit, C2M_ReddotReadRequest, M2C_ReddotReadResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ReddotReadRequest request, M2C_ReddotReadResponse response, Action reply)
        {
            unit.GetComponent<ReddotComponent>().RemoveReddont(request.ReddotType);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
