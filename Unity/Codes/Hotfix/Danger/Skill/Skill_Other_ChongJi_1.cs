using ET;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    //冲锋
    [SkillHandler]
    public class Skill_Other_ChongJi_1 : ASkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            OnExecute();
        }

        public override void OnExecute()
        {
            this.PlaySkillEffects(this.TargetPosition);
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
