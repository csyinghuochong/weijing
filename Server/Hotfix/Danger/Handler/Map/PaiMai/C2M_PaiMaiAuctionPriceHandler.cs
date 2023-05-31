using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiAuctionPriceHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiAuctionPriceRequest, M2C_PaiMaiAuctionPriceResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PaiMaiAuctionPriceRequest request, M2C_PaiMaiAuctionPriceResponse response, Action reply)
        {
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Gold < request.Price)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
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
            long paimaiserverid = DBHelper.GetPaiMaiServerId(unit.DomainZone());
            P2M_PaiMaiAuctionPriceResponse r_GameStatusResponse = (P2M_PaiMaiAuctionPriceResponse)await ActorMessageSenderComponent.Instance.Call
                    (paimaiserverid, message);

            response.Error = r_GameStatusResponse.Error;
            reply();
            return;
        }
    }
}
