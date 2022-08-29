namespace ET
{
    public class Item_DigForTreasure : AEventClass<EventType.DigForTreasure>
    {
        protected override void Run(object cls)
        {
            EventType.DigForTreasure args = (EventType.DigForTreasure)cls;
            UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            uI.GetComponent<UIMainComponent>().UIDigTreasureComponent.OnInitUI(args.BagInfo);
        }

    }
}
