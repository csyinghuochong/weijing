using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class Skill_Pull_Monster_3 : SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            this.NowPosition = theUnitFrom.Position;
            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
            this.InitPullMonster();
        }

        public void InitPullMonster()
        {
            List<Unit> monsters = this.TheUnitFrom.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < monsters.Count; i++)
            {
                Unit unit = monsters[i];
                AIComponent aIComponent = monsters[i].GetComponent<AIComponent>();
                if (aIComponent == null || unit.Type != UnitType.Monster)
                {
                    continue;
                }
                if (!this.TheUnitFrom.IsCanAttackUnit(unit))
                {
                    continue;
                }
                if (Vector3.Distance(this.TargetPosition, unit.Position) > 5f)
                {
                    continue;
                }

                Vector3 dir = (unit.Position - this.TargetPosition).normalized;
                unit.GetComponent<MoveComponent>().Stop();
                unit.Position = this.TargetPosition + dir * Vector3.one;
                unit.Stop(-2);
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
        }

        public override void OnFinished()
        {
        }
    }
}
