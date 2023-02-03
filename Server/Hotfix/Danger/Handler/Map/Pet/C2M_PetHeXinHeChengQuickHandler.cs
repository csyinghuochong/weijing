using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetHeXinHeChengQuickHandler : AMActorLocationRpcHandler<Unit, C2M_PetHeXinHeChengQuickRequest, M2C_PetHeXinHeChengQuickResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetHeXinHeChengQuickRequest request, M2C_PetHeXinHeChengQuickResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            List<BagInfo> allPetHeXin = bagComponent.BagItemPetHeXin;

            List<long> costList = new List<long>();
            List<RewardItem> rewardItems = new List<RewardItem>();  
            Dictionary<int, List<BagInfo>> keyValuePairs = new Dictionary<int, List<BagInfo>>();
            for (int i = 0; i < allPetHeXin.Count; i++)
            {
                BagInfo bagInfo = allPetHeXin[i];   
                if (!keyValuePairs.ContainsKey(bagInfo.ItemID))
                {
                    keyValuePairs.Add(bagInfo.ItemID, new List<BagInfo>());
                }
                keyValuePairs[bagInfo.ItemID].Add(bagInfo);
            }


            //去掉多余的
            foreach (var item in keyValuePairs)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(item.Key);
                if (itemConfig.PetHeXinHeChengID == 0)
                {
                    item.Value.Clear();
                    continue;
                }
                if (keyValuePairs.Count < 2)
                {
                    item.Value.Clear();
                }
                if (item.Value.Count % 2 > 0)
                {
                    item.Value.RemoveAt(item.Value.Count - 1);
                }
            }

            foreach (var item in keyValuePairs)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(item.Key);
    
                int number1 = item.Value.Count / 2;
                //新增item
                for (int n = 0; n < number1; n++)
                {
                    rewardItems.Add( new RewardItem() { ItemID = itemConfig.PetHeXinHeChengID, ItemNum = 1 } );
                }

                //移除item
                for (int n = 0; n < item.Value.Count; n++)
                {
                    costList.Add(item.Value[n].BagInfoID);
                }
            }

            bagComponent.OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PetHeXinHeCheng}_{TimeHelper.ServerNow()}");
            bagComponent.OnCostItemData(costList, ItemLocType.ItemPetHeXinBag);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
