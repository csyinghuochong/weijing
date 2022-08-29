using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_StoreBuyHandler : AMActorLocationRpcHandler<Unit, C2M_StoreBuyRequest, M2C_StoreBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_StoreBuyRequest request, M2C_StoreBuyResponse response, Action reply)
        {
            StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(request.SellItemID);
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            List<RewardItem> rewardItems = new List<RewardItem>();
            rewardItems.Add(new RewardItem() { ItemID = storeSellConfig.SellItemID, ItemNum = storeSellConfig.SellItemNum });

            int costType = storeSellConfig.SellType;
            string costValue = (-1 * storeSellConfig.SellValue).ToString();

            switch (costType)
            {
                case 1:
                    if (userInfo.Gold < storeSellConfig.SellValue)
                    {
                        response.Error = ErrorCore.ERR_GoldNotEnoughError;
                    }
                    else
                    {
                        unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, costValue).Coroutine();
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItems,0, 1);
                        response.Error = ErrorCore.ERR_Success;
                    }
                    break;
                case 3:
                    if (userInfo.Diamond < storeSellConfig.SellValue)
                    {
                        response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                    }
                    else
                    {
                        unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, costValue).Coroutine();
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, 0, 1);
                        response.Error = ErrorCore.ERR_Success;
                    }
                    break;
                default:

                    if (unit.GetComponent<BagComponent>().GetItemNumber(costType) < storeSellConfig.SellValue)
                    {
                        response.Error = ErrorCore.ERR_ItemNotEnoughError;
                    }
                    else
                    {
                        unit.GetComponent<BagComponent>().OnCostItemData($"{costType};{storeSellConfig.SellValue}");
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, 0, 1);
                    }
                    break;
            }

            reply();

            await ETTask.CompletedTask;
        }
    }
}
