namespace ET
{
    [Event]
    public class UISoloQuit : AEventClass<EventType.UISoloQuit>
    {
        protected override void Run(object cls)
        {
            //获取事件对应传参
            EventType.UISoloQuit args = cls as EventType.UISoloQuit;

            //移除对应界面
            UIHelper.Remove(args.ZoneScene, UIType.UISolo);
        }
    }
}

