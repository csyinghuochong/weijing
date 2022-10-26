
namespace ET
{
    public class Team_TeamPickNotice : AEventClass<EventType.TeamPickNotice>
    {
        protected override void Run(object cls)
        {
            Log.Debug("Team_TeamPickNotice");
            EventType.TeamPickNotice args = (EventType.TeamPickNotice)cls;
            UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UITeamMain);
            if (uI != null)
            {
                uI.GetComponent<UITeamMainComponent>().OnTeamPickNotice(args.m2C_TeamPickMessage.DropItems);
            }
        }
    }
}
