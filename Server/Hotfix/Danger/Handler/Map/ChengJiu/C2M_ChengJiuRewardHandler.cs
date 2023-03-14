

using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ChengJiuRewardHandler : AMActorLocationRpcHandler<Unit, C2M_ChengJiuRewardRequest, M2C_ChengJiuRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ChengJiuRewardRequest request, M2C_ChengJiuRewardResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
            ChengJiuRewardConfig chengJiuConfig = ChengJiuRewardConfigCategory.Instance.Get(request.RewardId);
            if (chengJiuComponent.TotalChengJiuPoint < chengJiuConfig.NeedPoint)
            {
                reply();
                return;
            }
            if (chengJiuComponent.AlreadReceivedId.Contains(request.RewardId))
            {
                reply();
                return;
            }

            response.Error = chengJiuComponent.ReceivedReward(request.RewardId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
