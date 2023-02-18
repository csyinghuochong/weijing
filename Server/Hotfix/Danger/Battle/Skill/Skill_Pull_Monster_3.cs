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
            Quaternion rotation = Quaternion.Euler(0, skillId.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            Vector3 movePosition = rotation * Vector3.forward * (this.SkillConf.SkillLiveTime * (float)(this.SkillConf.SkillMoveSpeed) * 0.001f);
            this.TargetPosition = this.NowPosition + movePosition;

            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
        }

        public void InitPullMonster()
        {
            List<Unit> monsters = AIHelp.GetNearestMonsters(this.TheUnitFrom, 5f);
            for (int i = 0; i < monsters.Count; i++)
            {
                Unit unit = monsters[i];
                AIComponent aIComponent = monsters[i].GetComponent<AIComponent>();
                if (aIComponent == null)
                {
                    continue;
                }

                Vector3 dir = (unit.Position - this.TheUnitFrom.Position).normalized;
                unit.GetComponent<MoveComponent>().Stop();
                unit.Position = this.TheUnitFrom.Position + dir * Vector3.one;
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
