using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2T_TeamDungeonCreateHandler : AMActorRpcHandler<Scene, C2T_TeamDungeonCreateRequest, T2C_TeamDungeonCreateResponse>
    {

        protected override async ETTask Run(Scene scene, C2T_TeamDungeonCreateRequest request, T2C_TeamDungeonCreateResponse response, Action reply)
        {
            List<TeamInfo> teamList = scene.GetComponent<TeamSceneComponent>().TeamList;
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo(request.TeamPlayerInfo.UserID);
            if (teamInfo != null && teamInfo.TeamId != request.TeamPlayerInfo.UserID)
            {
                //非队长
                reply();
                return;
            }

            //无队伍
            if (teamInfo == null)
            {
                teamInfo = new TeamInfo() { TeamId = request.TeamPlayerInfo.UserID, SceneId = request.FubenId };
                teamInfo.PlayerList.Add(request.TeamPlayerInfo);
                teamList.Add(teamInfo);
            }
            else
            {
                teamInfo.SceneId = request.FubenId;
            }

            M2C_TeamUpdateResult m2C_HorseNoticeInfo = new M2C_TeamUpdateResult() { TeamInfo = teamInfo };
            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), "Gate1").InstanceId;
            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = teamInfo.PlayerList[i].UserID
                    });

                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
                }
            }

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
