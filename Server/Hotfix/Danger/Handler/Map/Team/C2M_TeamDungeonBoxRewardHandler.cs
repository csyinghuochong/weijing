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
                Log.Debug($"TeamDungeonBoxReward scene.InstanceId == 0 {unit.Id}");
                reply();
                return;
            }

            TeamDungeonComponent teamDungeonComponent = scene.GetComponent<TeamDungeonComponent>();
            if (teamDungeonComponent == null)
            {
                Log.Debug($"TeamDungeonBoxReward scene.InstanceId == 0 {unit.Id}");
                reply();
                return;
            }

            if (teamDungeonComponent.BoxReward.Contains(request.BoxIndex))
            {
                Log.Error($"TeamDungeonBoxReward[已翻牌]: {unit.Id} {request.BoxIndex}");
                reply();
                return;
            }
            teamDungeonComponent.BoxReward.Add(request.BoxIndex);

            Log.Debug($"TeamDungeonBoxReward[可翻牌]: {unit.Id} {request.BoxIndex} {request.RewardItem.ItemID} {request.RewardItem.ItemNum}");
            List<RewardItem> rewardItems = new List<RewardItem>();
            rewardItems.Add(request.RewardItem);
            unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, "", $"{ItemGetWay.FubenGetReward}_{TimeHelper.ServerNow()}");

            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            M2C_TeamDungeonBoxRewardResult m2C_HorseNoticeInfo = new M2C_TeamDungeonBoxRewardResult()
            { 
                UserId = userInfo.UserId,
                BoxIndex = request.BoxIndex,
                PlayerName = userInfo.Name
            };
            List<Unit> allPlayer = FubenHelp.GetUnitList(unit.DomainScene(), UnitType.Player);
            MessageHelper.SendToClient(allPlayer, m2C_HorseNoticeInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
