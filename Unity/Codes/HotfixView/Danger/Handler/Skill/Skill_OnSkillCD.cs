namespace ET
{
    public class Skill_OnSkillCD : AEventClass<EventType.SkillCD> 
    {
        protected override void Run(object numerice)
        {
            EventType.SkillCD args = numerice as EventType.SkillCD;
            UI uimain = UIHelper.GetUI(args.Unit.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.OnUseSkill();
        }
    }
}
