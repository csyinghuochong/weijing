using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2LocalDungeon_EnterRequestHandler : AMActorRpcHandler<Scene, M2LocalDungeon_EnterRequest, LocalDungeon2M_EnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2LocalDungeon_EnterRequest request, LocalDungeon2M_EnterResponse response, Action reply)
        {
            switch (request.SceneType)
            {
                case SceneTypeEnum.LocalDungeon:
                    long fubenid = IdGenerater.Instance.GenerateId();
                    long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                    Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, scene.DomainZone(), "LocalDungeon" + fubenid.ToString(), SceneType.Fuben);
                    fubnescene.AddComponent<YeWaiRefreshComponent>();
                    LocalDungeonComponent localDungeon = fubnescene.AddComponent<LocalDungeonComponent>();
                    localDungeon.FubenDifficulty = request.Difficulty;
                    fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.LocalDungeon, request.SceneId, 0);
                    response.FubenInstanceId = fubenInstanceId;
                    TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                    break;
                case SceneTypeEnum.Battle:
                    //动态创建副本
                    int sceneId = request.SceneId;  
                    fubenid = IdGenerater.Instance.GenerateId();
                    fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                    fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, scene.DomainZone(), "Battle" + fubenid.ToString(), SceneType.Fuben);
                    //Console.WriteLine($"M2LocalDungeon_Enter: {fubnescene.Name}   {scene.DomainZone()}");
                    fubnescene.AddComponent<BattleDungeonComponent>().SendReward = false;
                    fubnescene.GetComponent<BattleDungeonComponent>().BattleOpenTime = TimeHelper.ServerNow();
                    MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
                    mapComponent.SetMapInfo((int)SceneTypeEnum.Battle, sceneId, 0);
                    mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID;
                    Game.Scene.GetComponent<RecastPathComponent>().Update(mapComponent.NavMeshId);
                    fubnescene.AddComponent<YeWaiRefreshComponent>().SceneId = sceneId;
                    FubenHelp.CreateNpc(fubnescene, sceneId);
                    FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonster);
                    FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonsterPosi);
                    response.FubenId = fubenid;
                    response.FubenInstanceId = fubenInstanceId;
                    TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                    break;
            }


            reply();
            await ETTask.CompletedTask;
        }
    }
}
