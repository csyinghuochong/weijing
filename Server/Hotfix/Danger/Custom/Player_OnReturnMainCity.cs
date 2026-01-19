namespace ET
{
    public class Player_OnReturnMainCity : AEvent<EventType.ReturnMainCity>
    {
        protected override void Run(EventType.ReturnMainCity args)
        {
            Scene scene = args.DomainScene;
            long userId = args.UnitId;

            if (scene.IsDisposed)
            {
                Log.Warning($"ReturnMainCity: scene.IsDisposed");
                return;
            }
            int sceneTypeEnum = scene.GetComponent<MapComponent>().SceneTypeEnum;
            if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
            {
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
                return;
            }
        }
    }
}
