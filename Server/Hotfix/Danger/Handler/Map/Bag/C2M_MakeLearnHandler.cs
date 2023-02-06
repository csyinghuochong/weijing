using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_MakeLearnHandler : AMActorLocationRpcHandler<Unit, C2M_MakeLearnRequest, M2C_MakeLearnResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_MakeLearnRequest request, M2C_MakeLearnResponse response, Action reply)
        {
            try
            {
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(request.MakeId);

                //判断学习金币是否不足
                if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold <equipMakeConfig.LearnGoldValue)
                {
                    response.Error = ErrorCore.ERR_GoldNotEnoughError;
                    reply();
                    return;
                }

                //判断是否已经学习
                if (unit.GetComponent<UserInfoComponent>().UserInfo.MakeList.Contains(request.MakeId))
                {
                    reply();
                    return;
                }

                //判断学习是否已经满足熟练度要求
                if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeShuLianDu) < equipMakeConfig.NeedProficiencyValue) {
                    response.Error = ErrorCore.ERR_ShuLianDuNotEnough;
                    reply();
                    return;
                }

                //判断学习等级是否满足
                if (unit.GetComponent<UserInfoComponent>().UserInfo.Lv < equipMakeConfig.LearnLv)
                {
                    response.Error = ErrorCore.ERR_LevelNoEnough;
                    reply();
                    return;
                }

                List<RewardItem> costItems = new List<RewardItem>();
                string neadItems = equipMakeConfig.LearnNeedItems;
                string[] needList = neadItems.Split('@');
                for (int i = 0; i < needList.Length; i++)
                {
                    string[] itemInfo = needList[i].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
                }
                bool success = unit.GetComponent<BagComponent>().OnCostItemData(costItems);
                if (success)
                {
                    unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (equipMakeConfig.LearnGoldValue * -1).ToString(), true, ItemGetWay.SkillMake);
                    unit.GetComponent<UserInfoComponent>().UserInfo.MakeList.Add(request.MakeId);
                }
                else
                {
                    response.Error = ErrorCore.ERR_GoldNotEnoughError;
                }
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

