using UnityEngine;

namespace ET
{

    [Event]
    public class MoveStart_PlayMoveAnimate : AEventClass<EventType.MoveStart>
    {

        protected override  void Run(object cls)
        {
            EventType.MoveStart args = (EventType.MoveStart)cls;

            args.Unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmRunState);
            args.Unit.GetComponent<HeroTransformComponent>()?.ShowRunEffect();
        }

    }
}
