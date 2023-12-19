using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_ActivityGuessHandler : AMActorRpcHandler<Scene, M2A_ActivityGuessRequest, A2M_ActivityGuessResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_ActivityGuessRequest request, A2M_ActivityGuessResponse response, Action reply)
        {
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
