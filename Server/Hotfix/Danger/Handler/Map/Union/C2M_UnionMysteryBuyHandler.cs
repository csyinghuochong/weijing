using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionMysteryBuyHandler : AMActorLocationRpcHandler<Unit, C2M_UnionMysteryBuyRequest, M2C_UnionMysteryBuyResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_UnionMysteryBuyRequest request, M2C_UnionMysteryBuyResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Buy, unit.Id))
            {
                long unionid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
                if (unionid == 0)
                {
                    response.Error = ErrorCore.ERR_NetWorkError;
                    reply();
                    return;
                }

                int mysteryId = request.MysteryId;
                MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mysteryId);
                if (mysteryConfig == null)
                {
                    response.Error = ErrorCore.ERR_NetWorkError;
                    reply();
                    return;
                }
                if (unit.GetComponent<UserInfoComponent>().GetMysteryBuy(mysteryId) >= mysteryConfig.BuyNumMax)
                {
                    response.Error = ErrorCore.ERR_MysteryItem_Max;
                    reply();
                    return;
                }
                if (!unit.GetComponent<BagComponent>().CheckCostItem($"{mysteryConfig.SellType};{mysteryConfig.SellValue}"))
                {
                    response.Error = ErrorCore.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
                request.BuyNumber = 1;
                long unionServerId = DBHelper.GetUnionServerId(unit.DomainZone());
                U2M_UnionMysteryBuyResponse r_GameStatusResponse = (U2M_UnionMysteryBuyResponse)await ActorMessageSenderComponent.Instance.Call
                    (unionServerId, new M2U_UnionMysteryBuyRequest()
                    {
                        MysteryId = mysteryId,  
                        BuyNumber = request.BuyNumber,
                        UnionId = unionid
                    });

                if (r_GameStatusResponse.Error != ErrorCore.ERR_Success)
                {
                    response.Error = r_GameStatusResponse.Error;
                    reply();
                    return;
                }

                LogHelper.LogWarning($"家族神秘商人购买道具: {unit.DomainZone()} {unit.Id} {mysteryId}");
                unit.GetComponent<UserInfoComponent>().OnMysteryBuy(mysteryId);
                unit.GetComponent<BagComponent>().OnCostItemData($"{mysteryConfig.SellType};{mysteryConfig.SellValue}");
                unit.GetComponent<BagComponent>().OnAddItemData($"{mysteryConfig.SellItemID};{1}",
                    $"{ItemGetWay.UnionMysteryBuy}_{TimeHelper.ServerNow()}");
                reply();
            }
        }
    }
}
