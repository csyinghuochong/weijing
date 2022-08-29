using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_GetTeamInfoHandler : AMActorRpcHandler<Scene, C2T_GetTeamInfoRequest, T2C_GetTeamInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_GetTeamInfoRequest request, T2C_GetTeamInfoResponse response, Action reply)
        {
            TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
            response.TeamInfo = teamSceneComponent.GetTeamInfo(request.UserID); 
            reply();
            await ETTask.CompletedTask;

        }
    }
}
