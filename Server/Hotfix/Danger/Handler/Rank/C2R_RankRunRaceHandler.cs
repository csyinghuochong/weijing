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

            if(response.RankList.Count == 0)
            {
                response.RankList.Add( new RankingInfo() { UserId = 1, Occ = 1, PlayerName = "玩家1" } );
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
