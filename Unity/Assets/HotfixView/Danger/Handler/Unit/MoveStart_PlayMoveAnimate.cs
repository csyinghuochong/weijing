using UnityEngine;

namespace ET
{

    [Event]
    public class MoveStart_PlayMoveAnimate : AEventClass<EventType.MoveStart>
    {

        protected override  void Run(object cls)
        {
            EventType.MoveStart args = (EventType.MoveStart)cls;
            Unit unit = args.Unit;
            if (unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.BePulled))
            {
                return;
            }
            unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmRunState);
            unit.GetComponent<HeroTransformComponent>()?.ShowRunEffect();
        }

    }
}
