using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemFumoProHandler : AMActorLocationRpcHandler<Unit, C2M_ItemFumoProRequest, M2C_ItemFumoProResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemFumoProRequest request, M2C_ItemFumoProResponse response, Action reply)
        {
            int FumoItemId = unit.GetComponent<BagComponent>().FumoItemId;
            if (FumoItemId == 0)
            {
                response.Error = ErrorCore.ERR_ItemNotExist;
                reply();
                return;
            }
            unit.GetComponent<BagComponent>().OnEquipFuMo(FumoItemId, request.Index);
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.FoMoNumber_213, 0, 1);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
