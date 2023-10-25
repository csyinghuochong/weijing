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
            int ment = ConfigHelper.WelfareInvestList[request.Index];
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.InvestMent, ment, 0); 
            reply();
            await ETTask.CompletedTask;
        }
    }
}
