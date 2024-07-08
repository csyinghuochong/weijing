using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetEggDuiHuanHandler : AMActorLocationRpcHandler<Unit, C2M_PetEggDuiHuanRequest, M2C_PetEggDuiHuanResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetEggDuiHuanRequest request, M2C_PetEggDuiHuanResponse response, Action reply)
        {
            if (!PetEggDuiHuanConfigCategory.Instance.Contain(request.ChouKaId))
            {
                Log.Error($"C2M_PetEggDuiHuanRequest 1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            PetEggDuiHuanConfig config = PetEggDuiHuanConfigCategory.Instance.Get(request.ChouKaId);
            if (unit.GetComponent<BagComponent>().OnCostItemData(config.CostItems, ItemLocType.ItemLocBag, ItemGetWay.PetEggDuiHuan   ))
            {
                List<RewardItem> rewardItems = new List<RewardItem>();
                DropHelper.DropIDToDropItem_2(config.DropID, rewardItems);
                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PetEggDuiHuan}_{TimeHelper.ServerNow()}");
                response.ReardList = rewardItems;   
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
