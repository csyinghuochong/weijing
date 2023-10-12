using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2R_RankTrialHandler : AMActorRpcHandler<Scene, M2R_RankTrialRequest, R2M_RankTrialResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_RankTrialRequest request, R2M_RankTrialResponse response, Action reply)
        {
            RankSceneComponent rankSceneComponent = scene.GetComponent<RankSceneComponent>();
            DBRankInfo dBRankInfo = rankSceneComponent.DBRankInfo;
            List<KeyValuePairLong> rankRunRace = rankSceneComponent.DBRankInfo.rankingTrials;

            bool have = false;
            for (int i = 0; i < rankRunRace.Count; i++)
            {
                if (rankRunRace[i].KeyId == request.RankingInfo.KeyId)
                {
                    rankRunRace[i].Value += request.RankingInfo.Value;
                    have = true;
                }
            }

            if (!have)
            {
                rankRunRace.Add(request.RankingInfo);
            }
            rankRunRace.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
            {
                return (int)b.Value - (int)a.Value;
            });

            int maxnumber = Math.Min(rankRunRace.Count, 100);
            rankRunRace = rankRunRace.GetRange(0, maxnumber);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
