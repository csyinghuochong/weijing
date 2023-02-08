
namespace ET
{
    public class Skill_OnSkillYuJing : AEventClass<EventType.SkillYuJing>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillYuJing args = numerice as EventType.SkillYuJing;

            Unit unit = args.Unit;
            Unit mainUnit = UnitHelper.GetMyUnitFromCurrentScene(unit.DomainScene());
            bool canattack = mainUnit.IsCanAttackUnit(unit);

            args.Unit.GetComponent<SkillYujingComponent>()?.ShowMonsterSkillYujin(args.SkillInfo, args.SkillConfig.SkillDelayTime, canattack);
        }
    }
}
