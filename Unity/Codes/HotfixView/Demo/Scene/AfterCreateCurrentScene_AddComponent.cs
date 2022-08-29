namespace ET
{
    public class AfterCreateCurrentScene_AddComponent: AEventClass<EventType.AfterCreateCurrentScene>
    {
        protected override void  Run(object changeRotation)
        {
            EventType.AfterCreateCurrentScene args = changeRotation as EventType.AfterCreateCurrentScene; 
            Scene currentScene = args.CurrentScene;
            //currentScene.AddComponent<UIComponent>();
            //currentScene.AddComponent<ResourcesLoaderComponent>();
            currentScene.AddComponent<FallingFontComponent>();
        }
    }
}