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
            string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            if (!bagComponent.CheckCostItem(costitems))
            {
                response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                reply();
                return;
            }


            if (request.OperateType == (int)ItemLocType.ItemLocBag)
            {
                if (bagComponent.GetTotalSpace() >= GlobalValueConfigCategory.Instance.BagMaxCell)
                {
                    response.Error = ErrorCore.ERR_AleardyMaxCell;
                    reply();
                    return;
                }

                bagComponent.OnCostItemData(costitems);


                bagComponent.BagAddedCell += 1;
            }
            else
            {
                if (bagComponent.GetStoreTotalCell(request.OperateType) >= GlobalValueConfigCategory.Instance.StoreMaxCell)
                {
                    response.Error = ErrorCore.ERR_AleardyMaxCell;
                    reply();
                    return;
                }

                int storeindex = request.OperateType - 5;
                bagComponent.OnCostItemData(costitems);
                int addcell = bagComponent.WarehouseAddedCell[storeindex];
                BuyCellCost buyCellCost = ConfigHelper.BuyStoreCellCosts[storeindex * 10 + addcell];
                string[] iteminfo = buyCellCost.Get.Split(';');
                bagComponent.WarehouseAddedCell[storeindex] += 1;
                bagComponent.OnAddItemToStore(request.OperateType, int.Parse(iteminfo[0]), int.Parse(iteminfo[1]), $"{ItemGetWay.CostItem}_{TimeHelper.ServerNow()}");
            }

            response.WarehouseAddedCell = bagComponent.WarehouseAddedCell;
            response.BagAddedCell = bagComponent.BagAddedCell;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
