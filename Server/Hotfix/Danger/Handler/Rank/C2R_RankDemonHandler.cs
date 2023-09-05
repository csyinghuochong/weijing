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

            reply();
            await ETTask.CompletedTask;
        }
    }
}
