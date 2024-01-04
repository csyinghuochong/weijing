using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ActivityRewardHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityRewardRequest, M2C_ActivityRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityRewardRequest request, M2C_ActivityRewardResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            string rewarditem = string.Empty;
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();   

            switch (request.ActivityType)
            {
                case ActivityConfigHelper.ActivityV1_ChouKa:
                    if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1ChouKaNumber) < request.RewardId)
                    {
                        response.Error = ErrorCode.Pre_Condition_Error;
                        reply();
                        return;
                    }

                    if (!ActivityConfigHelper.ChouKaNumberReward.ContainsKey(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }
                    if (activityComponent.ActivityV1Info.ChouKaNumberReward.Contains(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_AlreadyReceived;
                        reply();
                        return;
                    }
                    rewarditem = ActivityConfigHelper.ChouKaNumberReward[request.RewardId];
                    unit.GetComponent<BagComponent>().OnAddItemData(rewarditem, $"{ItemGetWay.ActivityChouKa}_{TimeHelper.ServerNow()}");
                    activityComponent.ActivityV1Info.ChouKaNumberReward.Add(request.RewardId);
                    break;
                case ActivityConfigHelper.ActivityV1_Consume:
                    if (!ActivityConfigHelper.ConsumeDiamondReward.ContainsKey(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }
                    if (activityComponent.ActivityV1Info.ConsumeDiamondReward.Contains(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_AlreadyReceived;
                        reply();
                        return;
                    }
                    if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.V1DayCostDiamond) < request.RewardId)
                    {
                        response.Error = ErrorCode.Pre_Condition_Error;
                        reply();
                        return;
                    }
                    rewarditem = ActivityConfigHelper.ConsumeDiamondReward[request.RewardId];
                    unit.GetComponent<BagComponent>().OnAddItemData(rewarditem, $"{ItemGetWay.ActivityConsume}_{TimeHelper.ServerNow()}");
                    activityComponent.ActivityV1Info.ConsumeDiamondReward.Add(request.RewardId);
                    break;
                case ActivityConfigHelper.ActivityV1_HongBao:
                    int hongbaoNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1HongBaoNumber);
                    long v1rechargeNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1RechageNumber);
                    int totalHongBa0 = (int)(v1rechargeNumber / 98);
                    if (hongbaoNumber >= totalHongBa0)
                    {
                        response.Error = ErrorCode.ERR_AlreadyReceived;
                        reply();
                        return;
                    }
                    List<RewardItem> rewardItems = new List<RewardItem>();  
                    DropHelper.DropIDToDropItem_2(ActivityConfigHelper.HongBaoDropId, rewardItems);
                    if (bagComponent.GetLeftSpace() < rewardItems.Count)
                    {
                        response.Error = ErrorCode.ERR_BagIsFull;
                        reply();
                        return;
                    }
                    unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.ItemBox_9}_{TimeHelper.ServerNow()}");
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.V1HongBaoNumber, 1, 0);
                    break;
                case ActivityConfigHelper.ActivityV1_DuiHuanWord:
                    if (bagComponent.GetLeftSpace() < 1)
                    {
                        response.Error = ErrorCode.ERR_BagIsFull;
                        reply();
                        return;
                    }
                    if (request.RewardId > 0 && !ActivityConfigHelper.DuiHuanWordReward.ContainsKey(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }

                    List<RewardItem> costItemList = new List<RewardItem>();
                    string rewardItem = string.Empty;
                    if (request.RewardId == 0)
                    {
                        List<int> allword = ActivityConfigHelper.DuiHuanWordReward.Keys.ToList();
                        for (int i = 0; i < allword.Count; i++)
                        {
                            costItemList.Add( new RewardItem() { ItemID = allword[i], ItemNum = 1 } );
                        }
                        rewardItem = ActivityConfigHelper.GroupsWordReward;
                    }
                    else
                    {
                        costItemList.Add( new RewardItem() { ItemID = request.RewardId, ItemNum = 1 } );
                        rewardItem = ActivityConfigHelper.DuiHuanWordReward[request.RewardId];
                    }
                    if (!bagComponent.OnCostItemData(costItemList))
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }
                    bagComponent.OnAddItemData(rewardItem, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                    break;
                case ActivityConfigHelper.ActivityV1_ChouKa2:
                    if (bagComponent.GetLeftSpace() < 1)
                    {
                        response.Error = ErrorCode.ERR_BagIsFull;
                        reply();
                        return;
                    }
                    if (bagComponent.GetItemNumber(ActivityConfigHelper.Chou2CostItem) < 1)
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }
                    int rewardIndex = ActivityConfigHelper.GetChouKa2RewardIndex(activityComponent.ActivityV1Info.ChouKa2ItemList, activityComponent.ActivityV1Info.ChouKa2RewardIds);
                    activityComponent.ActivityV1Info.ChouKa2RewardIds.Add(rewardIndex);
                    string[] rewardList = activityComponent.ActivityV1Info.ChouKa2ItemList.Split(';');
                    rewardItem = rewardList[rewardIndex];
                    bagComponent.OnAddItemData(rewardItem, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                    break;
                case ActivityConfigHelper.ActivityV1_LiBao:
                    if (bagComponent.GetLeftSpace() < 1)
                    {
                        response.Error = ErrorCode.ERR_BagIsFull;
                        reply();
                        return;
                    }
                    if (!activityComponent.ActivityV1Info.LiBaoAllIds.Contains(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }
                    if (activityComponent.ActivityV1Info.LiBaoBuyIds.Contains(request.RewardId))
                    {
                        response.Error = ErrorCode.ERR_AlreadyReceived;
                        reply();
                        return;
                    }
                    KeyValuePair keyValuePair = ActivityConfigHelper.LiBaoList[request.RewardId];
                    if (!bagComponent.OnCostItemData(keyValuePair.Value))
                    {
                        response.Error = ErrorCode.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }
                    bagComponent.OnAddItemData(keyValuePair.Value2, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                    activityComponent.ActivityV1Info.LiBaoBuyIds.Add(request.RewardId);
                    break;
                default:
                    break;
            }
            response.ActivityV1Info = activityComponent.ActivityV1Info;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
