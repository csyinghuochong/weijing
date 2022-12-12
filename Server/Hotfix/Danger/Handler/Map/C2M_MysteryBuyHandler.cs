using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_MysteryBuyHandler : AMActorLocationRpcHandler<Unit, C2M_MysteryBuyRequest, M2C_MysteryBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_MysteryBuyRequest request, M2C_MysteryBuyResponse response, Action reply)
        {
            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(request.MysteryItemInfo.MysteryId);
            if (unit.GetComponent<UserInfoComponent>().GetMysteryBuy(request.MysteryItemInfo.MysteryId) >= mysteryConfig.BuyNumMax)
            {
                response.Error = ErrorCore.ERR_MysteryItem_Max;
                reply();
                return;
            }

            if (!unit.GetComponent<BagComponent>().OnCostItemData($"{mysteryConfig.SellType};{mysteryConfig.SellValue}"))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            long chargeServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
            A2M_MysteryBuyResponse r_GameStatusResponse = (A2M_MysteryBuyResponse)await ActorMessageSenderComponent.Instance.Call
                (chargeServerId, new M2A_MysteryBuyRequest()
                {
                    MysteryItemInfo = request.MysteryItemInfo
                });

            if (r_GameStatusResponse.Error != ErrorCore.ERR_Success)
            {
                response.Error = r_GameStatusResponse.Error;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().OnMysteryBuy(request.MysteryItemInfo);
            unit.GetComponent<BagComponent>().OnAddItemData($"{request.MysteryItemInfo.ItemID};{request.MysteryItemInfo.ItemNumber}",
                $"{ItemGetWay.MysteryBuy}_{TimeHelper.ServerNow()}");

            reply();
        }
    }
}
