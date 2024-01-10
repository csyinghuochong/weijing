using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_RechargeRewardHandler : AMActorLocationRpcHandler<Unit, C2M_RechargeRewardRequest, M2C_RechargeRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RechargeRewardRequest request, M2C_RechargeRewardResponse response, Action reply)
        {
            if (!ConfigHelper.RechargeReward.ContainsKey(request.RechargeNumber))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.RechargeReward.Contains(request.RechargeNumber))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            long rechargeTotal = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber);
            if (rechargeTotal < request.RechargeNumber)
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }

            string rewarditem = ConfigHelper.RechargeReward[request.RechargeNumber];
            string[] rewardList = rewarditem.Split('@');
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < rewardList.Length)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            unit.GetComponent<BagComponent>().OnAddItemData(rewarditem, $"{ItemGetWay.Recharge}_{TimeHelper.ServerNow()}");
            userInfoComponent.UserInfo.RechargeReward.Add(request.RechargeNumber);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
