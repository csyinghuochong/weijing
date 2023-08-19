using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankUnionRaceHandler : AMActorRpcHandler<Scene, C2R_RankUnionRaceRequest, R2C_RankUnionRaceResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankUnionRaceRequest request, R2C_RankUnionRaceResponse response, Action reply)
        {
            response.RankList = scene.GetComponent<RankSceneComponent>().DBRankInfo.rankUnionRace;

            if (response.RankList.Count == 0)
            {
                response.RankList.Add( new RankShouLieInfo() { KillNumber = 20, Occ = 1, PlayerName = "玩家1", UnitID = 1 } );
                response.RankList.Add(new RankShouLieInfo() { KillNumber = 10, Occ = 2, PlayerName = "玩家2", UnitID =2 });
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
