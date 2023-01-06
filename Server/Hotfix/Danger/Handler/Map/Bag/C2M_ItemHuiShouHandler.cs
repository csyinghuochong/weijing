using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemHuiShouHandler : AMActorLocationRpcHandler<Unit, C2M_ItemHuiShouRequest, M2C_ItemHuiShouResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ItemHuiShouRequest request, M2C_ItemHuiShouResponse response, Action reply)
        {
            try
            {
                List<long> huishouList = request.OperateBagID;
                BagComponent bagComponent = unit.GetComponent<BagComponent>();

                //回收所得
                Dictionary<int, RewardItem> huishouGet = new Dictionary<int, RewardItem>();

                List<long> bagsList = new List<long>();
                List<long> petHexin = new List<long>();    
                for (int i = 0; i < huishouList.Count; i++)
                {
                    BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouList[i]);
                    if (bagInfo != null)
                    {
                        bagsList.Add(huishouList[i]);
                    }
                    else
                    {
                        bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemPetHeXinBag, huishouList[i]);
                        if (bagInfo != null)
                        {
                            petHexin.Add(huishouList[i]);
                        }
                    }

                    if (bagInfo == null)
                    {
                        continue;  
                    }
                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                    string huishouItem = itemConfig.HuiShouGetItem;
                    if (huishouItem.Length == 0 || string.IsNullOrEmpty(huishouItem))
                    {
                        continue;
                    }
                    string[] itemList = huishouItem.Split(';');
                    for (int k = 0; k < itemList.Length; k++)
                    {
                        string[] itemInfo = itemList[k].Split(',');
                        int itemId = int.Parse(itemInfo[0]);

                        if (huishouGet.ContainsKey(itemId))
                        {
                            huishouGet[itemId].ItemNum += int.Parse(itemInfo[1]) * bagInfo.ItemNum;
                        }
                        else
                        {
                            huishouGet.Add(itemId, new RewardItem() { ItemID = itemId, ItemNum = int.Parse(itemInfo[1]) * bagInfo.ItemNum });
                        }
                    }
                }

                //扣除装备
                bagComponent.OnCostItemData(petHexin, ItemLocType.ItemPetHeXinBag);
                bagComponent.OnCostItemData(bagsList, ItemLocType.ItemLocBag);
                bagComponent.OnAddItemData(huishouGet.Values.ToList(), $"{ItemGetWay.HuiShou}_{TimeHelper.ServerNow()}");
                unit.GetComponent<TaskComponent>().OnItemHuiShow();

                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }
    }
}
