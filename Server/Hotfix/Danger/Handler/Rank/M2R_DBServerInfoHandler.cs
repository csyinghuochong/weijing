using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2R_DBServerInfoHandler : AMActorRpcHandler<Scene, M2R_DBServerInfoRequest, R2M_DBServerInfoResponse>
    {
        protected override async ETTask Run(Scene scene, M2R_DBServerInfoRequest request, R2M_DBServerInfoResponse response, Action reply)
        {
            DBServerInfo dBServerInfo = scene.GetComponent<RankSceneComponent>().DBServerInfo;
            response.ServerInfo = dBServerInfo.ServerInfo;
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
