using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_TeamAgreeHandler : AMActorRpcHandler<Scene, C2T_TeamAgreeRequest, T2C_TeamAgreeResponse>
    {

        protected override async ETTask Run(Scene scene, C2T_TeamAgreeRequest request, T2C_TeamAgreeResponse response, Action reply)
        {
          
            List<TeamInfo> teamList = scene.GetComponent<TeamSceneComponent>().TeamList;
            TeamInfo teamInfo = null;
            for (int i = 0; i < teamList.Count; i++)
            {
                if (teamList[i].TeamId == request.TeamPlayerInfo_1.UserID)
                {
                    teamInfo = teamList[i];
                }
            }
            if (teamInfo == null)
            {
                teamInfo = new TeamInfo() { TeamId = request.TeamPlayerInfo_1.UserID };
                teamInfo.PlayerList.Add(request.TeamPlayerInfo_1);
                teamList.Add(teamInfo);
            }
            teamInfo.PlayerList.Add(request.TeamPlayerInfo_2);

            M2C_TeamUpdateResult m2C_HorseNoticeInfo = new M2C_TeamUpdateResult() {  TeamInfo = teamInfo };
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

            reply();
            await ETTask.CompletedTask;
        }
    }
}
