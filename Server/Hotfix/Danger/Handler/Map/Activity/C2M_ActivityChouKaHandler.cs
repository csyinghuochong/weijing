using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityChouKaHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityChouKaRequest, M2C_ActivityChouKaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityChouKaRequest request, M2C_ActivityChouKaResponse response, Action reply)
        {
            Log.Error($"C2M_ActivityChouKaRequest活动作弊:{unit.DomainZone()}  {unit.Id}");
            if (unit.DomainZone()!=0)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            if (!bagComponent.CheckCostItem(ActivityConfigHelper.ChouKaCostItem))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyChange( null,NumericType.V1ChouKaNumber, 1, 0 );

            int dropId = ActivityConfigHelper.ChouKaDropId[0];
            ServerInfoComponent serverInfoComponent = unit.DomainScene().GetComponent<ServerInfoComponent>();
            if (serverInfoComponent != null)
            {
                dropId = serverInfoComponent.ServerInfo.ChouKaDropId;
            }

            List<RewardItem> rewardItems = new List<RewardItem>();  
            DropHelper.DropIDToDropItem_2(dropId, rewardItems);
            bagComponent.OnCostItemData(ActivityConfigHelper.ChouKaCostItem,  ItemLocType.ItemLocBag, ItemGetWay.Activity);
            bagComponent.OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.ActivityChouKa}_{TimeHelper.ServerNow()}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
