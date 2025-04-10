namespace ET
{
    public class Team_TeamPickNotice : AEventClass<EventType.TeamPickNotice>
    {
        protected override void Run(object cls)
        {
            EventType.TeamPickNotice args = (EventType.TeamPickNotice)cls;
            DropInfo dropInfo = args.m2C_TeamPickMessage.DropItems[0];

            Log.Debug($"Team_TeamPickNotice [机器人放弃紫装！] {dropInfo.ItemID}");
            C2M_TeamPickRequest request = new C2M_TeamPickRequest() { DropItem = dropInfo, Need = 2 };      //  need == 1 需求  2 放弃   机器人
            args.ZoneScene.GetComponent<SessionComponent>().Session.Send(request);
        }
    }
}
