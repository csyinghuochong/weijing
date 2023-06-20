using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace ET
{

    [Timer(TimerType.RoleBullet1Timer)]
    public class RoleBullet1Timer : ATimer<RoleBullet1Componnet>
    {
        public override void Run(RoleBullet1Componnet self)
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
    public class RoleBullet1ComponnetAwake : AwakeSystem<RoleBullet1Componnet>
    {
        public override void Awake(RoleBullet1Componnet self)
        {

        }
    }

    [ObjectSystem]
    public class RoleBullet1ComponnetDestroy : DestroySystem<RoleBullet1Componnet>
    {
        public override void Destroy(RoleBullet1Componnet self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class RoleBullet1ComponnetSystem
    {

        public static void OnBaseBulletInit(this RoleBullet1Componnet self,  SkillHandler skillHandler, long masterid)
        {
            self.PassTime = 0;
            self.Masterid = masterid;
            self.BuffState = BuffState.Running;
            self.SkillHandler = skillHandler;
            self.BeginTime = TimeHelper.ServerNow();
            self.DelayTime = (long)(1000 * skillHandler.SkillConf.SkillDelayTime);
            self.DamageRange = skillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageRange) + (float)skillHandler.SkillConf.DamgeRange[0];
            self.BuffEndTime = 1000 * (int)skillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime) + skillHandler.SkillConf.SkillLiveTime + TimeHelper.ServerNow();

            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.RoleBullet1Timer, self);
        }


        public static void OnUpdate(this RoleBullet1Componnet self)
        {
            self.PassTime = TimeHelper.ServerNow() - self.BeginTime;
            if (self.PassTime <= self.DelayTime)
            {
                return;
            }

            Unit unit = self.GetParent<Unit>();
            if (unit.IsDisposed || self.SkillHandler.TheUnitFrom.IsDisposed || TimeHelper.ServerNow() > self.BuffEndTime)
            {
                //移除Unity
                unit.GetParent<UnitComponent>().Remove(unit.Id);
                self.BuffState = BuffState.Finished;
                return;
            }

            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i];
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (uu.IsDisposed || uu.Id == unit.Id || uu.Id == self.Masterid)
                {
                    continue;
                }
                if (self.SkillHandler.HurtIds.Contains(uu.Id))
                {
                    continue;
                }

                //检测目标是否在技能范围
                if (Vector3.Distance(unit.Position, uu.Position) > self.DamageRange)
                {
                    continue;
                }

                self.SkillHandler.HurtIds.Add(uu.Id);
                self.SkillHandler.OnCollisionUnit(uu);
            }
        }

    }
}
