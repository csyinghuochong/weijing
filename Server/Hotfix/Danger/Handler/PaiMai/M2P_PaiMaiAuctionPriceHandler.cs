using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_PaiMaiAuctionPriceHandler : AMActorHandler<Scene, M2P_PaiMaiAuctionPriceRequest>
    {
        protected override async ETTask Run(Scene scene, M2P_PaiMaiAuctionPriceRequest message)
        {
            PaiMaiSceneComponent paiMaiSceneComponent = scene.GetComponent<PaiMaiSceneComponent>();
            if (paiMaiSceneComponent.AuctionStatus != 1)
            {
                return;
            }
            if (paiMaiSceneComponent.AuctionPrice > message.Price)
            {
                return;
            }
            paiMaiSceneComponent.AuctionPrice = message.Price;
            paiMaiSceneComponent.AuctioUnitId = message.UnitID;
            paiMaiSceneComponent.AuctionPlayer = message.AuctionPlayer;
            ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(scene.DomainZone()), NoticeType.PaiMaiAuction,
                $"{paiMaiSceneComponent.AuctionItem}_{paiMaiSceneComponent.AuctionItemNum}_{message.Price}_{paiMaiSceneComponent.AuctionPlayer}_1").Coroutine();
            await ETTask.CompletedTask;
        }
    }
}
