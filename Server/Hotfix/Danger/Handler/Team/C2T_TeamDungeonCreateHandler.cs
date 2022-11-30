using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2T_TeamDungeonCreateHandler : AMActorRpcHandler<Scene, C2T_TeamDungeonCreateRequest, T2C_TeamDungeonCreateResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_TeamDungeonCreateRequest request, T2C_TeamDungeonCreateResponse response, Action reply)
        {
            TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
            TeamInfo teamInfo = teamSceneComponent.GetTeamInfo(request.TeamPlayerInfo.UserID);
            if (teamInfo != null && teamInfo.TeamId != request.TeamPlayerInfo.UserID)
            {
                //非队长
                reply();
                return;
            }

            //无队伍
            if (teamInfo == null)
            {
                teamInfo = teamSceneComponent.CreateTeamInfo(request.TeamPlayerInfo, request.FubenId);
            }
            else
            {
                teamInfo.SceneId = request.FubenId;
            }

            teamSceneComponent.SyncTeamInfo(teamInfo, teamInfo.PlayerList).Coroutine();

            //启动机器人
            long robotSceneId = DBHelper.GetRobotServerId();
            MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = scene.DomainZone(),
                MessageType = NoticeType.TeamDungeon,
                Message = $"{teamInfo.SceneId}_{teamInfo.TeamId}"});

            reply();
            await ETTask.CompletedTask;
        }
    }
}
