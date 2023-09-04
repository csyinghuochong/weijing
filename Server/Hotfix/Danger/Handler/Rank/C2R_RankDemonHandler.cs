using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankDemonHandler : AMActorRpcHandler<Scene, C2R_RankDemonRequest, R2C_RankDemonResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankDemonRequest request, R2C_RankDemonResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();
            response.RankList = rankComponent.DBRankInfo.rankingDemon;

            if (response.RankList.Count == 0)
            {
                response.RankList.Add(new RankingInfo() { Combat = 100, Occ = 1, PlayerName = "玩家1", UserId = 1 });
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
