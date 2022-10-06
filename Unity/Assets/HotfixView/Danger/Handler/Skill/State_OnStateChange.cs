namespace ET
{
    public class State_OnStateChange : AEventClass<EventType.StateChange>
    {
        protected override void Run(object numerice)
        {
            EventType.StateChange args = numerice as EventType.StateChange;
            M2C_UnitStateUpdate message = args.m2C_UnitStateUpdate;

            //自己特殊处理
            if (args.Unit.MainHero && message.StateOperateType == 1 && message.StateType == StateTypeEnum.Singing)
            {
                UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                uI.GetComponent<UIMainComponent>().UISingingComponent.OnFrontSinging(int.Parse(message.StateValue));
            }
            if (args.Unit.MainHero && message.StateOperateType == 2 && message.StateType == StateTypeEnum.Singing)
            {
                UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                uI.GetComponent<UIMainComponent>().UISingingComponent.OnSingingFinish();
            }
            if (args.Unit.MainHero && message.StateOperateType == 1 && message.StateType == StateTypeEnum.Interrupt)
            {
                //打断技能
                UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                uI.GetComponent<UIMainComponent>().UISingingComponent.OnSingingFinish();
            }

            FsmComponent fsmComponent = args.Unit.GetComponent<FsmComponent>();
            if (fsmComponent == null)
            {
                return;
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 1)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmSinging, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.Singing && message.StateOperateType == 2)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.Interrupt && message.StateOperateType == 1)
            {
                fsmComponent.SkillMoveTime = 0;
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 1)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmOpenBox, message.StateValue);
            }
            if (message.StateType == StateTypeEnum.OpenBox && message.StateOperateType == 2)
            {
                fsmComponent.ChangeState(FsmStateEnum.FsmIdleState, message.StateValue);
            }
        }
    }
}
