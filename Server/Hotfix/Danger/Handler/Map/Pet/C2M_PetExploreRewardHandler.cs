using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetExploreRewardHandler : AMActorLocationRpcHandler<Unit, C2M_PetExploreReward, M2C_PetExploreReward>
    {
        protected override async ETTask Run(Unit unit, C2M_PetExploreReward request, M2C_PetExploreReward response, Action reply)
        {
            //NumericType.PetExploreNumber 当前探索次数
            //request.RewardId 为ConfigHelper.PetExploreReward.Keys
            //记录到 unit.GetComponent<UserInfoComponent>().UserInfo.PetExploreRewardIds.Add(request.RewardId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
