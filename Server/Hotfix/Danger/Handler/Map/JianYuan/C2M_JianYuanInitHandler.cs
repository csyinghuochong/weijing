using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_JianYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JianYuanInitRequest, M2C_JianYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JianYuanInitRequest request, M2C_JianYuanInitResponse response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}
