namespace ET
{
    public class Team_TeamPickNotice : AEventClass<EventType.TeamPickNotice>
    {
        protected override void Run(object cls)
        {
            EventType.TeamPickNotice args = (EventType.TeamPickNotice)cls;
            DropInfo dropInfo = args.m2C_TeamPickMessage.DropItems[0];
            C2M_TeamPickRequest request = new C2M_TeamPickRequest() { DropItem = dropInfo, Need = 1 };
            args.ZoneScene.GetComponent<SessionComponent>().Session.Send(request);
        }
    }
}
