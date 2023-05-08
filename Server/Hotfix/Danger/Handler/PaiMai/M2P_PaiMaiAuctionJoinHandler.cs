using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiAuctionJoinHandler : AMActorRpcHandler<Scene, M2P_PaiMaiAuctionJoinRequest, P2M_PaiMaiAuctionJoinResponse>
    {
        protected override async ETTask Run(Scene scene, M2P_PaiMaiAuctionJoinRequest request, P2M_PaiMaiAuctionJoinResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiSceneComponent = scene.GetComponent<PaiMaiSceneComponent>();
            long returngold = (int)(paiMaiSceneComponent.AuctionStart * 0.1f);
            if (returngold <= 0)
            {
                response.Error = ErrorCore.ERR_AlreadyFinish;
                reply();
                return;
            }
            if (request.Gold < returngold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            if (!paiMaiSceneComponent.AuctionJoinList.Contains(request.UnitID))
            {
                paiMaiSceneComponent.AuctionJoinList.Add(request.UnitID);
                response.CostGold = returngold; 
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
