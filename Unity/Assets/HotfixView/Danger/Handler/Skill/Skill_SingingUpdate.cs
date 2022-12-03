
namespace ET
{
    public class Skill_SingingUpdate : AEventClass<EventType.SingingUpdate>
    {
        protected override void Run(object numerice)
        {
            EventType.SingingUpdate args = numerice as EventType.SingingUpdate;
            UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            uI.GetComponent<UIMainComponent>().UISingingComponent.OnTimer(args);
        }
    }
}
