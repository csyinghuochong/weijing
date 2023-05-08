using System;

namespace ET
{
 
    [ActorMessageHandler]
    public class P2M_PaiMaiAuctionOverHandler : AMActorRpcHandler<Unit, P2M_PaiMaiAuctionOverRequest, M2P_PaiMaiAuctionOverResponse>
    {
        protected override async ETTask Run(Unit unit, P2M_PaiMaiAuctionOverRequest request, M2P_PaiMaiAuctionOverResponse response, Action reply)
        {
            Log.Debug($"PaiMaiAuctionOver:  {unit.DomainZone()} {unit.Id}");
            
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Gold < request.Price)
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Message, "金币不足，竞拍失败！");
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
            }
            else
            {
                userInfoComponent.UpdateRoleMoneySub( UserDataType.Gold, (request.Price * -1).ToString(), true, ItemGetWay.Auction );
                Log.Console($"扣除竞拍价：{request.Price}");
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
