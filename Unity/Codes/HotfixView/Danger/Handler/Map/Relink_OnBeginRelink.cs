namespace ET
{

    [Event]
    public class Relink_OnBeginRelink : AEventClass<EventType.BeginRelink>
    {

        protected override void Run(object cls)
        {
            EventType.BeginRelink args = (EventType.BeginRelink)cls;
            args.ZoneScene.GetComponent<RelinkComponent>().CheckRelink().Coroutine();
        }
    }
}
