using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.RoleBullet2Timer)]
    public class RoleBullet2Timer : ATimer<RoleBullet2Componnet>
    {
        public override void Run(RoleBullet2Componnet self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class RoleBullet2ComponnetAwake : AwakeSystem<RoleBullet2Componnet>
    {
        public override void Awake(RoleBullet2Componnet self)
        {
           
        }
    }

    [ObjectSystem]
    public class RoleBullet2ComponnetDestroy : DestroySystem<RoleBullet2Componnet>
    {
        public override void Destroy(RoleBullet2Componnet self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class RoleBullet2ComponnetSystem
    {
        public static void BaseOnBulletInit(this RoleBullet2Componnet self, int skillid)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long masterid = numericComponent.GetAsLong(NumericType.MasterId);
            self.PassTime = 0;
            self.StartAngle = numericComponent.GetAsInt(NumericType.StartAngle);
            self.SkillConfig = SkillConfigCategory.Instance.Get(skillid);
            self.mRadius = (float)self.SkillConfig.SkillRangeSize;
            self.mDelayTime = (float)(self.SkillConfig.SkillDelayTime);
            self.IsDelayPlay = self.mDelayTime > 0f;
            self.TheUnitBelongto = unit.GetParent<UnitComponent>().Get(masterid);
            self.StartPosition = unit.Position;

            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.RoleBullet2Timer, self);
        }

        public static void OnUpdate(this RoleBullet2Componnet self)
        {
            self.PassTime += Time.deltaTime;
            self.mAngle = self.PassTime * (float)self.SkillConfig.SkillMoveSpeed + self.StartAngle;
            if (self.mAngle >= 360)
            {
                self.mAngle %= 360;
            }
            Vector3 sourcePoint = self.TheUnitBelongto!=null ?  self.TheUnitBelongto.Position : self.StartPosition;
            Quaternion rotation = Quaternion.Euler(0, self.mAngle, 0);
            Vector3 targetpos = sourcePoint + rotation * Vector3.forward * self.mRadius;
            self.GetParent<Unit>().Position = targetpos;
        }
    }
}