using UnityEngine;

namespace ET
{

    [Event]
    public class MoveStart_PlayMoveAnimate : AEventClass<EventType.MoveStart>
    {

        protected override  void Run(object cls)
        {
            EventType.MoveStart args = (EventType.MoveStart)cls;

            if (args.Unit.MainHero)
            {
                UI uI = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
                uI.GetComponent<UIMainComponent>()?.OnMoveStart();
            }
            args.Unit.GetComponent<FsmComponent>()?.ChangeState(FsmStateEnum.FsmRunState);
            args.Unit.GetComponent<HeroTransformComponent>()?.ShowRunEffect();
        }

    }
}
