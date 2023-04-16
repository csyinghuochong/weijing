using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2P_PaiMaiAuctionInfoHandler : AMActorRpcHandler<Scene, C2P_PaiMaiAuctionInfoRequest, P2C_PaiMaiAuctionInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiAuctionInfoRequest request, P2C_PaiMaiAuctionInfoResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiSceneComponent = scene.GetComponent<PaiMaiSceneComponent>();
            response.AuctionStatus  = paiMaiSceneComponent.AuctionStatus;
            response.AuctionPrice   = paiMaiSceneComponent.AuctionPrice;
            response.AuctionItem    = paiMaiSceneComponent.AuctionItem;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
