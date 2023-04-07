using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankListHandler : AMActorRpcHandler<Scene, C2R_RankListRequest, R2C_RankListResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankListRequest request, R2C_RankListResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();

            List<RankingInfo> all = rankComponent.DBRankInfo.rankingInfos;
            List<RankingInfo> list = all.GetRange(0, all.Count > ComHelp.RankNumber ? ComHelp.RankNumber : all.Count);

            response.RankList = list;


            reply();
            await ETTask.CompletedTask;
        }
    }
}
