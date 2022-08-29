

using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ChengJiuRewardHandler : AMActorLocationRpcHandler<Unit, C2M_ChengJiuRewardRequest, M2C_ChengJiuRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ChengJiuRewardRequest request, M2C_ChengJiuRewardResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
            response.Error = chengJiuComponent.ReceivedReward(request.RewardId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
