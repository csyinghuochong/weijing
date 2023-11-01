using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_WelfareInvestRewardHandler : AMActorLocationRpcHandler<Unit, C2M_WelfareInvestRewardRequest, M2C_WelfareInvestRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareInvestRewardRequest request, M2C_WelfareInvestRewardResponse response, Action reply)
        {
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.InvestReward) == 1)
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            int total = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.InvestTotal);
          
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Gold, total.ToString(), true, ItemGetWay.Welfare);
            unit.GetComponent<NumericComponent>().ApplyValue(null, NumericType.InvestReward, 1, 0);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
