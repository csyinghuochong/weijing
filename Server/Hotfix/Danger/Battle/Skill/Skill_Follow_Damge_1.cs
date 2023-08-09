namespace ET
{
    //量子导弹
    public class Skill_Follow_Damge_1 : SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);


        }

        public override void OnExecute()
        {

        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

        }

        public override void OnFinished()
        {
          
            this.Clear();
        }
    } 

}
