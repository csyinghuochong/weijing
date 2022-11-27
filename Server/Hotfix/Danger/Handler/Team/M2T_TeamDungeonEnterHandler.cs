using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2T_TeamDungeonEnterHandler : AMActorRpcHandler<Scene, M2T_TeamDungeonEnterRequest, T2M_TeamDungeonEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2T_TeamDungeonEnterRequest request, T2M_TeamDungeonEnterResponse response, Action reply)
        {
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo( request.UserID );
            if (teamInfo == null)
            {
                response.Error = ErrorCore.ERR_TransferFailError;
                reply();
                return;
            }
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.NewRobot, teamInfo.TeamId))
            {
                if (teamInfo.FubenInstanceId == 0)
                {
                    scene.GetComponent<TeamSceneComponent>().CreateTeamDungeon(teamInfo);
                }
                response.FubenId = teamInfo.SceneId;
                response.FubenInstanceId = teamInfo.FubenInstanceId;
                reply();
                await ETTask.CompletedTask;
                Log.Debug($"TeamDungeonEnter.UserID:  {request.UserID} {teamInfo.TeamId} {teamInfo.FubenInstanceId}");
            }
        }
    }
}
