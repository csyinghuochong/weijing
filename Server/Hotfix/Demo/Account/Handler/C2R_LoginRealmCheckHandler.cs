using System;

namespace ET
{
    public class C2R_LoginRealmCheckHandler : AMRpcHandler<C2R_LoginRealmCheck, R2C_LoginRealmCheck>
    {
        protected override async ETTask Run(Session session, C2R_LoginRealmCheck request, R2C_LoginRealmCheck response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}
