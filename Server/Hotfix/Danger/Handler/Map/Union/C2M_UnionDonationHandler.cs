using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_UnionDonationHandler : AMActorLocationRpcHandler<Unit, C2M_UnionDonationRequest, M2C_UnionDonationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionDonationRequest request, M2C_UnionDonationResponse response, Action reply)
        {
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < request.Price)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber) >= 10)
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyChange(unit, NumericType.UnionDonationNumber, 1, 0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (request.Price * -1).ToString(), true, ItemGetWay.Donation);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.UnionZiJin, "10", true, ItemGetWay.Donation);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
