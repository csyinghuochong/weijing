using UnityEngine;

namespace ET
{

    //拉怪技能67000279 67000280
    public class Skill_Pull_Monster_1 : SkillHandler
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

                //2-10米内的怪随机拉一个到自身一米范围内
                Unit monster = AIHelp.GetNearestEnemyMonster(this.TheUnitFrom, 2f, 10f);
                if (monster == null)
                {
                    return;
                }
                Vector3 dir = (monster.Position - this.TheUnitFrom.Position).normalized;
                monster.GetComponent<MoveComponent>().Stop();
                monster.Position = this.TheUnitFrom.Position + dir * Vector3.one;
                monster.Stop(-2);
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
