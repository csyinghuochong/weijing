using System;

namespace ET
{

    [ActorMessageHandler]
    public class S2R_SoloResultHandler : AMActorRpcHandler<Scene, S2R_SoloResultRequest, R2S_SoloResultResponse>
    {
        protected override async ETTask Run(Scene scene, S2R_SoloResultRequest request, R2S_SoloResultResponse response, Action reply)
        {
            DBRankInfo dBRankInfo = scene.GetComponent<RankSceneComponent>().DBRankInfo;
            dBRankInfo.rankSoloInfo.Clear();
            dBRankInfo.rankSoloInfo.Add(request.RankingInfo);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
