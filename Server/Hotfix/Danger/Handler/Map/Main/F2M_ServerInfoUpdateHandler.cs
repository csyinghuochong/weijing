using System;

namespace ET
{

    [ActorMessageHandler]
    public class F2M_ServerInfoUpdateHandler : AMActorRpcHandler<Scene, F2M_ServerInfoUpdateRequest, M2F_ServerInfoUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, F2M_ServerInfoUpdateRequest request, M2F_ServerInfoUpdateResponse response, Action reply)
        {
            scene.GetComponent<ServerInfoComponent>().ServerInfo = request.ServerInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
