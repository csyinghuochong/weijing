using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiAuctionPriceHandler : AMActorLocationHandler<Unit, C2M_PaiMaiAuctionPriceRequest>
    {
        protected override async ETTask Run(Unit unit, C2M_PaiMaiAuctionPriceRequest request)
        {
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Gold < request.Price)
            {
                return;
            }
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            M2P_PaiMaiAuctionPriceRequest message = new M2P_PaiMaiAuctionPriceRequest()
            {
                Price = request.Price,
                UnitID = unit.Id, 
                Occ = userInfoComponent.UserInfo.Occ,
                AuctionPlayer = userInfoComponent.UserInfo.Name,
            };
            long activiyServerId = DBHelper.GetPaiMaiServerId(unit.DomainZone());
            MessageHelper.SendActor(activiyServerId, message);
            await ETTask.CompletedTask;
        }
    }
}
