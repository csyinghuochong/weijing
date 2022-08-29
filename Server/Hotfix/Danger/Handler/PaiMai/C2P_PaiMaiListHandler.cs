using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2P_PaiMaiListHandler : AMActorRpcHandler<Scene, C2P_PaiMaiListRequest, P2C_PaiMaiListResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiListRequest request, P2C_PaiMaiListResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            List<PaiMaiItemInfo> PaiMaiItemInfo = paiMaiComponent.dBPaiMainInfo.PaiMaiItemInfos;

            //int32 PaiMaiType = 2;    //1自己 2所有
            if (request.PaiMaiType == 1)
            {
                List<PaiMaiItemInfo> paiMaiItemsTo = new List<PaiMaiItemInfo>();
                for (int i = 0; i < PaiMaiItemInfo.Count; i++)
                {
                    if (PaiMaiItemInfo[i].UserId == request.UserId)
                    {
                        paiMaiItemsTo.Add(PaiMaiItemInfo[i]);
                    }
                }
                response.PaiMaiItemInfos = paiMaiItemsTo;
            }
            else
            {
                response.PaiMaiItemInfos = PaiMaiItemInfo;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
