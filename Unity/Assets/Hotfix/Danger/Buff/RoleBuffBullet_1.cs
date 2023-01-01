using ET;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [BuffHandler]
    public class RoleBuffBullet_1 : ABuffHandler
    {
        public override void OnInit(BuffData buffData,Unit theUnitBelongto)
        {
            this.BaseOnBulletInit(buffData, theUnitBelongto);
            this.OnExecute();
        }

        public override void OnReset()
        {
           
        }

        public override void OnExecute()
        {
            if (!IsDelayPlay)
            {
                EffectInstanceId = this.PlayBuffEffects();
                this.EffectData = null;
            }

            this.BuffState = BuffState.Running;
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            if (IsDelayPlay && PassTime >= mDelayTime)
            {
                IsDelayPlay = false;
                EffectInstanceId = this.PlayBuffEffects();
                this.EffectData = null;
            }
            if (TimeHelper.ClientNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }
            if (this.EffectInstanceId != 0)
            {
                Quaternion rotation = Quaternion.Euler(0, this.BuffData.TargetAngle, 0); //按照Z轴旋转30度的Quaterion

                Vector3 movePosition = rotation * Vector3.forward * ((PassTime - mDelayTime) * (float)(mSkillConf.SkillMoveSpeed));
                Vector3 postition = this.StartPosition + movePosition;

                EventType.SkillEffectMove.Instance.Postion = postition;
                EventType.SkillEffectMove.Instance.Unit = this.TheUnitBelongto;
                EventType.SkillEffectMove.Instance.Angle = this.BuffData.TargetAngle;
                EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId;
                EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);
            }
        }

        public override void OnFinished()
        {
            this.EffectInstanceId = 0;
        }
    }
}
