
namespace ET
{
    public class Team_TeamPickNotice : AEventClass<EventType.TeamPickNotice>
    {
        protected override void Run(object cls)
        {
            EventType.TeamPickNotice args = (EventType.TeamPickNotice)cls;
            Log.Debug($"Team_TeamPickNotice:  {args.m2C_TeamPickMessage}");
        }
    }
}
