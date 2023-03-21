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

                bagComponent.WarehouseAddedCell[request.OperateType - 5] += 1;
            }

            bagComponent.OnCostItemData(costitems);
            response.WarehouseAddedCell = bagComponent.WarehouseAddedCell;
            response.BagAddedCell = bagComponent.BagAddedCell;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
