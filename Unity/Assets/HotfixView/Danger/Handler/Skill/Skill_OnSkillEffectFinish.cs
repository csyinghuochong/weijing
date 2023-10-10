
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
            effectViewComponent.RemoveEffectId(args.EffectInstanceId);
        }
    }
}
