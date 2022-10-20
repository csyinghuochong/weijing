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
                return;
            }
            args.ZoneScene.GetComponent<RelinkComponent>().CheckRelink().Coroutine();
        }
    }
}
