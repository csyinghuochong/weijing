using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_GemHeChengQuickHandler : AMActorLocationRpcHandler<Unit, C2M_GemHeChengQuickRequest, M2C_GemHeChengQuickResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_GemHeChengQuickRequest request, M2C_GemHeChengQuickResponse response, Action reply)
        {
            // request加个仓库。  0是ItemLocType.BagItemList     19ItemLocType.GemWareHouse1
            if (request.LocType != 0 && request.LocType != 19)
            {
                Log.Error($"C2M_GemHeChengQuickRequest.1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            int leftCell = 0;
            if (request.LocType == 0)
            {
                leftCell = unit.GetComponent<BagComponent>().GetBagLeftCell();
            }
            else
            {
                leftCell = unit.GetComponent<BagComponent>().GetHourseLeftCell(request.LocType);
            }

            List<BagInfo> bagItemList = unit.GetComponent<BagComponent>().GetItemByLoc((ItemLocType)request.LocType);

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
            long costgold = 0;
            long costvitality = 0;
            for (int i = gemList.Count - 1; i >= 0; i--)
            {
                KeyValuePairInt keyValuePair = EquipMakeConfigCategory.Instance.GetHeChengList[gemList[i].ItemID];
                int neednumber = (int)keyValuePair.Value;
                int newmakeid = keyValuePair.KeyId;
                int newnumber = gemList[i].ItemNum / neednumber;
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(newmakeid);
                costgold += (equipMakeConfig.MakeNeedGold * newnumber);
                costvitality += (equipMakeConfig.CostVitality * newnumber);

                //新增宝石
                if (!addIds.ContainsKey(equipMakeConfig.MakeItemID))
                {
                    addIds.Add(equipMakeConfig.MakeItemID, 0);
                }
                addIds[equipMakeConfig.MakeItemID] += newnumber;

                //更新旧的
                if (!removeids.ContainsKey(gemList[i].ItemID))
                {
                    removeids.Add(gemList[i].ItemID, 0);
                }
                removeids[gemList[i].ItemID] += (neednumber * newnumber);
            }


            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Gold < costgold)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }
            if (userInfo.Vitality < costvitality)
            {
                response.Error = ErrorCode.ERR_VitalityNotEnoughError;
                reply();
                return;
            }


            List<RewardItem> rewardItems = new List<RewardItem>();
            foreach ((int itemid, int number) in addIds)
            {
                if (number == 0)
                {
                    continue;
                }

                rewardItems.Add(new RewardItem() { ItemID = itemid, ItemNum = number });
            }

            int needCell = rewardItems.Count;
            
            needCell = unit.GetComponent<BagComponent>().GetNeedCell(rewardItems, (ItemLocType)request.LocType);

            if (unit.DomainZone() == 5)
            {
                Console.WriteLine($"宝石合成: leftCell:{leftCell}  rewardItems:{rewardItems.Count}  realneedCell:{needCell}");
            }

            if (leftCell < needCell)
            {
                response.Error = request.LocType == 0 ? ErrorCode.ERR_BagIsFull :  ErrorCode.ERR_WarehouseIsFull;
                reply();
                return;
            }

            string removeItems = string.Empty;
            foreach ((int itemid, int number) in removeids)
            {
                if (number == 0)
                {
                    continue;
                }

                if (removeItems != string.Empty)
                {
                    removeItems += "@";
                }

                removeItems += $"{itemid};{number}";
            }
            if (removeItems != string.Empty)
            {
                unit.GetComponent<BagComponent>().OnCostItemData(removeItems, (ItemLocType)request.LocType, ItemGetWay.GemHeCheng);
            }

          
            unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.GemHeCheng}_{TimeHelper.ServerNow()}",
                UseLocType: (ItemLocType)request.LocType);

            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (costgold * -1).ToString(), true, ItemGetWay.SkillMake);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Vitality, (costvitality * -1).ToString());

            reply();
            await ETTask.CompletedTask;
        }
    }
}
