using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TeamDungeonBoxRewardHandler : AMActorLocationRpcHandler<Unit, C2M_TeamDungeonBoxRewardRequest, M2C_TeamDungeonBoxRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamDungeonBoxRewardRequest request, M2C_TeamDungeonBoxRewardResponse response, Action reply)
        {
            Scene scene = unit.DomainScene();
            if (scene.InstanceId == 0 || scene.IsDisposed)
            {
                Log.Debug($"LoginTest TeamDungeonBoxReward {unit.Id}");
                reply();
                return;
            }

            if (scene.GetComponent<TeamDungeonComponent>().BoxReward.Contains(request.BoxIndex))
            {
                reply();
                return;
            }
            scene.GetComponent<TeamDungeonComponent>().BoxReward.Add(request.BoxIndex);

            List<RewardItem> rewardItems = new List<RewardItem>();
            rewardItems.Add(request.RewardItem);
            unit.GetComponent<BagComponent>().OnAddItemData(rewardItems,0,$"{ItemGetWay.FubenGetReward}_{TimeHelper.ServerNow()}");

            M2C_TeamDungeonBoxRewardResult m2C_HorseNoticeInfo = new M2C_TeamDungeonBoxRewardResult()
            { 
                UserId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId,
                BoxIndex = request.BoxIndex
            };
            MessageHelper.Broadcast(unit, m2C_HorseNoticeInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
