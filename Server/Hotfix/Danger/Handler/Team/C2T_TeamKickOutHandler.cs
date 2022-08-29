using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_TeamKickOutHandler : AMActorRpcHandler<Scene, C2T_TeamKickOutRequest, T2C_TeamKickOutResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_TeamKickOutRequest request, T2C_TeamKickOutResponse response, Action reply)
        {
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo(request.UserId);
            scene.GetComponent<TeamSceneComponent>().OnRecvUnitLeave(request.UserId).Coroutine();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
