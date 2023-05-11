using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_DonationRequestHandler : AMActorLocationRpcHandler<Unit, C2M_DonationRequest, M2C_DonationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_DonationRequest request, M2C_DonationResponse response, Action reply)
        {

            if (request.Price < 100000)
            {
                reply();
                return;
            }
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < request.Price)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            //using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Donation, unit.Id))
            //{

            //}
            request.UnitId = unit.Id;
            long serverid = DBHelper.GetUnionServerId(unit.DomainZone());
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            RankingInfo rankingInfo = new RankingInfo()
            {
                Combat = request.Price,
                UserId = unit.Id,
                PlayerLv = userInfo.Lv,
                PlayerName = userInfo.Name, 
                Occ = userInfo.Occ, 
            };
            U2M_DonationResponse d2GGetUnit = (U2M_DonationResponse)await ActorMessageSenderComponent.Instance.Call(serverid,
                new M2U_DonationRequest() { RankingInfo = rankingInfo }
                );

            if (d2GGetUnit.Error != ErrorCore.ERR_Success)
            {
                response.Error = d2GGetUnit.Error;
                reply();
                return;
            }
            unit.GetComponent<NumericComponent>().ApplyChange(unit, NumericType.RaceDonationNumber, request.Price, 0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub( UserDataType.Gold,  (request.Price * -1).ToString(),true, ItemGetWay.Donation );
            reply();
            await ETTask.CompletedTask;
        }
    }
}
