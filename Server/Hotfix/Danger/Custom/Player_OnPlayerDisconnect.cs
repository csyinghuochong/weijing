namespace ET
{
    public class Player_OnPlayerDisconnect : AEvent<EventType.PlayerDisconnect>
    {

        protected override void Run(EventType.PlayerDisconnect args)
        {
            Scene scene = args.DomainScene;
            long userId = args.UnitId;
            int sceneTypeEnum = args.DomainScene.GetComponent<MapComponent>().SceneTypeEnum;

            if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
            {
                //动态删除副本
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
            {
                TeamSceneComponent teamSceneComponent = scene.GetParent<TeamSceneComponent>();
                teamSceneComponent.OnUnitDisconnect(scene, userId);
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.Arena)
            {
                ArenaDungeonComponent areneSceneComponent = scene.GetComponent<ArenaDungeonComponent>();
                areneSceneComponent.OnUnitDisconnect(userId);
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.JiaYuan)
            {
                JiaYuanSceneComponent jiayuanSceneComponent = scene.GetParent<JiaYuanSceneComponent>();
                jiayuanSceneComponent.OnUnitLeave(scene);
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.OneChallenge)
            {
                OneChallengeDungeonComponent jiayuanSceneComponent = scene.GetParent<OneChallengeDungeonComponent>();
                jiayuanSceneComponent.OnUnitLeave(scene);
            }
        }

    }
}
