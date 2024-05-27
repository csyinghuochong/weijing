using System;
using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    public class C2Center_QueryAccountHandler : AMRpcHandler<C2Center_QueryAccountRequest, Center2C_QueryAccountResponse>
    {
        protected override async ETTask Run(Session session, C2Center_QueryAccountRequest request, Center2C_QueryAccountResponse response, Action reply)
        {

            await ETTask.CompletedTask;
        }
    }
}
