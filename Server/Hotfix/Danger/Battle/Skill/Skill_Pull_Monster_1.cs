using UnityEngine;

namespace ET
{

    //拉怪技能
    public class Skill_Pull_Monster_1 : SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        //退出
        public override void OnExecute()
        {
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
