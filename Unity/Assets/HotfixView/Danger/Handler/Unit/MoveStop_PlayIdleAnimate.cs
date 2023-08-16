using UnityEngine;

namespace ET
{

    public class MoveStop_PlayIdleAnimate : AEventClass<EventType.MoveStop>
    {
        protected override void  Run(object numerice)
        {
            EventType.MoveStop args = numerice as EventType.MoveStop;
            if (args.Unit.GetComponent<FsmComponent>() == null)
            {
                return;
            }
            int unitType = args.Unit.Type;
            if (unitType == UnitType.Player && args.Unit.GetComponent<StateComponent>().ObstructStatus == 1)
            {
                args.Unit.GetComponent<StateComponent>().ObstructStatus = 0;
            }
            else
            {
                args.Unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmIdleState);
            }

            //播放移动特效
            HeroTransformComponent heroTransformComponent = args.Unit.GetComponent<HeroTransformComponent>();
            if (heroTransformComponent!=null && heroTransformComponent.RunEffect != null)
            {
                heroTransformComponent.RunEffect.SetActive(false);
                heroTransformComponent.RunEffect.GetComponent<ParticleSystem>().Stop();
            }
        }

    }
}
