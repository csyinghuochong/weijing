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
                response.RewardIds = userInfo.SingleRechargeIds;
                reply();
                return;
            }

            if (!ConfigHelper.SingleRechargeReward.ContainsKey(request.RewardId))
            {
                Log.Error($"C2M_SingleRechargeRewardRequest 1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (!userInfo.SingleRechargeIds.Contains(request.RewardId))
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }

            if (userInfo.SingleRewardIds.Contains(request.RewardId))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            string[] rewarditemlist = ConfigHelper.SingleRechargeReward[request.RewardId].Split('@');
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < rewarditemlist.Length)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            
            bool ret = unit.GetComponent<BagComponent>().OnAddItemData(ConfigHelper.SingleRechargeReward[request.RewardId],
                $"{ItemGetWay.ActivityChouKa}_{TimeHelper.ServerNow()}");

            if (ret)
            {
                userInfo.SingleRewardIds.Add(request.RewardId);
                response.RewardIds = userInfo.SingleRewardIds;
            }
            else
            {
                Log.Error($"领取失败: {bagComponent.GetBagLeftCell()} {request.RewardId}");
            }
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}