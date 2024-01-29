namespace ET
{
    public class Skill_OnSkillSecond : AEventClass<EventType.M2C_SkillSecond>
    {
        protected override void Run(object numerice)
        {
            EventType.M2C_SkillSecond args = numerice as EventType.M2C_SkillSecond;

            UI uImain = UIHelper.GetUI( args.ZoneScene, UIType.UIMain );
            uImain.GetComponent<UIMainComponent>().UIMainSkillComponent.OnSkillSecond(args.M2C_SkillSecondResult);
        }
    }
}