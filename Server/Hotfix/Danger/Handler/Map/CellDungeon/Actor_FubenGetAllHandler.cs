
using System;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_FubenGetAllHandler : AMActorLocationRpcHandler<Unit, Actor_GetFubenInfoRequest, Actor_GetFubenInfoResponse>
    {

        protected override async ETTask Run(Unit unit, Actor_GetFubenInfoRequest request, Actor_GetFubenInfoResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
