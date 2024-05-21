using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2P_PaiMaiSearchHandler: AMActorRpcHandler<Scene, C2P_PaiMaiSearchRequest, P2C_PaiMaiSearchResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiSearchRequest request, P2C_PaiMaiSearchResponse response, Action reply)
        {
            if (request.FindTypeList.Count <= 0)
            {
                reply();
                return;
            }

            if (request.FindItemIdList.Count <= 0)
            {
                reply();
                return;
            }

            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            foreach (int type in request.FindTypeList)
            {
                DBPaiMainInfo dBPaiMainInfo = paiMaiComponent.GetPaiMaiDBByType(type);
                if (dBPaiMainInfo == null)
                {
                    reply();
                    return;
                }

                foreach (PaiMaiItemInfo paiMaiItemInfo in dBPaiMainInfo.PaiMaiItemInfos)
                {
                    if (request.FindItemIdList.Contains(paiMaiItemInfo.BagInfo.ItemID))
                    {
                        response.PaiMaiItemInfos.Add(paiMaiItemInfo);

                        if (response.PaiMaiItemInfos.Count > 200)
                        {
                            break;
                        }
                    }
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}