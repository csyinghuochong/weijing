using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankUnionRaceHandler : AMActorRpcHandler<Scene, C2R_RankUnionRaceRequest, R2C_RankUnionRaceResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankUnionRaceRequest request, R2C_RankUnionRaceResponse response, Action reply)
        {
            response.RankList = scene.GetComponent<RankSceneComponent>().DBRankInfo.rankUnionRace;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
