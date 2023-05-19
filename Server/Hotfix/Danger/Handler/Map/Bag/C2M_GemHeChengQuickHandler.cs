using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_GemHeChengQuickHandler : AMActorLocationRpcHandler<Unit, C2M_GemHeChengQuickRequest, M2C_GemHeChengQuickResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_GemHeChengQuickRequest request, M2C_GemHeChengQuickResponse response, Action reply)
        {
            List<BagInfo> bagItemList = unit.GetComponent<BagComponent>().BagItemList;

            List<BagInfo> gemList = new List<BagInfo>();
            for (int i = 0; i < bagItemList.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagItemList[i].ItemID);
                if (itemConfig.ItemType != ItemTypeEnum.Gemstone)
                {
                    continue;
                }

                if (!EquipMakeConfigCategory.Instance.GetHeChengList.ContainsKey(itemConfig.Id))
                {
                    continue;
                }
                gemList.Add(bagItemList[i]);
            }

            Dictionary<int, int> addIds     = new Dictionary<int, int>();
            Dictionary<int, int> removeids  = new Dictionary<int, int>();    
            for (int i = gemList.Count - 1; i >= 0; i--)
            {
                KeyValuePairInt keyValuePair = EquipMakeConfigCategory.Instance.GetHeChengList[gemList[i].ItemID];
                int neednumber = (int)keyValuePair.Value;
                int newgemid = keyValuePair.KeyId;
                int newnumber = gemList[i].ItemNum / neednumber;

                //新增宝石
                if (!addIds.ContainsKey(newgemid))
                {
                    addIds.Add(newgemid, 0);
                }
                addIds[newgemid] += newnumber;

                //更新旧的
                if (!removeids.ContainsKey(gemList[i].ItemID))
                {
                    removeids.Add(gemList[i].ItemID, 0);
                }
                removeids[gemList[i].ItemID] += (neednumber * newnumber);
            }

            foreach ( ( int itemid, int number ) in addIds)
            {
                unit.GetComponent<BagComponent>().OnAddItemData($"{itemid}_{number}", $"{ItemGetWay.PetHeXinHeCheng}_{TimeHelper.ServerNow()}");
            }

            foreach ((int itemid, int number) in removeids)
            {
                unit.GetComponent<BagComponent>().OnCostItemData($"{itemid}_{number}");
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
