using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    //拉怪技能:瞬间拉至自身/目标点
    public class Skill_Pull_Monster_1 : SkillHandler
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
            
        }

        public void InitPullMonster()
        {
            List<Unit> monsters = AIHelp.GetEnemyMonsters(this.TheUnitFrom, this.TargetPosition, (float)(this.SkillConf.DamgeRange[0])*2);
         
            for (int i = 0; i < monsters.Count; i++)
            {
                Unit unit = monsters[i];
                AIComponent aIComponent = monsters[i].GetComponent<AIComponent>();
                if (aIComponent == null)
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
            //只触发一次，需要多次触发的重写
            if (!this.IsExcuteHurt)
            {
                this.InitPullMonster();
            }
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {

        }
    }
}
