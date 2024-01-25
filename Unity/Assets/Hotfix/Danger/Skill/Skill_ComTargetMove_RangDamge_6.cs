namespace ET
{
    [SkillHandler]
    public class Skill_ComTargetMove_RangDamge_6: Skill_Action_Common
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            this.OnExecute();
        }

        public override void OnExecute()
        {
            this.OnShowSkillIndicator(this.SkillInfo);
            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
        }
    }
}