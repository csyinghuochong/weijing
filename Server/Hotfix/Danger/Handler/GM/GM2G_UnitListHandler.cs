using System;

namespace ET
{
    [ActorMessageHandler]
    public class GM2G_UnitListHandler : AMActorRpcHandler<Scene, G2G_UnitListRequest, G2G_UnitListResponse>
    {
        protected override async ETTask Run(Scene scene, G2G_UnitListRequest request, G2G_UnitListResponse response, Action reply)
        {
            response.OnLinePlayer = scene.GetComponent<PlayerComponent>().GetAll().Length;

            reply();
            await ETTask.CompletedTask;
        }

    }
}
