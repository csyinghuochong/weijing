using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_UnionDonationHandler : AMActorLocationRpcHandler<Unit, C2M_UnionDonationRequest, M2C_UnionDonationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionDonationRequest request, M2C_UnionDonationResponse response, Action reply)
        {

            //获取家族等级
            U2M_UnionOperationResponse responseUnionEnter = (U2M_UnionOperationResponse)await ActorMessageSenderComponent.Instance.Call(
                            DBHelper.GetUnionServerId(unit.DomainZone()), new M2U_UnionOperationRequest() { OperateType = 2});

            if (responseUnionEnter.Par == "") {
                reply();
                return;
            }

            int unionID = int.Parse(responseUnionEnter.Par);

            if (unionID == 0)
            {
                reply();
                return;
            }

            UnionConfig unionCof = UnionConfigCategory.Instance.Get(unionID);

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < unionCof.DonateGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber) >= 5)
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyChange(unit, NumericType.UnionDonationNumber, 1, 0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (unionCof.DonateGold * -1).ToString(), true, ItemGetWay.Donation);
            int randNumExp = RandomHelper.RandomNumber(unionCof.DonateExp[0], unionCof.DonateExp[1]+1);
            int randNumGongXian = RandomHelper.RandomNumber(unionCof.DonateReward[0], unionCof.DonateReward[1] + 1);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.UnionZiJin, randNumGongXian.ToString(), true, ItemGetWay.Donation);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.UnionExp, randNumExp.ToString(), true, ItemGetWay.Donation);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
