using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiXiaJiaHandler : AMActorRpcHandler<Scene, M2P_PaiMaiXiaJiaRequest, P2M_PaiMaiXiaJiaResponse>
    {
        protected override async ETTask Run(Scene scene, M2P_PaiMaiXiaJiaRequest request, P2M_PaiMaiXiaJiaResponse response, Action reply)
        {
            List<PaiMaiItemInfo> paiMaiItemInfo = scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.PaiMaiItemInfos;

            for (int i = paiMaiItemInfo.Count - 1; i >= 0; i--)
            {
                if (paiMaiItemInfo[i].Id == request.PaiMaiItemInfoId)
                {
                    PaiMaiItemInfo paiMaiItemInfo1 = paiMaiItemInfo[i];
                    response.PaiMaiItemInfo = paiMaiItemInfo1;
                    paiMaiItemInfo.RemoveAt(i);
                    break;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
