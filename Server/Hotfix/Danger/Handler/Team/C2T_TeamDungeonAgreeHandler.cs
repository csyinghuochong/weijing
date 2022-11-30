using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2T_TeamDungeonAgreeHandler : AMActorRpcHandler<Scene, C2T_TeamDungeonAgreeRequest, T2C_TeamDungeonAgreeResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_TeamDungeonAgreeRequest request, T2C_TeamDungeonAgreeResponse response, Action reply)
        {
            TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
            if (teamSceneComponent.GetTeamInfo(request.TeamPlayerInfo.UserID) != null)
            {
                response.Error = ErrorCore.ERR_IsHaveTeam;
                reply();
                return;
            }

            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), "Gate1").InstanceId;
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = request.TeamPlayerInfo.UserID
                    });
            if (g2M_UpdateUnitResponse.PlayerState != (int)PlayerState.Game || g2M_UpdateUnitResponse.SessionInstanceId == 0)
            {
                //对方已下线
                reply();
                return;
            }

            TeamInfo teamInfo = teamSceneComponent.GetTeamInfo(request.TeamId);
            if (teamInfo == null || teamInfo.PlayerList.Count == 3)
            {
                reply();
                return;
            }

            teamInfo.PlayerList.Add(request.TeamPlayerInfo);
            teamSceneComponent.SyncTeamInfo(teamInfo,teamInfo.PlayerList).Coroutine();
            reply();
        }
    }
}
