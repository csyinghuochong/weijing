
namespace ET
{
    public class Skill_OnSkillEffect : AEventClass<EventType.SkillEffect>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillEffect args = numerice as EventType.SkillEffect;
            args.Unit.GetComponent<EffectViewComponent>()?.EffectFactory(args.EffectData);
        }
    }
}
