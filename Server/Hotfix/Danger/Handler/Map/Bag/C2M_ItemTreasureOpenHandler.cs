using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemTreasureOpenHandler : AMActorLocationRpcHandler<Unit, C2M_ItemTreasureOpenRequest, M2C_ItemTreasureOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemTreasureOpenRequest request, M2C_ItemTreasureOpenResponse response, Action reply)
        {
            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
            if (useBagInfo == null || !string.IsNullOrEmpty(useBagInfo.ItemPar))
            {
                response.Error = ErrorCore.ERR_ItemUseError;
                reply();
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
            int dropId = int.Parse(itemConfig.ItemUsePar);

            List<RewardItem> rewardItems = new List<RewardItem>();  
            DropHelper.DropIDToDropItem_2(dropId, rewardItems);
            if (rewardItems.Count == 0)
            {
                response.Error = ErrorCore.ERR_ItemUseError;
                reply();
                return;
            }

            response.ReardItem = rewardItems[0];
            useBagInfo.ItemPar = $"{rewardItems[0].ItemID};{rewardItems[0].ItemNum}";
            reply();
            await ETTask.CompletedTask;
        }
    }
}
