using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2T_TeamDungeonOpenHandler : AMActorRpcHandler<Scene, M2T_TeamDungeonOpenRequest, T2M_TeamDungeonOpenResponse>
    {
        protected override async ETTask Run(Scene scene, M2T_TeamDungeonOpenRequest request, T2M_TeamDungeonOpenResponse response, Action reply)
        {
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo(request.UserID);
            if (teamInfo == null)
            {
                Log.Debug($"M2T_TeamDungeonOpen: teamInfo == null");
                response.Error = ErrorCore.ERR_TeamIsFull;
                reply();
                return;
            }
            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                teamInfo.PlayerList[i].Prepare = teamInfo.PlayerList[i].UserID == teamInfo.TeamId ? 1 : 0;
            }

            teamInfo.FubenType = request.FubenType;
            M2C_TeamDungeonOpenResult m2C_HorseNoticeInfo = new M2C_TeamDungeonOpenResult() { TeamInfo = teamInfo  };
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
