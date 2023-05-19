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
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }
            if (userInfo.Vitality < costvitality)
            {
                response.Error = ErrorCore.ERR_VitalityNotEnoughError;
                reply();
                return;
            }

            foreach ( ( int itemid, int number ) in addIds)
            {
                unit.GetComponent<BagComponent>().OnAddItemData($"{itemid};{number}", $"{ItemGetWay.PetHeXinHeCheng}_{TimeHelper.ServerNow()}");
            }

            foreach ((int itemid, int number) in removeids)
            {
                unit.GetComponent<BagComponent>().OnCostItemData($"{itemid};{number}");
            }

            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (costgold * -1).ToString(), true, ItemGetWay.SkillMake);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Vitality, (costvitality * -1).ToString());

            reply();
            await ETTask.CompletedTask;
        }
    }
}
