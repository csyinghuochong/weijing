using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2LocalDungeon_EnterRequestHandler : AMActorRpcHandler<Scene, M2LocalDungeon_EnterRequest, LocalDungeon2M_EnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2LocalDungeon_EnterRequest request, LocalDungeon2M_EnterResponse response, Action reply)
        {
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, scene.DomainZone(), "LocalDungeon" + fubenid.ToString(), SceneType.Fuben);
            fubnescene.AddComponent<YeWaiRefreshComponent>();
            LocalDungeonComponent localDungeon = fubnescene.AddComponent<LocalDungeonComponent>();
            localDungeon.FubenDifficulty = request.Difficulty;
            fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.LocalDungeon, request.SceneId, 0);
            
            response.FubenInstanceId = fubenInstanceId;
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
