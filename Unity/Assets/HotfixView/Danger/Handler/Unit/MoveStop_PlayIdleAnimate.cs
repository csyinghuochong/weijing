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
            if (unitType == UnitType.Player && args.Unit.GetComponent<StateComponent>().StateTypeGet( StateTypeEnum.Obstruct))
            {
                args.Unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.Obstruct);
            }
            else
            {
                args.Unit.GetComponent<FsmComponent>().ChangeState(FsmStateEnum.FsmIdleState);
            }

            //播放移动特效
            GameObject runEffect = args.Unit.GetComponent<HeroTransformComponent>().RunEffect;
            if (runEffect != null)
            {
                runEffect.SetActive(false);
                runEffect.GetComponent<ParticleSystem>().Stop();
            }
        }

    }
}
