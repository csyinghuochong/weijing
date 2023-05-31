using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_PaiMaiAuctionPriceHandler : AMActorRpcHandler<Scene, M2P_PaiMaiAuctionPriceRequest, P2M_PaiMaiAuctionPriceResponse>
    {
        protected override async ETTask Run(Scene scene, M2P_PaiMaiAuctionPriceRequest message, P2M_PaiMaiAuctionPriceResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiSceneComponent = scene.GetComponent<PaiMaiSceneComponent>();
            if (paiMaiSceneComponent.AuctionStatus != 1)
            {
                response.Error = ErrorCore.Err_Auction_Finish;
                reply();
                return;
            }
            if (paiMaiSceneComponent.AuctionPrice >= message.Price)
            {
                response.Error = ErrorCore.Err_Auction_Low;
                reply();
                return;
            }

            paiMaiSceneComponent.AuctionPrice = message.Price;
            paiMaiSceneComponent.AuctioUnitId = message.UnitID;
            paiMaiSceneComponent.AuctionPlayer = message.AuctionPlayer;

            PaiMaiAuctionRecord keyValuePair = new PaiMaiAuctionRecord();
            keyValuePair.UnionId = message.UnitID;
            keyValuePair.Price = message.Price;
            keyValuePair.Time = TimeHelper.ServerNow();
            keyValuePair.Occ = message.Occ;
            keyValuePair.PlayerName = message.AuctionPlayer;
            paiMaiSceneComponent.AuctionRecords.Add(keyValuePair);
            ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(scene.DomainZone()), NoticeType.PaiMaiAuction,
                $"{paiMaiSceneComponent.AuctionItem}_{paiMaiSceneComponent.AuctionItemNum}_{message.Price}_{paiMaiSceneComponent.AuctionPlayer}_1").Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
