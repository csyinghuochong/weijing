using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskHuoYueRewardHandler : AMActorLocationRpcHandler<Unit, C2M_TaskHuoYueRewardRequest, M2C_TaskHuoYueRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TaskHuoYueRewardRequest request, M2C_TaskHuoYueRewardResponse response, Action reply)
        {

            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();

            if (!taskComponent.ReceiveHuoYueIds.Contains(request.HuoYueId))
            {
                taskComponent.ReceiveHuoYueIds.Add(request.HuoYueId);
                HuoYueRewardConfig huoYueRewardConfig = HuoYueRewardConfigCategory.Instance.Get(request.HuoYueId);
                unit.GetComponent<BagComponent>().OnAddItemData(huoYueRewardConfig.RewardItems);
            }
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
