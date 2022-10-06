using UnityEngine;

namespace ET
{

    [Event]
    public class MoveStart_PlayMoveAnimate : AEventClass<EventType.MoveStart>
    {

        protected override  void Run(object cls)
        {
            EventType.MoveStart args = (EventType.MoveStart)cls;    

            if (args.Unit.GetComponent<FsmComponent>() != null)
            {
                args.Unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmRunState);
                if (args.Unit.GetComponent<HeroTransformComponent>().RunEffect!=null)
                {
                    args.Unit.GetComponent<HeroTransformComponent>().RunEffect.SetActive(true);
                    args.Unit.GetComponent<HeroTransformComponent>().RunEffect.GetComponent<ParticleSystem>().Play();
                }
            }
        }

    }
}
