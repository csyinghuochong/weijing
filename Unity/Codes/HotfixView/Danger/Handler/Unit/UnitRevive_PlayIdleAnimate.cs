using UnityEngine;

namespace ET
{

    [Event]
    public class UnitRevive_PlayIdleAnimate : AEventClass<EventType.UnitRevive>
    {
        protected override void Run(object cls)
        {
            EventType.UnitRevive args = cls as EventType.UnitRevive;
            args.Unit.GetComponent<StateComponent>().Reset();
            args.Unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmIdleState);
            args.Unit.GetComponent<HeroHeadBarComponent>()?.OnRevive();
            if (args.Unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) > 0)
            {
                args.Unit.GetComponent<GameObjectComponent>()?.OnRevive();
            }
        }
    }
}
