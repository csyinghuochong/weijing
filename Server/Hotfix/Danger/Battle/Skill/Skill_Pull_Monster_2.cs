using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class Skill_Pull_Monster_2 : SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            if (this.SkillConf.SkillMoveSpeed == 0f)
            {
                this.NowPosition = this.TargetPosition;
            }
            else
            {
                this.NowPosition = theUnitFrom.Position;
                Quaternion rotation = Quaternion.Euler(0, skillId.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
                Vector3 movePosition = rotation * Vector3.forward * (this.SkillConf.SkillLiveTime * (float)(this.SkillConf.SkillMoveSpeed) * 0.001f);
                this.TargetPosition = this.NowPosition + movePosition;
            }
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
            List<Unit> monsters = AIHelp.GetNearestMonsters(this.TheUnitFrom, 10f);
            for (int i = 0; i < monsters.Count; i++)
            {
                Unit unit = monsters[i];    
                AIComponent aIComponent = monsters[i].GetComponent<AIComponent>();
                if (aIComponent == null)
                {
                    continue;
                }
                
                BuffData buffData_2 = new BuffData();
                buffData_2.BuffConfig = SkillBuffConfigCategory.Instance.Get(99002001);
                buffData_2.BuffClassScript = buffData_2.BuffConfig.BuffScript;
                unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_2, unit, null);

                unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.BePulled);
                aIComponent.TargetPoint.Clear();
                aIComponent.TargetPoint.Add(this.NowPosition);

                monsters[i].Stop(0);
                aIComponent.AIConfigId = 9;   //牵引AI
                this.HurtIds.Add(monsters[i].Id);
            }
        }

        public void UpdatePullMonster()
        {
            for (int i = 0; i < this.HurtIds.Count; i++)
            {
                Unit unit = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.HurtIds[i]);
                if (unit == null)
                {
                    continue;
                }
                AIComponent aIComponent = unit.GetComponent<AIComponent>();
                if (aIComponent == null || aIComponent.TargetPoint.Count == 0)
                {
                    continue;
                }
                aIComponent.TargetPoint[0] = this.NowPosition;
            }
        }

        public void FinishPullMonster()
        {
            for (int i = 0; i < this.HurtIds.Count; i++)
            {
                Unit unit = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.HurtIds[i]);
                if (unit == null)
                {
                    continue;
                }
                AIComponent aIComponent = unit.GetComponent<AIComponent>();
                if (aIComponent == null)
                {
                    continue;
                }
                unit.GetComponent<BuffManagerComponent>().BuffRemove(99002001);
                unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.BePulled);
                aIComponent.TargetPoint.Clear();
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
            Vector3 dir = (this.TargetPosition - NowPosition).normalized;
            float dis = PositionHelper.Distance2D(NowPosition, this.TargetPosition);
            float move = (float)this.SkillConf.SkillMoveSpeed * 0.1f;            //服务器0.1秒一帧
            move = Mathf.Min(dis, move);
            this.NowPosition = this.NowPosition + move * dir;
            this.NowPosition.y = this.TargetPosition.y + 0.5f;
            this.UpdatePullMonster();
            //获取目标与自身的距离是否小于0.5f,小于触发将伤害,销毁自身
            dis = PositionHelper.Distance2D(NowPosition, this.TargetPosition);
            if (this.SkillConf.SkillMoveSpeed > 0f && dis < 0.5f)
            {
                this.SetSkillState(SkillState.Finished);
            }
        }

        public override void OnFinished()
        {
            this.FinishPullMonster();
        }
    }
}
