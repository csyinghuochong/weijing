namespace ET
{
    public class Fsm_OnFsmChange : AEventClass<EventType.FsmChange>
    {
        protected override void Run(object numerice)
        {
            EventType.FsmChange args = numerice as EventType.FsmChange;
            args.Unit.GetComponent<FsmComponent>()?.ChangeState(args.FsmHandlerType, args.FsmValue.ToString());

            if (!args.Unit.MainHero || args.FsmHandlerType != FsmStateEnum.FsmSkillState)
            {
                return;
            }
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(args.FsmValue);
            if (skillConfig.SkillSingTime == 0f)
            {
                return;
            }
            UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
            uI.GetComponent<UIMainComponent>().UISingingComponent.OnSkillSinging(args.FsmValue);
        }
    }
}
