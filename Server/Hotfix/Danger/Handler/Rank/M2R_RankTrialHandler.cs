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
            List<KeyValuePairLong> rankRunRace = rankSceneComponent.DBRankInfo.rankingTrial;

            bool have = false;
            for (int i = 0; i < rankRunRace.Count; i++)
            {
                if (rankRunRace[i].KeyId != request.RankingInfo.KeyId)
                {
                    continue;
                }
                if (rankRunRace[i].Value2 > request.RankingInfo.Value2)
                {
                    continue;
                }

                if (rankRunRace[i].Value2 < request.RankingInfo.Value2)
                {
                    rankRunRace[i].Value = request.RankingInfo.Value;
                    rankRunRace[i].Value2 = request.RankingInfo.Value2;
                }
                else
                {
                    rankRunRace[i].Value = Math.Max(rankRunRace[i].Value, request.RankingInfo.Value);
                }
                have = true;
            }

            if (!have)
            {
                rankRunRace.Add(request.RankingInfo);
            }

            ///试炼之塔排行先按照层树排序,层序一样按照秒伤 试炼排行榜得秒伤处也显示层数和秒伤,比如40层50000秒伤 显示格式为: 40层(50000/秒)
            rankRunRace.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
            {
                if (b.Value2 == a.Value2)
                {
                    return (int)b.Value2 - (int)a.Value2;
                }
                else
                {
                    return (int)b.Value - (int)a.Value;
                }
            });

            int maxnumber = Math.Min(rankRunRace.Count, 100);
            rankSceneComponent.DBRankInfo.rankingTrial = rankRunRace.GetRange(0, maxnumber);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
