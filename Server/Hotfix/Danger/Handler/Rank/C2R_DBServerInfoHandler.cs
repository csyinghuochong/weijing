using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2R_DBServerInfoHandler : AMActorRpcHandler<Scene, C2R_DBServerInfoRequest, R2C_DBServerInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_DBServerInfoRequest request, R2C_DBServerInfoResponse response, Action reply)
        {
            DBServerInfo dBServerInfo = scene.GetComponent<RankSceneComponent>().DBServerInfo;
            response.ServerInfo = dBServerInfo.ServerInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
