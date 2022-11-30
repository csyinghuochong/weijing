using System;
using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 同意组队邀请
    /// </summary>
    [ActorMessageHandler]
    public class C2T_TeamAgreeHandler : AMActorRpcHandler<Scene, C2T_TeamAgreeRequest, T2C_TeamAgreeResponse>
    {

        protected override async ETTask Run(Scene scene, C2T_TeamAgreeRequest request, T2C_TeamAgreeResponse response, Action reply)
        {
            TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
            TeamInfo teamInfo = teamSceneComponent.GetTeamInfo(request.TeamPlayerInfo_1.UserID);

            //不是队长。无法开组
            if (teamInfo != null && teamInfo.TeamId != request.TeamPlayerInfo_1.UserID)
            {
                reply();
                return;
            }
            if (teamInfo == null)
            {
                teamInfo = teamSceneComponent.CreateTeamInfo(request.TeamPlayerInfo_1, 0);
            }
            teamInfo.PlayerList.Add(request.TeamPlayerInfo_2);

            teamSceneComponent.SyncTeamInfo(teamInfo, teamInfo.PlayerList).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
