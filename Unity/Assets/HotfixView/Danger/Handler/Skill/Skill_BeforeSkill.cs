namespace ET
{
    public class Skill_BeforeSkill : AEventClass<EventType.BeforeSkill>
    {
        protected override void Run(object numerice)
        {
            EventType.BeforeSkill args = numerice as EventType.BeforeSkill;
            UI uimain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().OnSpellStart();
        }
    }
}
