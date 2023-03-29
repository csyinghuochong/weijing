using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanMakeHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanMakeRequest, M2C_JiaYuanMakeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanMakeRequest request, M2C_JiaYuanMakeResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
