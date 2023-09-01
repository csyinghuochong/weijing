using System.Collections.Generic;
using UnityEngine;


namespace ET
{

    //钩子技能:瞬间拉至自身/目标点
    public class Skill_Hook_1 : SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.TheUnitTarget = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.SkillInfo.TargetID);
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();

            Vector3 dir = (this.TheUnitTarget.Position - this.TheUnitFrom.Position ).normalized;

            this.TargetPosition = dir * Vector3.one + this.TheUnitFrom.Position;

            this.TheUnitTarget.GetComponent<MoveComponent>().Clear();
            this.TheUnitTarget.Position = this.TargetPosition + dir * Vector3.one;
            this.TheUnitTarget.Stop(-2);
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
