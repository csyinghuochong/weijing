

namespace ET
{
    public class Skill_OnSkillEffectReset : AEventClass<EventType.SkillEffectReset>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillEffectReset args = numerice as EventType.SkillEffectReset;
            EffectViewComponent effectViewComponent = args.Unit.GetComponent<EffectViewComponent>();
            if (effectViewComponent == null)
            {
                return;
            }
            AEffectHandler aEffectHandler = effectViewComponent.GetEffect(args.EffectInstanceId);
            if (aEffectHandler!=null)
            {
                aEffectHandler.PassTime = 0f;
            }
        }
    }
}
