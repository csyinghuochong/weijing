using System;
using System.Collections.Generic;


namespace ET
{
    public class C2Q_EnterQueueHandler : AMRpcHandler<C2Q_EnterQueue, Q2C_EnterQueue>
    {

        protected override async ETTask Run(Session session, C2Q_EnterQueue request, Q2C_EnterQueue response, Action reply)
        {
            session.RemoveComponent<SessionAcceptTimeoutComponent>(); //[不移除5秒后会dispose session。防外挂]

            session.DomainScene().GetComponent<QueueSessionsComponent>().Add(request.AccountId, session.InstanceId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
