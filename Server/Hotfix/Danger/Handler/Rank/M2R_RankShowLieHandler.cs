using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2R_RankShowLieHandler : AMActorRpcHandler<Scene, M2R_RankShowLieRequest, R2M_RankShowLieResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_RankShowLieRequest request, R2M_RankShowLieResponse response, Action reply)
        {
            RankSceneComponent rankSceneComponent = scene.GetComponent<RankSceneComponent>();
            DBRankInfo dBRankInfo = rankSceneComponent.DBRankInfo;

            bool have = false;
            for (int i = 0; i < dBRankInfo.rankShowLie.Count; i++)
            {
                if (dBRankInfo.rankShowLie[i].UnitID == request.RankingInfo.UnitID)
                {
                    dBRankInfo.rankShowLie[i].KillNumber = request.RankingInfo.KillNumber;
                    have = true;
                    break;
                }
            }

            if (!have)
            {
                dBRankInfo.rankShowLie.Add(request.RankingInfo);
            }

            dBRankInfo.rankShowLie.Sort(delegate (RankShouLieInfo a, RankShouLieInfo b)
            {
                return (int)b.KillNumber - (int)a.KillNumber;
            });

            int maxnumber = Math.Min( dBRankInfo.rankShowLie.Count, 10 );
            dBRankInfo.rankShowLie = dBRankInfo.rankShowLie.GetRange( 0, maxnumber );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
