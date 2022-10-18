
namespace ET
{
    public class Skill_OnSkillYuJing : AEventClass<EventType.SkillYuJing>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillYuJing args = numerice as EventType.SkillYuJing;
            args.Unit.GetComponent<SkillYujingComponent>()?.ShowMonsterSkillYujin(args.SkillInfo, args.SkillConfig.SkillDelayTime);
        }
    }
}
