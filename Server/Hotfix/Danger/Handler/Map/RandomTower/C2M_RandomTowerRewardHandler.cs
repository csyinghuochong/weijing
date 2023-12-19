using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_RandomTowerRewardHandler : AMActorLocationRpcHandler<Unit, C2M_RandomTowerRewardRequest, M2C_RandomTowerRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RandomTowerRewardRequest request, M2C_RandomTowerRewardResponse response, Action reply)
        {
            if (!TowerConfigCategory.Instance.Contain(request.RewardId))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }


            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.TowerRewardIds.Contains(request.RewardId))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            TowerConfig towerRewardConfig = TowerConfigCategory.Instance.Get(request.RewardId);
            if (unit.GetComponent<BagComponent>().OnAddItemData(towerRewardConfig.DropShow, $"{ItemGetWay.RandomTowerReward}_{TimeHelper.ServerNow()}"))
            {
                userInfoComponent.UserInfo.TowerRewardIds.Add(request.RewardId);
            }
            else
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
