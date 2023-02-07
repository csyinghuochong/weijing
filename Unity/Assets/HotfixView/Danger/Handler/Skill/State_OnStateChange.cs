namespace ET
{
    public class State_OnStateChange : AEventClass<EventType.StateChange>
    {
        protected override void Run(object numerice)
        {
            EventType.StateChange args = numerice as EventType.StateChange;
            M2C_UnitStateUpdate message = args.m2C_UnitStateUpdate;

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
