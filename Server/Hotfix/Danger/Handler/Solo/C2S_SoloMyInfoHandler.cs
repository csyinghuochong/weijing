using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2S_SoloMyInfoHandler : AMActorRpcHandler<Scene, C2S_SoloMyInfoRequest, S2C_SoloMyInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2S_SoloMyInfoRequest request, S2C_SoloMyInfoResponse response, Action reply)
        {
            SoloSceneComponent soloSceneComponent = scene.GetComponent<SoloSceneComponent>();

            response.MathTime = 0;
            response.WinTime = 1;
            response.FailTime = 0;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
