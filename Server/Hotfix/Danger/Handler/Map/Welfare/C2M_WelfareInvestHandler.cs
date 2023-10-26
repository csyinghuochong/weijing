using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_WelfareInvestHandler : AMActorLocationRpcHandler<Unit, C2M_WelfareInvestRequest, M2C_WelfareInvestResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareInvestRequest request, M2C_WelfareInvestResponse response, Action reply)
        {
            if (request.Index < 0 || request.Index >= ConfigHelper.WelfareInvestList.Count)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            if (unit.GetComponent<UserInfoComponent>().UserInfo.WelfareInvestList.Contains(request.Index))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            int ment = ConfigHelper.WelfareInvestList[request.Index];
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold <= ment)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub( UserDataType.Gold,(ment * -1).ToString(), true, ItemGetWay.Welfare );
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.InvestMent, ment, 0);
            unit.GetComponent<UserInfoComponent>().UserInfo.WelfareInvestList.Add(request.Index);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
