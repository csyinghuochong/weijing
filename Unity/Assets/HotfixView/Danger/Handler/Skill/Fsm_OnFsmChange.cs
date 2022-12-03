namespace ET
{
    public class Fsm_OnFsmChange : AEventClass<EventType.FsmChange>
    {
        protected override void Run(object numerice)
        {
            EventType.FsmChange args = numerice as EventType.FsmChange;
            args.Unit.GetComponent<FsmComponent>()?.ChangeState(args.FsmHandlerType, args.FsmValue.ToString());

        }
    }
}
