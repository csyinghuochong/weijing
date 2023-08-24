using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankRunRaceHandler : AMActorRpcHandler<Scene, C2R_RankRunRaceRequest, R2C_RankRunRaceResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankRunRaceRequest request, R2C_RankRunRaceResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();
            response.RankList = rankComponent.DBRankInfo.rankRunRace;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
