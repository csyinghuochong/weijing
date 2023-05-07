using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2S_SoloMatchHandler : AMActorRpcHandler<Scene, M2S_SoloMatchRequest, S2M_SoloMatchResponse>
    {
        protected override async ETTask Run(Scene scene, M2S_SoloMatchRequest request, S2M_SoloMatchResponse response, Action reply)
        {
            scene.GetComponent<SoloSceneComponent>().OnJoinMatch(request.SoloPlayerInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
