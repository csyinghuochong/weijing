using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2P_StallListHandler: AMActorRpcHandler<Scene, C2P_StallListRequest, P2C_StallListResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_StallListRequest request, P2C_StallListResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            List<PaiMaiItemInfo> StallItemInfos = paiMaiComponent.dBPaiMainInfo.StallItemInfos;

            List<PaiMaiItemInfo> paiMaiItemInfos = new List<PaiMaiItemInfo>();
            for (int i = 0; i < StallItemInfos.Count; i++)
            {
                if (StallItemInfos[i].UserId == request.UserId)
                {
                    paiMaiItemInfos.Add(StallItemInfos[i]);
                }
            }

            response.PaiMaiItemInfos = paiMaiItemInfos;
            reply();
            await ETTask.CompletedTask;
        }
    }
}