using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_TeamLeaveHanlder : AMActorRpcHandler<Scene, C2T_TeamLeaveRequest, T2C_TeamLeaveResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_TeamLeaveRequest request, T2C_TeamLeaveResponse response, Action reply)
        {
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo(request.UserId);
            scene.GetComponent<TeamSceneComponent>().OnRecvUnitLeave(request.UserId).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
