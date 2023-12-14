using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2R_RankSeasonTowerHandler : AMActorRpcHandler<Scene, M2R_RankSeasonTowerRequest, R2M_RankSeasonTowerResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_RankSeasonTowerRequest request, R2M_RankSeasonTowerResponse response, Action reply)
        {
            RankSceneComponent rankSceneComponent = scene.GetComponent<RankSceneComponent>();
            List<KeyValuePairLong> rankSeasonTower = rankSceneComponent.DBRankInfo.rankSeasonTower;

            //TotalTime = ranklist[i].Value,        //时间
            //FubenId = (int)(ranklist[i].Value2),  //副本

            bool have = false;
            for (int i = 0; i < rankSeasonTower.Count; i++)
            {
                if (rankSeasonTower[i].KeyId != request.RankingInfo.KeyId)
                {
                    continue;
                }
                if (rankSeasonTower[i].Value2 >= request.RankingInfo.Value2)  //副本
                {
                    continue;
                }

                rankSeasonTower[i].Value += request.RankingInfo.Value ;
                rankSeasonTower[i].Value2 = request.RankingInfo.Value2;
                have = true;
            }

            if (!have)
            {
                rankSeasonTower.Add(request.RankingInfo);
            }

            ///先排层数 再排时间
            rankSeasonTower.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
            {
                if (b.Value2 == a.Value2)
                {
                    return (int)a.Value - (int)b.Value;
                }
                else
                {
                    return (int)b.Value2 - (int)a.Value2;
                }
            });

            int maxnumber = Math.Min(rankSeasonTower.Count, ComHelp.RankNumber);
            rankSceneComponent.DBRankInfo.rankSeasonTower = rankSeasonTower.GetRange(0, maxnumber);
            response.RankId = rankSceneComponent.GetSeasonTowerRank(request.RankingInfo.KeyId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
