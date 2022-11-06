using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_TeamDungeonApplyHandler : AMActorRpcHandler<Scene, C2T_TeamDungeonApplyRequest, T2C_TeamDungeonApplyResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_TeamDungeonApplyRequest request, T2C_TeamDungeonApplyResponse response, Action reply)
        {
            TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
            if (teamSceneComponent.GetTeamInfo(request.TeamPlayerInfo.UserID) != null)
            {
                reply();
                return;
            }

            TeamInfo teamInfo = teamSceneComponent.GetTeamInfo(request.TeamId);
            if (teamInfo == null || teamInfo.PlayerList.Count == 3)
            {
                response.Error = ErrorCore.ERR_TeamIsFull;
                reply();
                return;
            }

            //判断次数
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGetUnit_1 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.TeamPlayerInfo.UserID, Component = DBHelper.UserInfoComponent });
            UserInfoComponent userinfo = d2GGetUnit_1.Component as UserInfoComponent;
            if (userinfo.UserInfo.TeamDungeonTimes >= int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value))
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            M2C_TeamDungeonApplyResult m2C_HorseNoticeInfo = new M2C_TeamDungeonApplyResult() { TeamPlayerInfo = request.TeamPlayerInfo };
            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), "Gate1").InstanceId;
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                  (gateServerId, new T2G_GateUnitInfoRequest()
                  {
                      UserID = teamInfo.TeamId
                  });
            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
            {
                MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
            }

            reply();
        }
    }
}
