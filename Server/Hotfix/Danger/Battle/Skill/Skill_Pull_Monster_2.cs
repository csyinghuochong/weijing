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
        }

        public void UpdatePullMonster()
        {
            List<Unit> monsters = AIHelp.GetEnemyMonsters(this.TheUnitFrom, this.NowPosition, 5f);
            for (int i = monsters.Count - 1; i >= 0; i--)
            {
                Unit unit = monsters[i];
                AIComponent aIComponent = unit.GetComponent<AIComponent>();
                if (aIComponent == null)
                {
                    continue;
                }
                if (this.HurtIds.Contains(monsters[i].Id))
                {
                    continue;
                }
                this.HurtIds.Add(monsters[i].Id);
                BuffData buffData_2 = new BuffData();
                buffData_2.BuffConfig = SkillBuffConfigCategory.Instance.Get(99002001);
                buffData_2.BuffClassScript = buffData_2.BuffConfig.BuffScript;
                unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_2, unit, null);

                unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.BePulled);
                aIComponent.TargetPoint.Clear();
                aIComponent.TargetPoint.Add(this.NowPosition);
                monsters[i].Stop(0);
                aIComponent.AIConfigId = 9;   //牵引AI
            }

            for (int i = this.HurtIds.Count - 1; i >= 0; i--)
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
                
                if (Vector3.Distance(unit.Position, this.NowPosition) > 6)
                {
                    unit.GetComponent<BuffManagerComponent>().BuffRemove(99002001);
                    unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.BePulled);
                    aIComponent.TargetPoint.Clear();
                    this.HurtIds.RemoveAt(i);
                    continue;
                }
                if (aIComponent.TargetPoint.Count == 0)
                {
                    this.HurtIds.RemoveAt(i);
                    continue;
                }
                //夹角大于20度认为不是直线移动，停止拉怪
                //Vector3 fromVector = this.TargetPosition - unit.Position;
                //Vector3 toVector = this.TargetPosition - this.NowPosition;
                //fromVector = fromVector.normalized;
                //toVector = toVector.normalized;
                //Vector2 v1 = new Vector2() { x = fromVector.x, y = fromVector.z };
                //Vector2 v2 = new Vector2() { x = toVector.x, y = toVector.z };
                //float angle = Mathf.Acos( Vector2.Dot(v1, v2));
                //float angle_1 = Mathf.Rad2Deg(Mathf.Atan2(v1.x, v1.y));
                //float angle_2 = Mathf.Rad2Deg(Mathf.Atan2(v2.x, v2.y));
                //Log.Debug($" angle:  {angle_1} { angle_2}  {angle}");
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
            this.HurtIds.Clear();
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }
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
            if (serverNow > this.SkillEndTime)
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
