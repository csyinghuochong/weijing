using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2T_TeamDungeonEnterHandler : AMActorRpcHandler<Scene, M2T_TeamDungeonEnterRequest, T2M_TeamDungeonEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2T_TeamDungeonEnterRequest request, T2M_TeamDungeonEnterResponse response, Action reply)
        {
            TeamInfo teamInfo = scene.GetComponent<TeamSceneComponent>().GetTeamInfo( request.UserID );

            if (teamInfo.FubenInstanceId == 0)
            {
                //动态创建副本
                long fubenid = IdGenerater.Instance.GenerateId();
                long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, scene.DomainZone(), "TeamDungeon" + fubenid.ToString(), SceneType.Fuben);
                TeamDungeonComponent teamDungeonComponent = fubnescene.AddComponent<TeamDungeonComponent>();
                MapComponent  mapComponent = fubnescene.GetComponent<MapComponent>();
                mapComponent.SetMapInfo( (int)SceneTypeEnum.TeamDungeon, teamInfo.FubenId, 0);
                mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(teamInfo.FubenId).MapID.ToString();
                teamDungeonComponent.TeamInfo = teamInfo;
                teamDungeonComponent.EnterTime = TimeHelper.ServerNow();
                teamInfo.FubenInstanceId = fubenInstanceId;
                TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            }

            response.FubenId = teamInfo.FubenId;
            response.FubenInstanceId = teamInfo.FubenInstanceId;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
