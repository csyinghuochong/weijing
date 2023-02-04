
namespace ET
{
    public class Skill_OnSkillEffect : AEventClass<EventType.SkillEffect>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillEffect args = numerice as EventType.SkillEffect;
            EffectViewComponent effectViewComponent = args.Unit.GetComponent<EffectViewComponent>();
            effectViewComponent?.EffectFactory(args.EffectData);
        }
    }
}
