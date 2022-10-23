namespace ET
{

    [Event]
    public class Relink_OnBeginRelink : AEventClass<EventType.BeginRelink>
    {

        protected override void Run(object cls)
        {
            EventType.BeginRelink args = (EventType.BeginRelink)cls;
            if (UIHelper.GetUI(args.ZoneScene, UIType.UILoading) != null)
            {
                UIHelper.Remove(args.ZoneScene, UIType.UILoading);
                EventType.ReturnLogin.Instance.ZoneScene = args.ZoneScene;
                Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
                return;
            }
            args.ZoneScene.GetComponent<RelinkComponent>().CheckRelink().Coroutine();
        }
    }
}
