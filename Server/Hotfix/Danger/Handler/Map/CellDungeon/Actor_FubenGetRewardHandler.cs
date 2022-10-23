using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_FubenGetRewardHandler : AMActorLocationRpcHandler<Unit, Actor_GetFubenRewardRequest, Actor_GetFubenRewardReponse>
    {
        protected override async ETTask Run(Unit unit, Actor_GetFubenRewardRequest request, Actor_GetFubenRewardReponse response, Action reply)
        {
            //需要验证, 奖励的数据放在fubencompoentsystem

            List<RewardItem> rewardItems = new List<RewardItem>();
            rewardItems.Add(request.RewardItem);
            unit.GetComponent<BagComponent>().OnAddItemData(rewardItems,"", $"{ItemGetWay.FubenGetReward}_{TimeHelper.ServerNow()}");

            response.Error = ErrorCore.ERR_Success;
            reply();

            await ETTask.CompletedTask;
        }
    }
}
