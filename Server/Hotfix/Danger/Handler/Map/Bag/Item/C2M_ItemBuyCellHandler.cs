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
                if (bagComponent.GetBagTotalCell() >= GlobalValueConfigCategory.Instance.BagMaxCell)
                {
                    response.Error = ErrorCode.ERR_AleardyMaxCell;
                    reply();
                    return;
                }
                BuyCellCost buyCellCost = ConfigHelper.BuyBagCellCosts[bagComponent.WarehouseAddedCell[0]];
                if (!bagComponent.OnCostItemData(buyCellCost.Cost))
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }


                string[] iteminfo = buyCellCost.Get.Split(';');
                response.GetItem = buyCellCost.Get;
                bagComponent.WarehouseAddedCell[0] += 1;

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
                int storeindex = request.OperateType;
                if (storeindex < 5 || storeindex > 9)
                {
                    response.Error = ErrorCode.ERR_ModifyData;
                    reply();
                    return;
                }


                if (bagComponent.GetHourseTotalCell(request.OperateType) >= GlobalValueConfigCategory.Instance.StoreMaxCell)
                {
                    response.Error = ErrorCode.ERR_AleardyMaxCell;
                    reply();
                    return;
                }
                
                int addcell = bagComponent.WarehouseAddedCell[storeindex];
                BuyCellCost buyCellCost = ConfigHelper.BuyStoreCellCosts[(storeindex - 5) * 10 + addcell];
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
            //response.BagAddedCell = bagComponent.BagAddedCell;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
