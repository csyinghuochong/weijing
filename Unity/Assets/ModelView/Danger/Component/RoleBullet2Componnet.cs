using UnityEngine;

namespace ET
{
    public class RoleBullet2Componnet : Entity, IAwake, IDestroy
    {
        public long  PassTime;
        public long mDelayTime;
        public bool IsDelayPlay;
        public float Angle;
        public float StartAngle;
        public float mRadius;
        public long Timer;
        public SkillConfig SkillConfig;
        public EffectConfig EffectConfig;
        public Unit TheUnitBelongto;
        public Vector3 StartPosition;
        public long BeginTime;
    }
}