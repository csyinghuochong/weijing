using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2R_RankDemonHandler : AMActorRpcHandler<Scene, M2R_RankDemonRequest, R2M_RankDemonResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_RankDemonRequest request, R2M_RankDemonResponse response, Action reply)
        {

            RankSceneComponent rankSceneComponent = scene.GetComponent<RankSceneComponent>();
            DBRankInfo dBRankInfo = rankSceneComponent.DBRankInfo;
            List<RankingInfo> rankDemonList = rankSceneComponent.DBRankInfo.rankingDemon;

            bool have = false;
            for (int i = 0; i < rankDemonList.Count; i++)
            {
                if (rankDemonList[i].UserId == request.RankingInfo.UserId)
                {
                    rankDemonList[i].Combat += request.RankingInfo.Combat;
                }
            }

            if (!have)
            {
                rankDemonList.Add(request.RankingInfo);
            }

            rankDemonList.Sort(delegate (RankingInfo a, RankingInfo b)
            {
                return (int)b.Combat - (int)a.Combat;
            });

            int maxnumber = Math.Min(rankDemonList.Count, 10);
            dBRankInfo.rankRunRace = rankDemonList.GetRange(0, maxnumber);

            for (int i = 0; i < rankDemonList.Count; i++)
            {
                if (rankDemonList[i].UserId == request.RankingInfo.UserId)
                {
                    response.RankId = i + 1;
                }
            }
            response.RankList = rankDemonList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
