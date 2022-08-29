using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankListHandler : AMActorRpcHandler<Scene, C2R_RankListRequest, R2C_RankListResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankListRequest request, R2C_RankListResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();
            response.RankList = rankComponent.DBRankInfo.rankingInfos;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
