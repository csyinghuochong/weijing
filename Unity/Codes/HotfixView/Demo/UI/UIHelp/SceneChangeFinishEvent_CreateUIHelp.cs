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
            args.CurrentScene.AddComponent<LockTargetComponent>();

            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.MainCityScene)
            {
                args.CurrentScene.AddComponent<SkillIndicatorComponent>();
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon)
            {
                args.CurrentScene.AddComponent<FingerTouchComponent>();
            }
        }
    }
}
