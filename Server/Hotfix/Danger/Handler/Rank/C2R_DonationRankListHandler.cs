using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_DonationRankListHandler : AMActorRpcHandler<Scene, C2R_DonationRankListRequest, R2C_DonationRankListResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_DonationRankListRequest request, R2C_DonationRankListResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();

            List<RankingInfo> all = rankComponent.DBRankInfo.rankingDonation;
            List<RankingInfo> list = all.GetRange(0, Math.Min( 5, all.Count ));

            response.RankList = list;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
