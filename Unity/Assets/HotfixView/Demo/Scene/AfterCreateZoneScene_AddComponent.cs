namespace ET
{
    public class AfterCreateZoneScene_AddComponent: AEventClass<EventType.AfterCreateZoneScene>
    {
        protected override void  Run(object change)
        {
            EventType.AfterCreateZoneScene args = change as EventType.AfterCreateZoneScene;
            Scene zoneScene = args.ZoneScene;
            zoneScene.AddComponent<UIEventComponent>();
            zoneScene.AddComponent<UIComponent>();
            zoneScene.AddComponent<RelinkComponent>();
            zoneScene.AddComponent<FloatTipManager>();
            zoneScene.AddComponent<ReddotViewComponent>();
            zoneScene.AddComponent<ResourcesLoaderComponent>();
            zoneScene.AddComponent<SkillIndicatorComponent>();
            zoneScene.AddComponent<LockTargetComponent>();
        }
    }
}