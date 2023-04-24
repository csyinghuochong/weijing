using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_DonationRequestHandler : AMActorLocationRpcHandler<Unit, C2M_DonationRequest, M2C_DonationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_DonationRequest request, M2C_DonationResponse response, Action reply)
        {
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < request.Price)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            //using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Donation, unit.Id))
            //{
               
            //}

            long serverid = DBHelper.GetRankServerId(unit.DomainZone());
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            RankingInfo rankingInfo = new RankingInfo()
            {
                Combat = request.Price,
                UserId = request.UnitId,
                PlayerLv = userInfo.Lv,
                PlayerName = userInfo.Name, 
            };
            R2M_DonationResponse d2GGetUnit = (R2M_DonationResponse)await ActorMessageSenderComponent.Instance.Call(serverid,
                new M2R_DonationRequest() { RankingInfo = rankingInfo }
                );

            if (d2GGetUnit.Error != ErrorCore.ERR_Success)
            {
                response.Error = d2GGetUnit.Error;
                reply();
                return;
            }
            unit.GetComponent<NumericComponent>().ApplyChange(unit, NumericType.DonationNumber, request.Price, 0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub( UserDataType.Gold,  (request.Price * -1).ToString(),true, ItemGetWay.Donation );
            reply();
            await ETTask.CompletedTask;
        }
    }
}
