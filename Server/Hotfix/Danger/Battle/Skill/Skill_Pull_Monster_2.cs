using UnityEngine;

namespace ET
{
    public class Skill_Pull_Monster_2 : SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public override void OnExecute()
        {

        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();

            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }
            //只触发一次，需要多次触发的重写
            if (!this.IsExcuteHurt)
            {
                this.IsExcuteHurt = true;
            }

            //根据技能存在时间设置其结束状态
            if (serverNow > this.SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
            }
        }

        public override void OnFinished()
        {

        }
    }
}
