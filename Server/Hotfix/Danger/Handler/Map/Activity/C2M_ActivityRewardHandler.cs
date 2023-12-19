using System;
using System.Collections.Generic;

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
                    if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.DailyCostDiamond) < request.RewardId)
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
                    if (hongbaoNumber <= 0)
                    {
                        response.Error = ErrorCode.ERR_AlreadyReceived;
                        reply();
                        return;
                    }
                    List<RewardItem> rewardItems = new List<RewardItem>();  
                    DropHelper.DropIDToDropItem(ActivityConfigHelper.HongBaoDropId, rewardItems);
                    if (bagComponent.GetLeftSpace() < rewardItems.Count)
                    {
                        response.Error = ErrorCode.ERR_BagIsFull;
                        reply();
                        return;
                    }
                    unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.ItemBox_9}_{TimeHelper.ServerNow()}");
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.V1HongBaoNumber, -1, 0);
                    break;
                default:
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
