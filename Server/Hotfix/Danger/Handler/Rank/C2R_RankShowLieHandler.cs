using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2R_RankShowLieHandler : AMActorRpcHandler<Scene, C2R_RankShowLieRequest, R2C_RankShowLieResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankShowLieRequest request, R2C_RankShowLieResponse response, Action reply)
        {
            response.RankList = scene.GetComponent<RankSceneComponent>().DBRankInfo.rankShowLie;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
