using UnityEngine;

namespace ET
{

    [Event]
    public class UnitRevive_PlayIdleAnimate : AEventClass<EventType.UnitRevive>
    {
        protected override void Run(object cls)
        {
            EventType.UnitRevive args = cls as EventType.UnitRevive;
            Unit unit = args.Unit;
            unit.Position = unit.GetBornPostion();

            unit.GetComponent<StateComponent>().Reset();
            unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmIdleState);
            unit.GetComponent<HeroHeadBarComponent>()?.OnRevive();

            if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ReviveTime) > 0)
            {
                unit.GetComponent<GameObjectComponent>()?.OnRevive();
            }
        }
    }
}
