using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_SingleRechargeRewardHandler: AMActorLocationRpcHandler<Unit, C2M_SingleRechargeRewardRequest, M2C_SingleRechargeRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_SingleRechargeRewardRequest request, M2C_SingleRechargeRewardResponse response,
        Action reply)
        {
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (request.RewardId == 0)
            {
                response.RewardIds = userInfo.SingleRechargeRewardIds;
                reply();
                return;
            }

            if (!ConfigHelper.SingleRechargeReward.ContainsKey(request.RewardId))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            string[] rewarditemlist = ConfigHelper.SingleRechargeReward[request.RewardId].Split('@');
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < rewarditemlist.Length)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            if (!userInfo.SingleRechargeRewardIds.Contains(request.RewardId))
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }

            userInfo.SingleRechargeRewardIds.Remove(request.RewardId);
            unit.GetComponent<BagComponent>().OnAddItemData(ConfigHelper.SingleRechargeReward[request.RewardId],
                $"{ItemGetWay.ActivityChouKa}_{TimeHelper.ServerNow()}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}