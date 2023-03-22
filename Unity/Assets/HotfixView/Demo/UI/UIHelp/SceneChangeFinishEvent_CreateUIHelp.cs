namespace ET
{
    public class SceneChangeFinishEvent_CreateUIHelp : AEventClass<EventType.SceneChangeFinish>
    {
        protected override void  Run(object cls)
        {
            EventType.SceneChangeFinish args = (EventType.SceneChangeFinish)cls;
            //已创建主unit
            args.CurrentScene.AddComponent<OperaComponent>();
            args.CurrentScene.AddComponent<CameraComponent>();

            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi)
            {
                args.CurrentScene.AddComponent<FingerTouchComponent>();
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.JiaYuan)
            {
                args.CurrentScene.AddComponent<JiaYuanViewComponent>();
            }
        }
    }
}
