using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2M_AllPlayerListHandler : AMActorRpcHandler<Scene, M2M_AllPlayerListRequest, M2M_AllPlayerListResponse>
    {
        protected override async ETTask Run(Scene scene, M2M_AllPlayerListRequest request, M2M_AllPlayerListResponse response, Action reply)
        {
            response.AllPlayers = scene.GetComponent<UnitComponent>().AllPlayers;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
