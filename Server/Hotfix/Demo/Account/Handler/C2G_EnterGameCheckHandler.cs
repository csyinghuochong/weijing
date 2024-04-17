using System;

namespace ET
{
    public class C2G_EnterGameCheckHandler : AMRpcHandler<C2G_EnterGameCheck, G2C_EnterGameCheck>
    {
        protected override async ETTask Run(Session session, C2G_EnterGameCheck request, G2C_EnterGameCheck response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}
