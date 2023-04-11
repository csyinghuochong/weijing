using System;
using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    public class C2A_TianQiHandler : AMRpcHandler<C2A_TianQiRequest, A2C_TianQiResponse>
    {
        protected override async ETTask Run(Session session, C2A_TianQiRequest request, A2C_TianQiResponse response, Action reply)
        {
            response.TianQiValue = session.DomainScene().GetComponent<AccountCenterComponent>().TianQiValue;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
