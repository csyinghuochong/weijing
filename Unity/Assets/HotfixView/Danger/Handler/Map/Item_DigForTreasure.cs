namespace ET
{
    public class Item_DigForTreasure : AEventClass<EventType.DigForTreasure>
    {
        protected override async void Run(object cls)
        {
            EventType.DigForTreasure args = (EventType.DigForTreasure)cls;

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(args.BagInfo.ItemID);
            if (itemConfig.ItemSubType == 113)
            {
                UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
                uI.GetComponent<UIMainComponent>().UIDigTreasureComponent.OnInitUI(args.BagInfo);
            }
            if (itemConfig.ItemSubType == 127)
            {
                UI uI = await UIHelper.Create(args.ZoneScene, UIType.UITreasureOpen);
                uI.GetComponent<UITreasureOpenComponent>().OnInitUI(args.BagInfo);
            }
        }

    }
}
