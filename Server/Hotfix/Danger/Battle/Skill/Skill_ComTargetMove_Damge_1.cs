using ET;
using UnityEngine;

namespace ET
{
    //指定目标攻击
    public class Skill_ComTargetMove_Damge_1 : SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.NowPosition = theUnitFrom.Position;
            this.TheUnitTarget = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.SkillInfo.TargetID);
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }

            if (this.TheUnitTarget != null && !this.TheUnitTarget.IsDisposed)
            {
                this.TargetPosition = this.TheUnitTarget.Position;
            }
            else
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }

            Vector3 dir = (this.TargetPosition - NowPosition).normalized;
            float dis = PositionHelper.Distance2D(NowPosition, this.TargetPosition);
            float move = (float)this.SkillConf.SkillMoveSpeed * 0.1f;            //服务器0.1秒一帧
            move = Mathf.Min(dis, move);
            this.NowPosition = this.NowPosition + move * dir;
            this.NowPosition.y = this.TargetPosition.y + 0.5f;
            //获取目标与自身的距离是否小于0.5f,小于触发将伤害,销毁自身
            dis = PositionHelper.Distance2D(NowPosition, this.TargetPosition);
            if (dis > 0.5f)
            {
                return;
            }

            float damgeRange = (float)this.SkillConf.DamgeRange[0];
            if (damgeRange > 0)
            {
                this.ExcuteSkillAction();
            }
            else
            {
                this.OnCollisionUnit(this.TheUnitTarget);
            }
            this.SetSkillState(SkillState.Finished);
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
