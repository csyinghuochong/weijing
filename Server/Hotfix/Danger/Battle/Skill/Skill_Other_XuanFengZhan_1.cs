using ET;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    //旋风斩
    public class Skill_Other_XuanFengZhan_1 : SkillHandler
    {
      
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.SkillTriggerLastTime = TimeHelper.ServerNow();
            OnExecute();
        }

        public override void OnExecute()
        {
            this.BaseOnExecute();
            this.BaseOnUpdate();
        }

        public override void OnUpdate()
        {
            //每间隔一段时间触发一次伤害
            if (TimeHelper.ServerNow() - this.SkillTriggerLastTime >= 250)
            {
                SkillTriggerLastTime = TimeHelper.ServerNow();
                HurtIds.Clear();
                this.UpdateCheckPoint();
                this.ExcuteSkillAction();
            }

            //技能存在时间
            PassTime  = TimeHelper.ServerNow() - this.BeginTime;
            if (PassTime > SkillLiveTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
        }

        public override void OnFinished()
        {

        }
    }
}
