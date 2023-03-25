using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanMysteryBuyHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanMysteryBuyRequest, M2C_JiaYuanMysteryBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanMysteryBuyRequest request, M2C_JiaYuanMysteryBuyResponse response, Action reply)
        {
            int mysteryId = request.MysteryItemInfo.MysteryId;
            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mysteryId);
            if (mysteryConfig == null)
            {
                response.Error = ErrorCore.ERR_NetWorkError;
                reply();
                return;
            }

            if (!unit.GetComponent<BagComponent>().CheckCostItem($"{mysteryConfig.SellType};{mysteryConfig.SellValue}"))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            request.MysteryItemInfo.ItemID = mysteryConfig.SellItemID;
            request.MysteryItemInfo.ItemNumber = 1;
            int errorCode = unit.GetComponent<JiaYuanComponent>().OnMysteryBuyRequest(request.MysteryItemInfo);
            if (errorCode != ErrorCore.ERR_Success)
            {
                response.Error = errorCode;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().OnMysteryBuy(mysteryId);
            unit.GetComponent<BagComponent>().OnCostItemData($"{mysteryConfig.SellType};{mysteryConfig.SellValue}");
            unit.GetComponent<BagComponent>().OnAddItemData($"{mysteryConfig.SellItemID};1",
                $"{ItemGetWay.MysteryBuy}_{TimeHelper.ServerNow()}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
