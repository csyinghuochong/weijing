using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using System.Numerics;
using OfficeOpenXml.Drawing.Chart;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

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
            //if (self.PassTime <= self.DelayTime)
            //{
            //    return;
            //}

            Unit unit = self.GetParent<Unit>();
            if (unit.IsDisposed || self.SkillHandler.TheUnitFrom.IsDisposed || TimeHelper.ServerNow() > self.BuffEndTime || self.SkillHandler.IsFinished())
            {
                //移除Unity
                unit.GetParent<UnitComponent>().Remove(unit.Id);
                self.BuffState = BuffState.Finished;
                return;
            }

            //获取当前全部的unit进行范围监测
            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            self.SkillHandler.UpdateCheckPoint(unit.Position);

            //Log.Debug($"子弹位置： x: {unit.Position.x}  z: {unit.Position.z}");
            for (int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i];
                
                if (uu.IsDisposed || uu.Id == unit.Id || uu.Id == self.Masterid)
                {
                    continue;
                }
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (!uu.IsCanBeAttack() || self.SkillHandler.HurtIds.Contains(uu.Id))
                {
                    continue;
                }

                if (self.SkillHandler.CheckShape(uu.Position))
                {
                    //监测到对应碰撞体触发伤害
                    self.SkillHandler.HurtIds.Add(uu.Id);
                }
                self.SkillHandler.OnCollisionUnit(uu);
            }
        }

    }
}
