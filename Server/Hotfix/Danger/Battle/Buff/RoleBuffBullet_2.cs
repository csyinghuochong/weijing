using UnityEngine;

namespace ET
{

    /// <summary>
    /// 弹道类型BUFF
    /// </summary>
    public class RoleBuffBullet_2 : BuffHandler
    {

        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.mSkillHandler = skillHandler;
            this.Id = IdGenerater.Instance.GenerateId();
            this.OnBaseBulletInit(buffData, theUnitFrom, theUnitBelongto);

            this.Angle = 0f;
            this.Radius = (float)this.mSkillConf.SkillRangeSize;
            this.StartAngle = buffData.TargetAngle;
            this.BeginTime = TimeHelper.ServerNow();
            this.InterValTimeSum = (long)(1000 * 360f / this.mSkillConf.SkillMoveSpeed);
        }

        public override void OnUpdate()
        {
            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;
            if (this.PassTime <= this.DelayTime)
            {
                return;
            }
            if (TimeHelper.ServerNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }

            this.Angle = (this.PassTime * 0.001f) * (float)this.mSkillConf.SkillMoveSpeed + this.StartAngle;
            if (Angle >= 360)
            {
                this.Angle %= 360;
                this.mSkillHandler.LastHurtTimes.Clear();
            }
           
            Vector3 sourcePoint = this.TheUnitFrom.Position;
            Quaternion rotation = Quaternion.Euler(0, Angle, 0);
            Vector3 currentPosition = sourcePoint + rotation * Vector3.forward * Radius;
            this.OnBulletUpdate_2(currentPosition);
        }

        public override void OnFinished()
        {
        }
    }
}
