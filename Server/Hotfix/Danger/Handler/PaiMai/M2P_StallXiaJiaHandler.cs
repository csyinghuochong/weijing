using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_StallXiaJiaHandler: AMActorRpcHandler<Scene, M2P_StallXiaJiaRequest, P2M_StallXiaJiaResponse>
    {
        protected override async ETTask Run(Scene scene, M2P_StallXiaJiaRequest request, P2M_StallXiaJiaResponse response, Action reply)
        {
            List<PaiMaiItemInfo> StallItemInfos = scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.StallItemInfos;

            for (int i = StallItemInfos.Count - 1; i >= 0; i--)
            {
                if (StallItemInfos[i].Id == request.PaiMaiItemInfoId)
                {
                    PaiMaiItemInfo paiMaiItemInfo1 = StallItemInfos[i];
                    response.PaiMaiItemInfo = paiMaiItemInfo1;
                    StallItemInfos.RemoveAt(i);
                    break;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}