using UnityEngine;

namespace ET
{

    [BuffHandler]
    public class RoleBuffBullet_2 : ABuffHandler
    {

        public override void OnInit(BuffData buffData, Unit theUnitBelongto)
        {
            mSkillConf = SkillConfigCategory.Instance.Get(buffData.SkillConfig.Id);
            startAngle = buffData.TargetAngle;
            mRadius = (float)mSkillConf.SkillRangeSize;

            this.BaseOnBulletInit(buffData,  theUnitBelongto);
            this.OnExecute();
        }

        public override void OnReset()
        {

        }

        public override void OnExecute()
        {
            this.EffectInstanceId = this.PlayBuffEffects(false);
            this.BuffState = BuffState.Running;
            this.EffectData = null;
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            if (TimeHelper.ClientNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
                return;
            }
            if (PassTime >= mDelayTime && IsDelayPlay == false)
            {
                IsDelayPlay = true;
            }
            if (EffectInstanceId != 0 && mEffectConf.IfFollowCollider == 0 && IsDelayPlay == true)
            {
                mAngle = PassTime * (float)mSkillConf.SkillMoveSpeed + startAngle;
                if (mAngle >= 360)
                {
                    mAngle %= 360;
                }

                Vector3 sourcePoint = TheUnitBelongto.Position;
                Quaternion rotation = Quaternion.Euler(0, mAngle, 0);

                EventType.SkillEffectMove.Instance.Postion = sourcePoint + rotation * Vector3.forward * mRadius;
                EventType.SkillEffectMove.Instance.Unit = this.TheUnitBelongto;
                EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId;
                EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);
            }
        }

        public override void OnFinished()
        {

        }

    }
}
