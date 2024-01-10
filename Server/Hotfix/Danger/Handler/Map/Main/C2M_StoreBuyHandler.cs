using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_StoreBuyHandler : AMActorLocationRpcHandler<Unit, C2M_StoreBuyRequest, M2C_StoreBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_StoreBuyRequest request, M2C_StoreBuyResponse response, Action reply)
        {
            if (!StoreSellConfigCategory.Instance.Contain(request.SellItemID))
            {
                reply();
                return;
            }

            StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(request.SellItemID);
            if (storeSellConfig == null)
            {
                response.Error = ErrorCode.ERR_NetWorkError;
                reply();
                return;
            }
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            //购买限制
            if (request.SellItemNum <= 0) {
                request.SellItemNum = 1;
            }

            if (request.SellItemNum >= 100)
            {
                request.SellItemNum = 100;
            }

            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            List<RewardItem> rewardItems = new List<RewardItem>();
            rewardItems.Add(new RewardItem() { ItemID = storeSellConfig.SellItemID, ItemNum = storeSellConfig.SellItemNum * request.SellItemNum });

            int costType = storeSellConfig.SellType;
            string costValue = (-1 * storeSellConfig.SellValue * request.SellItemNum).ToString();

            switch (costType)
            {
                case 1:
                    if (userInfo.Gold < storeSellConfig.SellValue * request.SellItemNum)
                    {
                        response.Error = ErrorCode.ERR_GoldNotEnoughError;
                    }
                    else
                    {
                        unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, costValue);
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.StoreBuy}_{TimeHelper.ServerNow()}");
                        response.Error = ErrorCode.ERR_Success;
                    }
                    break;
                case 3:
                    if (userInfo.Diamond < storeSellConfig.SellValue * request.SellItemNum)
                    {
                        response.Error = ErrorCode.ERR_DiamondNotEnoughError;
                    }
                    else
                    {
                        unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Diamond, costValue, true, ItemGetWay.CostItem);
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.StoreBuy}_{TimeHelper.ServerNow()}");
                        response.Error = ErrorCode.ERR_Success;
                    }
                    break;
                default:
                    if (unit.GetComponent<BagComponent>().GetItemNumber(costType) < storeSellConfig.SellValue * request.SellItemNum)
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    }
                    else
                    {
                        unit.GetComponent<BagComponent>().OnCostItemData($"{costType};{storeSellConfig.SellValue * request.SellItemNum}");
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.StoreBuy}_{TimeHelper.ServerNow()}");
                    }
                    break;
            }

            reply();

            await ETTask.CompletedTask;
        }
    }
}
