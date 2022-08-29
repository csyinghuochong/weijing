using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetFubenRewardHandler : AMActorLocationRpcHandler<Unit, C2M_PetFubenRewardRequest, M2C_PetFubenRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_PetFubenRewardRequest request, M2C_PetFubenRewardResponse response, Action reply)
        {
            int rewardId = unit.GetComponent<PetComponent>().GetCanRewardId();
            if (rewardId == 0)
            {
                reply();
                return;
            }
            PetFubenRewardConfig rewardConfig = PetFubenRewardConfigCategory.Instance.Get(rewardId);
            unit.GetComponent<BagComponent>().OnAddItemData(rewardConfig.RewardItems);
            unit.GetComponent<PetComponent>().PetFubeRewardId = rewardId;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
