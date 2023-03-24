using System;
using System.Collections.Generic;

namespace ET
{

    //藏宝图
    [ActorMessageHandler]
    public class C2M_ItemTreasureOpenHandler : AMActorLocationRpcHandler<Unit, C2M_ItemTreasureOpenRequest, M2C_ItemTreasureOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemTreasureOpenRequest request, M2C_ItemTreasureOpenResponse response, Action reply)
        {
            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
            if (useBagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemUseError;
                reply();
                return;
            }

            if (useBagInfo.HideProLists.Count > 0)
            {
                response.ReardItem = new RewardItem() { ItemID = useBagInfo.HideProLists[0].HideID, ItemNum = (int)useBagInfo.HideProLists[0].HideValue };
                reply();
                return;
            }

            //40006@TaskMove_6@10010071;1
            string rewardItemStr = useBagInfo.ItemPar.Split('@')[2];
            List<RewardItem> rewardItems = ItemHelper.GetRewardItems(rewardItemStr);
            
            response.ReardItem = rewardItems[0];
            useBagInfo.HideProLists.Clear();
            useBagInfo.HideProLists.Add(new HideProList() { HideID = rewardItems[0].ItemID, HideValue = rewardItems[0].ItemNum });
            reply();
            await ETTask.CompletedTask;
        }
    }
}
