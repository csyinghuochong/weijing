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
                this.InitSelfBuff();
                this.BaseOnUpdate();
            }
            else
            {
                //先跳过去再触发伤害
                TheUnitFrom.Position = this.TargetPosition;
                this.InitSelfBuff();
                this.BaseOnUpdate();
            }
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }

            this.BaseOnUpdate();
            if (this.SkillConf.GameObjectParameter == "1"  && serverNow > this.SkillExcuteHurtTime)
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
