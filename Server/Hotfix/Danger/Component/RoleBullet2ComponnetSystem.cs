using System;
using System.Collections.Generic;
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
        public static void OnBaseBulletInit(this RoleBullet2Componnet self, SkillHandler skillHandler, long masterid)
        {
            self.PassTime = 0;
            self.MasterId = masterid;
            self.BuffState = BuffState.Running;
            self.SkillHandler = skillHandler;
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            self.BeginTime = numericComponent.GetAsLong(NumericType.StartTime);
            self.DelayTime = (long)(1000 * skillHandler.SkillConf.SkillDelayTime);
            self.DamageRange = self.SkillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageRange) + (float)skillHandler.SkillConf.DamgeRange[0];
            self.BuffEndTime = 1000 * (int)self.SkillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime) + skillHandler.SkillConf.SkillLiveTime + TimeHelper.ServerNow();
            self.StartAngle = numericComponent.GetAsInt( NumericType.StartAngle );
            self.TheUnitBelongto = unit.GetParent<UnitComponent>().Get(masterid);
            self.Radius = (float)skillHandler.SkillConf.SkillRangeSize;
            self.StartPosition = unit.Position;
            self.InterValTimeSum = 0;

            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.RoleBullet2Timer, self);
        }

        public static void OnUpdate(this RoleBullet2Componnet self)
        {
            self.PassTime = TimeHelper.ServerNow() - self.BeginTime;
            //if (self.PassTime <= self.DelayTime)
            //{
            //    return;
            //}
            Unit unit = self.GetParent<Unit>();
            if (unit.IsDisposed || self.TheUnitBelongto.IsDisposed ||  TimeHelper.ServerNow() > self.BuffEndTime)
            {
                unit.GetParent<UnitComponent>().Remove(unit.Id);
                self.BuffState = BuffState.Finished;
                //移除unit
                return;
            }

            self.Angle = (self.PassTime * 0.001f) * (float)self.SkillHandler.SkillConf.SkillMoveSpeed + self.StartAngle;
            if (self.Angle >= (self.InterValTimeSum + 1) * 360)
            {
                self.Angle %= 360;
                self.HurtIds.Clear();
                self.InterValTimeSum++;
            }

            Vector3 sourcePoint = self.TheUnitBelongto != null ? self.TheUnitBelongto.Position : self.StartPosition;
            Quaternion rotation = Quaternion.Euler(0, self.Angle, 0);
            unit.Position  = sourcePoint + rotation * Vector3.forward * self.Radius;

            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i] ;
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (uu.IsDisposed || uu.Id == unit.Id || uu.Id ==self.MasterId || self.SkillHandler.IsFinished())
                {
                    continue;
                }
                if (!uu.IsCanBeAttack())
                {
                    continue;
                }

                //检测目标是否在技能范围
                float dic = Vector3.Distance(unit.Position, uu.Position);
                if (dic > self.DamageRange)
                {
                    continue;
                }
                if (self.HurtIds.Contains(uu.Id))
                {
                    continue;
                }
                self.HurtIds.Add(uu.Id);
                self.SkillHandler.OnCollisionUnit(uu);
            }
        }
    }
}
