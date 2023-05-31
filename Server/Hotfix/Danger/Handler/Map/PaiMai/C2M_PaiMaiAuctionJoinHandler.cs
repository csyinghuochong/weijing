using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiAuctionJoinHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiAuctionJoinRequest, M2C_PaiMaiAuctionJoinResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PaiMaiAuctionJoinRequest request, M2C_PaiMaiAuctionJoinResponse response, Action reply)
        {
            long paimaiserverid = DBHelper.GetPaiMaiServerId( unit.DomainZone() );
            P2M_PaiMaiAuctionJoinResponse r_GameStatusResponse = (P2M_PaiMaiAuctionJoinResponse)await ActorMessageSenderComponent.Instance.Call
                    (paimaiserverid, new M2P_PaiMaiAuctionJoinRequest()
                    {
                        UnitID = unit.Id,
                        Gold = unit.GetComponent<UserInfoComponent>().UserInfo.Gold
                    });

            if (r_GameStatusResponse.Error == ErrorCore.ERR_Success)
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold,  (-1 * r_GameStatusResponse.CostGold).ToString(), true, ItemGetWay.AuctionJoin);
            }
            response.Error = r_GameStatusResponse.Error;    
            reply();
            await ETTask.CompletedTask;
        }
    }
}
