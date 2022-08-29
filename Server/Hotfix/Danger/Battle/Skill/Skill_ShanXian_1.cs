using ET;

namespace ET
{

    //闪现
    public class Skill_ShanXian_1 : SkillHandler
    {
       
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public override void OnExecute()
        {
            if (this.SkillConf.GameObjectParameter == "1")
            {
                //先触发伤害再跳过去
                this.UpdateCheckPoint();
                this.BaseOnExecute();
                this.BaseOnUpdate();
            }
            else
            {
                //先跳过去再触发伤害
                TheUnitFrom.Position = this.TargetPosition;
                this.BaseOnExecute();
                this.BaseOnUpdate();
            }
        }

        public override void OnUpdate()
        {
            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;

            //根据技能效果延迟触发伤害
            if (this.PassTime < this.DelayHurtTime)
            {
                return;
            }

            this.BaseOnUpdate();
            if (this.SkillConf.GameObjectParameter == "1"  && this.PassTime > this.DelayHurtTime)
            {
                TheUnitFrom.Position = this.TargetPosition;
                this.SetSkillState( SkillState.Finished);
            }
        }

        public override void OnFinished()
        {

        }
    }
}
