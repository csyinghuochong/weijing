using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_MakeEquipHandler : AMActorLocationRpcHandler<Unit, C2M_MakeEquipRequest, M2C_MakeEquipResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_MakeEquipRequest request, M2C_MakeEquipResponse response, Action reply)
        {
            if (unit.GetComponent<BagComponent>().GetSpaceNumber() == 0)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(request.MakeId);
            ItemLocType locType = ItemLocType.ItemLocBag;
            int costItemId = 0;
            if (request.BagInfoID != 0)
            {
                BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(locType, request.BagInfoID);
                if (useBagInfo != null)
                {
                    costItemId = useBagInfo.ItemID;
                }
            }

            if (costItemId == 0 && equipMakeConfig.ProficiencyType == 0) {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < equipMakeConfig.MakeNeedGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Vitality < equipMakeConfig.CostVitality)
            {
                response.Error = ErrorCore.ERR_VitalityNotEnoughError;
                reply();
                return;
            }

            //制造图纸查看当前背包是否已经有图纸了


            List<RewardItem> costItems = new List<RewardItem>();
            string neadItems = equipMakeConfig.NeedItems;
            string[] needList = neadItems.Split('@');
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                if (itemInfo.Length != 2)
                {
                    continue;
                }
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
            }
            if (costItemId != 0)
            {
                costItems.Add(new RewardItem() { ItemID = costItemId, ItemNum = 1 });
            }
            bool success = unit.GetComponent<BagComponent>().OnCostItemData(costItems);
            if (!success)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub( UserDataType.Gold, (equipMakeConfig.MakeNeedGold * -1).ToString(), true, ItemGetWay.SkillMake);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Vitality, (equipMakeConfig.CostVitality * -1).ToString());
            if (request.BagInfoID == 0)
            {
                unit.GetComponent<UserInfoComponent>().OnMakeItem(equipMakeConfig.Id);
            }
            float rate = RandomHelper.RandFloat01();
            if (equipMakeConfig.MakeSuccesPro >= rate)
            {
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = equipMakeConfig.MakeItemID, ItemNum = equipMakeConfig.MakeEquipNum });
                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, unit.GetComponent<UserInfoComponent>().UserInfo.Name, $"{ItemGetWay.SkillMake}_{TimeHelper.ServerNow()}");       //传入制造装备和制造玩家的ID
                unit.GetComponent<TaskComponent>().OnMakeItem();
                response.ItemId = equipMakeConfig.MakeItemID;
            }
            else
            {
                response.ItemId = 0;
            }

            //制作的过程中有一定概率可以领悟当前等级可以学习的配方
            int newMakeId = MakeHelper.GetNewMakeID(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeType), request.MakeId,
                unit.GetComponent<UserInfoComponent>().UserInfo.MakeList);
            //宝石不领悟
            if (equipMakeConfig.ProficiencyType != 4 && equipMakeConfig.ProficiencyType != 5 && newMakeId != 0)
            {
                unit.GetComponent<UserInfoComponent>().UserInfo.MakeList.Add(newMakeId);
                response.NewMakeId = newMakeId;
            }

            if (equipMakeConfig.ProficiencyType != 4 
                && equipMakeConfig.ProficiencyValue!=null 
                && equipMakeConfig.ProficiencyValue.Length > 1)
            {
                int curShuLian = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeShuLianDu);
                int addShuLian = RandomHelper.RandomNumber(equipMakeConfig.ProficiencyValue[0], equipMakeConfig.ProficiencyValue[1]);
                curShuLian += addShuLian;
                curShuLian = Math.Min(ComHelp.MaxShuLianDu(), curShuLian);
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.MakeShuLianDu, curShuLian);
                unit.GetComponent<ChengJiuComponent>().OnSkillShuLianDu(curShuLian);
                unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.MakeNumber_216, 0, 1);
            }

            reply();
            await ETTask.CompletedTask;
        }

    }
}
