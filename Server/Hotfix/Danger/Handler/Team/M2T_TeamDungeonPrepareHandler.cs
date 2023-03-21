using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2T_TeamDungeonPrepareHandler : AMActorRpcHandler<Scene, M2T_TeamDungeonPrepareRequest, T2M_TeamDungeonPrepareResponse>
    {
        protected override async ETTask Run(Scene scene, M2T_TeamDungeonPrepareRequest request, T2M_TeamDungeonPrepareResponse response, Action reply)
        {
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo(request.TeamId);
            if (teamInfo == null)
            {
                Log.Debug($"M2T_TeamDungeonPrepare: teamInfo == null");
                response.Error = ErrorCore.Err_TeamIsNull;
                reply();
                return;
            }

            //0未选择 1同意 2拒绝
            int errorCode = request.ErrorCode;
            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                if (teamInfo.PlayerList[i].UserID == request.UnitID)
                {
                    teamInfo.PlayerList[i].Prepare = request.Prepare;
                }
            }
            for(int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                if (teamInfo.PlayerList[i].Prepare == 2)
                {
                    errorCode = ErrorCore.Err_PlayerRefuse;
                    break;
                }
                if (teamInfo.PlayerList[i].Prepare == 0)
                {
                    errorCode = ErrorCore.Err_HaveNotPrepare;
                    break;
                }
            }

            M2C_TeamDungeonPrepareResult m2C_HorseNoticeInfo = new M2C_TeamDungeonPrepareResult()
            {
                TeamInfo = teamInfo,
                ErrorCode = errorCode,
            };
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
            response.TeamInfo = teamInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
