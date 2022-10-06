
namespace ET
{
    public class Skill_OnSkillEffectFinish : AEventClass<EventType.SkillEffectFinish>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillEffectFinish args = numerice as EventType.SkillEffectFinish;
            if (args.Unit.IsDisposed)
            {
                return;
            }
            EffectViewComponent effectViewComponent = args.Unit.GetComponent<EffectViewComponent>();
            if (effectViewComponent == null)
            {
                return;
            }
            AEffectHandler aEffectHandler = effectViewComponent.GetEffect(args.EffectInstanceId);
            if (aEffectHandler != null)
            {
                aEffectHandler.EffectState = BuffState.Finished;
            }
        }
    }
}
