using UnityEngine;

namespace ET
{
    //闪现(怪物技能)
    [SkillHandler]
    public class Skill_ShanXian_2 : ASkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            this.OnExecute();
        }

        public override void OnExecute()
        {
            //更新位置
            if (this.SkillConf.GameObjectParameter == "0")
            {
                //先跳过去再触发伤害
                this.PlaySkillEffects(this.TargetPosition);
            }
            else
            {
                this.PlaySkillEffects(this.TheUnitFrom.Position);
            }

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
