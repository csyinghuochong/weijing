using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_BuChangeRequestHandler : AMActorLocationRpcHandler<Unit, C2M_BuChangeRequest, M2C_BuChangeResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_BuChangeRequest request, M2C_BuChangeResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            

            reply();
            await ETTask.CompletedTask;
        }
    }
}
