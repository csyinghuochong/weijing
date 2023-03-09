namespace ET
{
    public class Skill_OnBuffUpdate : AEventClass<EventType.BuffUpdate>
    {
        protected override void Run(object numerice)
        {
            EventType.BuffUpdate args = numerice as EventType.BuffUpdate;
            if (args.Unit == null || args.Unit.IsDisposed)
            {
                return;
            }
            UI uimain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            if (uimain == null)
            {
                return;
            }
            if(args.Unit.MainHero)
            {
                uimain.GetComponent<UIMainComponent>().UIMainBuffComponent.OnBuffUpdate(args.ABuffHandler, args.OperateType);
            }
            else
            {
                uimain.GetComponent<UIMainComponent>().UIMainHpBar.UIMainBuffComponent.OnBuffUpdate(args.ABuffHandler, args.OperateType);
            }
        }
    }
}
