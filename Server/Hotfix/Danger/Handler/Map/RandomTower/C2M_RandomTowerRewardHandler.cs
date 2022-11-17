using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_RandomTowerRewardHandler : AMActorLocationRpcHandler<Unit, C2M_RandomTowerRewardRequest, M2C_RandomTowerRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RandomTowerRewardRequest request, M2C_RandomTowerRewardResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (!userInfoComponent.UserInfo.TowerRewardIds.Contains(request.RewardId))
            {
                userInfoComponent.UserInfo.TowerRewardIds.Add(request.RewardId);
                TowerConfig towerRewardConfig = TowerConfigCategory.Instance.Get(request.RewardId);
                unit.GetComponent<BagComponent>().OnAddItemData(towerRewardConfig.DropShow,$"{ItemGetWay.RandomTowerReward}_{TimeHelper.ServerNow()}");
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
