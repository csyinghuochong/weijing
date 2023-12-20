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
                LogHelper.LogDebug($"TeamDungeonBoxReward scene.InstanceId == 0 {unit.Id}");
                reply();
                return;
            }

            TeamDungeonComponent teamDungeonComponent = scene.GetComponent<TeamDungeonComponent>();
            if (teamDungeonComponent == null)
            {
                LogHelper.LogDebug($"TeamDungeonBoxReward scene.InstanceId == 0 {unit.Id}");
                reply();
                return;
            }

            if (teamDungeonComponent.BoxReward.Contains(request.BoxIndex))
            {
                LogHelper.LogDebug($"TeamDungeonBoxReward[已翻牌]: {unit.Id} {request.BoxIndex}");
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            LogHelper.LogDebug($"TeamDungeonBoxReward[可翻牌]: {unit.Id} {request.BoxIndex} {request.RewardItem.ItemID} {request.RewardItem.ItemNum}");
            teamDungeonComponent.BoxReward.Add(request.BoxIndex);

            ////背包已经直接发邮件，response加一个状态。 客户端弹窗提示“由于您背包已满通关宝箱的奖励已经自动发放进您的邮箱中,请注意查收”
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < 1)
            {
                response.Mail = 1;
                List<BagInfo> bagInfos = new List<BagInfo>();
                bagInfos.Add(new BagInfo(){ ItemID = request.RewardItem.ItemID, ItemNum = request.RewardItem.ItemNum } );
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Context = "副本奖励";
                mailInfo.Title = "副本奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();
                mailInfo.ItemList.AddRange(bagInfos);

                MailHelp.SendUserMail( unit.DomainZone(), unit.Id, mailInfo).Coroutine();
            }
            else
            {
                List<RewardItem> rewardItems = new List<RewardItem>() { request.RewardItem };
                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, "", $"{ItemGetWay.FubenGetReward}_{TimeHelper.ServerNow()}");
            }

            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            M2C_TeamDungeonBoxRewardResult m2C_HorseNoticeInfo = new M2C_TeamDungeonBoxRewardResult()
            { 
                UserId = userInfo.UserId,
                BoxIndex = request.BoxIndex,
                PlayerName = userInfo.Name
            };
            List<Unit> allPlayer = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Player);
            MessageHelper.SendToClient(allPlayer, m2C_HorseNoticeInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
