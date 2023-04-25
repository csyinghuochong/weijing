using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_DonationRankListHandler : AMActorRpcHandler<Scene, C2U_DonationRankListRequest, U2C_DonationRankListResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_DonationRankListRequest request, U2C_DonationRankListResponse response, Action reply)
        {
            UnionSceneComponent rankComponent = scene.GetComponent<UnionSceneComponent>();

            List<RankingInfo> all = rankComponent.DBUnionManager.rankingDonation;
            List<RankingInfo> list = all.GetRange(0, Math.Min( 5, all.Count ));

            response.RankList = list;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
