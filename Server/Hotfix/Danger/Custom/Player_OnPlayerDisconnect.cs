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
                return;
            }
        }

    }
}
