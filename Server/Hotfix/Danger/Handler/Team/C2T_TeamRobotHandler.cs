using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_TeamRobotHandler : AMActorRpcHandler<Scene, C2T_TeamRobotRequest, T2C_TeamRobotResponse>
    {
        protected override async ETTask Run(Scene scene, C2T_TeamRobotRequest request, T2C_TeamRobotResponse response, Action reply)
        {
            TeamSceneComponent teamSceneComponent = scene.GetComponent<TeamSceneComponent>();
            TeamInfo teamInfo = teamSceneComponent.GetTeamInfo(request.UnitId);
            if (teamInfo == null)
            {
                response.Error = ErrorCore.Err_TeamIsNull;
                reply();
                return;
            }

            long robotSceneId = DBHelper.GetRobotServerId();
            MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest()
            {
                Zone = scene.DomainZone(),
                MessageType = NoticeType.TeamDungeon,
                Message = $"{teamInfo.SceneId}_{teamInfo.TeamId}"
            });

            reply();
            await ETTask.CompletedTask;

        }
    }
}
