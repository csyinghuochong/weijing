using UnityEngine;

namespace ET
{
    public class Skill_SkillEffectMove : AEventClass<EventType.SkillEffectMove>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillEffectMove args = numerice as EventType.SkillEffectMove;
            EffectViewComponent effectViewComponent = args.Unit.GetComponent<EffectViewComponent>();
            if (effectViewComponent == null)
            {
                return;
            }
            AEffectHandler aEffectHandler = effectViewComponent.GetEffect(args.EffectInstanceId);
            if (aEffectHandler != null)
            {
                aEffectHandler.UpdateEffectPosition(args.Postion, args.Angle);
            }
        }

    }
}
