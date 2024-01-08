using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemBuyCellHandler : AMActorLocationRpcHandler<Unit, C2M_ItemBuyCellRequest, M2C_ItemBuyCellResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemBuyCellRequest request, M2C_ItemBuyCellResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            //string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            //if (!bagComponent.CheckCostItem(costitems))
            //{
            //    response.Error = ErrorCode.ERR_DiamondNotEnoughError;
            //    reply();
            //    return;
            //}

            if (request.OperateType == (int)ItemLocType.ItemLocBag)
            {
                if (bagComponent.GetTotalSpace() >= GlobalValueConfigCategory.Instance.BagMaxCell)
                {
                    response.Error = ErrorCode.ERR_AleardyMaxCell;
                    reply();
                    return;
                }
                BuyCellCost buyCellCost = ConfigHelper.BuyBagCellCosts[bagComponent.BagAddedCell];
                if (!bagComponent.OnCostItemData(buyCellCost.Cost))
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }


                string[] iteminfo = buyCellCost.Get.Split(';');
                response.GetItem = buyCellCost.Get;
                bagComponent.BagAddedCell += 1;

                RewardItem rewardItem = new RewardItem()
                {
                    ItemID = int.Parse(iteminfo[0]),
                    ItemNum = int.Parse(iteminfo[1]),
                };
                List<RewardItem> rewardItems = new List<RewardItem>() { rewardItem };
                bagComponent.OnAddItemData(rewardItems, String.Empty, $"{ItemGetWay.CostItem}_{TimeHelper.ServerNow()}", true, false, (ItemLocType)request.OperateType);
            }
            else if (request.OperateType == (int)ItemLocType.GemWareHouse1)
            {
                Log.Console("还没有购买格子的需求！");
            }
            else
            {
                if (bagComponent.GetStoreTotalCell(request.OperateType) >= GlobalValueConfigCategory.Instance.StoreMaxCell)
                {
                    response.Error = ErrorCode.ERR_AleardyMaxCell;
                    reply();
                    return;
                }

                int storeindex = request.OperateType - 5;
                int addcell = bagComponent.WarehouseAddedCell[storeindex];
                BuyCellCost buyCellCost = ConfigHelper.BuyStoreCellCosts[storeindex * 10 + addcell];
                if (!bagComponent.OnCostItemData(buyCellCost.Cost))
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }

                string[] iteminfo = buyCellCost.Get.Split(';');
                response.GetItem = buyCellCost.Get;
                bagComponent.WarehouseAddedCell[storeindex] += 1;

                RewardItem rewardItem = new RewardItem()
                {
                    ItemID = int.Parse(iteminfo[0]),
                    ItemNum = int.Parse(iteminfo[1]),
                };
                List<RewardItem> rewardItems = new List<RewardItem>() { rewardItem };
                bagComponent.OnAddItemData(rewardItems, String.Empty, $"{ItemGetWay.CostItem}_{TimeHelper.ServerNow()}", true, false, (ItemLocType)request.OperateType);
            }

            response.WarehouseAddedCell = bagComponent.WarehouseAddedCell;
            response.BagAddedCell = bagComponent.BagAddedCell;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
