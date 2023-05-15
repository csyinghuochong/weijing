using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_UnionDonationHandler : AMActorLocationRpcHandler<Unit, C2M_UnionDonationRequest, M2C_UnionDonationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionDonationRequest request, M2C_UnionDonationResponse response, Action reply)
        {

            //获取家族等级
            long unionid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
            if (unionid == 0)
            {
                return;
            }

            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber) >= 15)
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            long selfgold = unit.GetComponent<UserInfoComponent>().UserInfo.Gold;
            U2M_UnionOperationResponse responseUnionEnter = (U2M_UnionOperationResponse)await ActorMessageSenderComponent.Instance.Call(
                            DBHelper.GetUnionServerId(unit.DomainZone()), new M2U_UnionOperationRequest() { OperateType = 3, UnitId = unit.Id, UnionId = unionid, Par = selfgold.ToString() });


            if (responseUnionEnter.Error != ErrorCore.ERR_Success)
            {
                response.Error = responseUnionEnter.Error;
                reply();
                return;
            }

            int unionID = int.Parse(responseUnionEnter.Par);
            UnionConfig unionCof = UnionConfigCategory.Instance.Get(unionID);
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
