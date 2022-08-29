namespace ET
{

    public class Reddot_OnReddotChange : AEventClass<EventType.ReddotChange>
    {

        protected override void  Run(object cls)
        {
            EventType.ReddotChange args = (EventType.ReddotChange)cls;
            ReddotViewComponent reddotComponent = args.ZoneScene.GetComponent<ReddotViewComponent>();
            reddotComponent.ChangeCountReddot(args.ReddotType, args.Number);
        }
    }
}
