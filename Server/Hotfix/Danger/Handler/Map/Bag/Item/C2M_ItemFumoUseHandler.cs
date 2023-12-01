using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemFumoUseHandler : AMActorLocationRpcHandler<Unit, C2M_ItemFumoUseRequest, M2C_ItemFumoUseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemFumoUseRequest request, M2C_ItemFumoUseResponse response, Action reply)
        {
            long bagInfoID = request.OperateBagID;
            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, bagInfoID);
            if (useBagInfo == null)
            {
                unit.GetComponent<BagComponent>().FuMoItemId = 0;
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            unit.GetComponent<BagComponent>().OnCostItemData(bagInfoID, 1);
            unit.GetComponent<BagComponent>().FuMoItemId = useBagInfo.ItemID;
            unit.GetComponent<BagComponent>().FuMoProList = request.FuMoProList;
            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.FoMoNumber_213, 0, 1);

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);

            unit.GetComponent<TaskComponent>().TriggerTaskEvent( TaskTargetType.FuMoQulity_41, itemConfig.ItemQuality, 1 );
            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.FuMoQulity_41, itemConfig.ItemQuality, 1);
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
