using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2F_FubenCenterListHandler : AMActorRpcHandler<Scene, M2F_FubenCenterListRequest, F2M_FubenCenterListResponse>
    {
        protected override async ETTask Run(Scene scene, M2F_FubenCenterListRequest request, F2M_FubenCenterListResponse response, Action reply)
        {
            response.FubenInstanceList = scene.GetComponent<FubenCenterComponent>().FubenInstanceList;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
