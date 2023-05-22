using UnityEngine;

namespace ET
{

    [BuffHandler]
    public class RoleBuffBullet_2 : ABuffHandler
    {

        public override void OnInit(BuffData buffData, Unit theUnitBelongto)
        {
            this.mSkillConf = SkillConfigCategory.Instance.Get(buffData.SkillId);
            this.startAngle = buffData.TargetAngle;
            this.mRadius = (float)mSkillConf.SkillRangeSize;

            this.BaseOnBulletInit(buffData,  theUnitBelongto);
            this.OnExecute();
        }

        public override void OnReset()
        {

        }

        public override void OnExecute()
        {
            this.EffectInstanceId = this.PlayBuffEffects();
            this.EffectData.InstanceId = 0;
            this.BuffState = BuffState.Running;
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            if (TimeHelper.ClientNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
                return;
            }
            if (this.PassTime >= this.mDelayTime && this.IsDelayPlay == false)
            {
                this.IsDelayPlay = true;
            }
            if (this.EffectInstanceId != 0 && this.mEffectConf.IfFollowCollider == 0 && this.IsDelayPlay == true)
            {
                this.mAngle = this.PassTime * (float)mSkillConf.SkillMoveSpeed + startAngle;
                if (this.mAngle >= 360)
                {
                    this.mAngle %= 360;
                }
                Vector3 sourcePoint = TheUnitBelongto.Position;
                Quaternion rotation = Quaternion.Euler(0, this.mAngle, 0);

                EventType.SkillEffectMove.Instance.Postion = sourcePoint + rotation * Vector3.forward * mRadius;
                EventType.SkillEffectMove.Instance.Unit = this.TheUnitBelongto;
                EventType.SkillEffectMove.Instance.Angle = this.mAngle;
                EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId;
                EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);
            }
        }

        public override void OnFinished()
        {

        }

    }
}
