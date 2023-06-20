using System;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

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
            self.StartAngle = numericComponent.GetAsInt(NumericType.StartAngle);
            self.SkillConfig = SkillConfigCategory.Instance.Get(skillid);
            self.mRadius = (float)self.SkillConfig.SkillRangeSize;
            self.mDelayTime = (long)(1000 * self.SkillConfig.SkillDelayTime);
            self.IsDelayPlay = self.mDelayTime > 0f;
            self.TheUnitBelongto = unit.GetParent<UnitComponent>().Get(masterid);
            self.BeginTime = numericComponent.GetAsLong(NumericType.StartTime);
            self.StartPosition = unit.Position;
            self.PassTime = 0;
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.RoleBullet2Timer, self);
        }

        public static void OnUpdate(this RoleBullet2Componnet self)
        {
            self.PassTime = TimeHelper.ServerNow() - self.BeginTime;
            self.Angle = (self.PassTime * 0.001f) * (float)self.SkillConfig.SkillMoveSpeed + self.StartAngle;
            if (self.Angle >= 360)
            {
                self.Angle %= 360;
            }
            Unit unit = self.GetParent<Unit>();
            Vector3 sourcePoint = self.TheUnitBelongto!=null ?  self.TheUnitBelongto.Position : self.StartPosition;
            Quaternion rotation = Quaternion.Euler(0, self.Angle, 0);
            Vector3 targetpos = sourcePoint + rotation * Vector3.forward * self.mRadius;
            unit.Position = targetpos;
        }
    }
}