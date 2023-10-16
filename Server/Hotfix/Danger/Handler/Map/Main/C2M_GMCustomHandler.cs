using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_GMCustomHandler : AMActorLocationRpcHandler<Unit, C2M_GMCustomRequest, M2C_GMCustomResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_GMCustomRequest request, M2C_GMCustomResponse response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}