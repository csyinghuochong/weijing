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

            //此处在消息中转的地方把ActorId赋值了unitID
            if (soloSceneComponent.AllPlayerDateList.ContainsKey(request.ActorId))
            {

                response.WinTime = soloSceneComponent.AllPlayerDateList[request.ActorId].WinNum;
                response.FailTime = soloSceneComponent.AllPlayerDateList[request.ActorId].FailNum;
            }

            //积分
            if (soloSceneComponent.PlayerIntegralList.ContainsKey(request.ActorId))
            {
                response.MathTime = soloSceneComponent.PlayerIntegralList[request.ActorId];
            }

            response.SoloPlayerResultInfoList = soloSceneComponent.GetSoloResult();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
