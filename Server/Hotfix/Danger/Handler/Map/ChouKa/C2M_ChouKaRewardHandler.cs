using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ChouKaRewardHandler : AMActorLocationRpcHandler<Unit, C2M_ChouKaRewardRequest, M2C_ChouKaRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ChouKaRewardRequest request, M2C_ChouKaRewardResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent= unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.ChouKaRewardIds.Contains(request.RewardId))
            {
                reply();
                return;
            }
            if (!TakeCardRewardConfigCategory.Instance.Contain(request.RewardId))
            {
                Log.Console($"C2M_ChouKaRewardError {unit.Id} {request.RewardId}");
                reply();
                return;
            }
            TakeCardRewardConfig rewardConfig = TakeCardRewardConfigCategory.Instance.Get(request.RewardId);
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ChouKa) < rewardConfig.RoseLvLimit)
            {
                reply();
                return;
            }
            userInfoComponent.UserInfo.ChouKaRewardIds.Add(request.RewardId);

            int randomZuanshi = RandomHelper.RandomNumber(rewardConfig.RewardDiamond[0], rewardConfig.RewardDiamond[1]);
            unit.GetComponent<BagComponent>().OnAddItemData(rewardConfig.RewardItems, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}");
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(  UserDataType.Diamond, randomZuanshi.ToString(),true, ItemGetWay.ChouKa);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
