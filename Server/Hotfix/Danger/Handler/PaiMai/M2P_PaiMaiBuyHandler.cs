using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_PaiMaiBuyHandler : AMActorRpcHandler<Scene, M2P_PaiMaiBuyRequest, P2M_PaiMaiBuyResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiBuyRequest request, P2M_PaiMaiBuyResponse response, Action reply)
        {
            long needGold = 0 ;
            PaiMaiItemInfo paiMaiItemInfo = null;
            List<PaiMaiItemInfo> paiMaiItemInfos =  scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.PaiMaiItemInfos;
            for (int i = paiMaiItemInfos.Count - 1; i >= 0; i--)
            {
                if (paiMaiItemInfos[i].Id == request.PaiMaiItemInfo.Id)
                {
                    paiMaiItemInfo = paiMaiItemInfos[i];
                    break;
                }
            }
            if (paiMaiItemInfo == null)
            {
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            needGold = (long)paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            if (request.ActorId < needGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            response.PaiMaiItemInfo = paiMaiItemInfo;
            paiMaiItemInfos.Remove(paiMaiItemInfo);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
