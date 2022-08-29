using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2R_WorldLvHandler : AMActorRpcHandler<Scene, C2R_WorldLvRequest, R2C_WorldLvResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_WorldLvRequest request, R2C_WorldLvResponse response, Action reply)
        {
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();
            response.ServerInfo = rankComponent.DBServerInfo.ServerInfo;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
