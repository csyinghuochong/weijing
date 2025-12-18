using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityOrderOperateHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityOrderOperateRequest, M2C_ActivityOrderOperateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityOrderOperateRequest request, M2C_ActivityOrderOperateResponse response, Action reply)
        {
            BagComponent bagComponent  = unit.GetComponent<BagComponent>(); 
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();

            switch (request.OperatateType)
            {
                case 1:
                    if (!bagComponent.CheckCostItem(ActivityConfigHelper.ActivityOrderRefreshItem))
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }

                    bagComponent.OnCostItemData(ActivityConfigHelper.ActivityOrderRefreshItem, ItemLocType.ItemLocBag, ItemGetWay.Activity);
                    activityComponent.ActivityV1Info.OrderId = ActivityConfigHelper.GenerateActivityOrderId();
                    activityComponent.ActivityV1Info.OrderLastFefreshTime = TimeHelper.ServerNow();

                    break;
                case 2:
                    int orderId = activityComponent.ActivityV1Info.OrderId;
                    if (orderId < 0 || orderId >= ActivityConfigHelper.ActivityOrderItemList.Count)
                    {
                        response.Error = ErrorCode.ERR_Parameter;
                        reply();
                        return;
                    }
                    ActivityOrderItem activityOrderItem = ActivityConfigHelper.ActivityOrderItemList[orderId];
                   
                    if (!bagComponent.CheckCostItem(activityOrderItem.Give))
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }

                    int needcell = ItemHelper.GetNeedCell(activityOrderItem.Get);
                    if (bagComponent.GetBagLeftCell() < needcell)
                    {
                        response.Error = ErrorCode.ERR_BagIsFull;
                        reply();
                        return;
                    }

                    bagComponent.OnCostItemData(activityOrderItem.Give, ItemLocType.ItemLocBag, ItemGetWay.Activity);
                    bagComponent.OnAddItemData(activityOrderItem.Get, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                    activityComponent.ActivityV1Info.OrderId = ActivityConfigHelper.GenerateActivityOrderId();
                    activityComponent.ActivityV1Info.OrderLastFefreshTime = TimeHelper.ServerNow();
                    break;
            }

            response.ActivityV1Info = activityComponent.ActivityV1Info;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
