using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_StallBuyHandler: AMActorRpcHandler<Scene, M2P_StallBuyRequest, P2M_StallBuyResponse>
    {
        protected override async ETTask Run(Scene scene, M2P_StallBuyRequest request, P2M_StallBuyResponse response, Action reply)
        {
            long needGold = 0;
            PaiMaiItemInfo paiMaiItemInfo = null;
            List<PaiMaiItemInfo> stallItemInfos = scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.StallItemInfos;
            for (int i = stallItemInfos.Count - 1; i >= 0; i--)
            {
                if (stallItemInfos[i].Id == request.PaiMaiItemInfo.Id)
                {
                    paiMaiItemInfo = stallItemInfos[i];
                    break;
                }
            }

            if (paiMaiItemInfo == null)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            needGold = (long)paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            if (request.ActorId < needGold)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            response.PaiMaiItemInfo = paiMaiItemInfo;
            stallItemInfos.Remove(paiMaiItemInfo);
            reply();
            await ETTask.CompletedTask;
        }
    }
}