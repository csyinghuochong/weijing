using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2J_JiaYuanEnterHandler : AMActorRpcHandler<Scene, M2J_JiaYuanEnterRequest, J2M_JiaYuanEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2J_JiaYuanEnterRequest request, J2M_JiaYuanEnterResponse response, Action reply)
        {
            response.FubenInstanceId = await scene.GetComponent<JiaYuanSceneComponent>().GetJiaYuanFubenId(request.MasterId);
            reply();
        }
    }
}
