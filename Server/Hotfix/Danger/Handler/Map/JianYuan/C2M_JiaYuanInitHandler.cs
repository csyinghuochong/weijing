using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanInitRequest, M2C_JiaYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanInitRequest request, M2C_JiaYuanInitResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            jiaYuanComponent.OvertimeCheck();
            await DBHelper.SaveComponent(unit.DomainZone(), unit.Id, jiaYuanComponent);
            if (unit.Id != request.UnitId)
            {
                jiaYuanComponent = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.UnitId);
            }

            response.PlanOpenList = jiaYuanComponent.InitOpenList();
            response.PurchaseItemList = jiaYuanComponent.PurchaseItemList_7;
            response.LearnMakeIds = jiaYuanComponent.LearnMakeIds_7;
            response.JiaYuanPastureList = jiaYuanComponent.JiaYuanPastureList_7;
            response.JiaYuanProList = jiaYuanComponent.JiaYuanProList_7;
            reply();
        }
    }
}
