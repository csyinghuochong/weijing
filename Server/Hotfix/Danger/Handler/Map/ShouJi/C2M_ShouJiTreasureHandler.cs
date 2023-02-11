using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ShouJiTreasureHandler : AMActorLocationRpcHandler<Unit, C2M_ShouJiTreasureRequest, M2C_ShouJiTreasureResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ShouJiTreasureRequest request, M2C_ShouJiTreasureResponse response, Action reply)
        {
            List<long> huishouList = request.ItemIds;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            for (int i = 0; i < huishouList.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouList[i]);
                if (bagInfo == null)
                {
                    response.Error = ErrorCore.ERR_ItemUseError;
                    reply();
                    return;
                }
            }

            bagComponent.OnCostItemData(huishouList, ItemLocType.ItemLocBag);
            ShoujiComponent shoujiComponent = unit.GetComponent<ShoujiComponent>();
            shoujiComponent.OnShouJiTreasure(request.ShouJiId, request.ItemIds.Count);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
