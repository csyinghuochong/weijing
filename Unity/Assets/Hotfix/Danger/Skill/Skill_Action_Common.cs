namespace ET
{

    [SkillHandler]
    public class Skill_Action_Common : ASkillHandler
    {
     
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            OnExecute();
        }

        public override void OnExecute()
        {
            this.PlaySkillEffects(this.TargetPosition);
            this.OnShowSkillIndicator(this.SkillCmd);
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            this.EndSkillEffect();
        }
    }
}
