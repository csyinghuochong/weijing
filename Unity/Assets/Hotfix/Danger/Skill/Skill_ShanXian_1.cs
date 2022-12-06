using UnityEngine;

namespace ET
{
    //闪现
    [SkillHandler]
    public class Skill_ShanXian_1 : ASkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            OnExecute();
        }

        public override void OnExecute()
        {
            //更新位置
            if (this.SkillConf.GameObjectParameter == "0")
            {
                //先跳过去再触发伤害
                TheUnitFrom.Position = TargetPosition;
                this.PlaySkillEffects(this.TargetPosition);
            }
            else
            {
                this.PlaySkillEffects(this.TheUnitFrom.Position);
            }

            this.OnShowSkillIndicator(this.SkillInfo);
        }

        public override void OnUpdate()
        {
            float passTime = (TimeHelper.ServerNow() - this.SkillInfo.SkillBeginTime) * 0.001f;
            if (this.SkillConf.GameObjectParameter == "1" && this.SkillExcuteHurtTime && passTime >= this.EffectConf.SkillEffectDelayTime)
            {
                //先跳过去再触发伤害
                TheUnitFrom.Position = TargetPosition;
            }
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {

        }
    }
}
