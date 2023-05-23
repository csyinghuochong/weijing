using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2S_SoloEnterHandler : AMActorRpcHandler<Scene, M2S_SoloEnterRequest, S2M_SoloEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2S_SoloEnterRequest request, S2M_SoloEnterResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
