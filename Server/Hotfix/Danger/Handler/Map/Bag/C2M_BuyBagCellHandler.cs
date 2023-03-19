using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_BuyBagCellHandler : AMActorLocationRpcHandler<Unit, C2M_BuyBagCellRequest, M2C_BuyBagCellResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_BuyBagCellRequest request, M2C_BuyBagCellResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetTotalSpace() >= GlobalValueConfigCategory.Instance.BagMaxCell)
            {
                reply();
                return;
            }
            string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            if (!bagComponent.CheckCostItem(costitems))
            {
                response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                reply();
                return;
            }

            bagComponent.OnCostItemData(costitems);
            bagComponent.AddedCellNumber += 1;
            response.AddedCellNumber = bagComponent.AddedCellNumber;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
