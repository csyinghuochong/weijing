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
            if (unit.IsDisposed || self.SkillHandler.TheUnitFrom.IsDisposed || TimeHelper.ServerNow() > self.BuffEndTime)
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
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (uu.IsDisposed || uu.Id == unit.Id || uu.Id == self.Masterid)
                {
                    continue;
                }
                if (self.SkillHandler.HurtIds.Contains(uu.Id))
                {
                    continue;
                }

                //弹道碰弹道无效
                if (uu.Type == UnitType.Bullet && unit.Type == UnitType.Bullet)
                {
                    continue;
                }

                /*
                Shape shape = self.SkillHandler.ICheckShape[0];
                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    Log.Debug($"碰撞位置圆： x: {circle.s_position.x}  z: {circle.s_position.z}");
                }
                if (shape is Rectangle)
                {
                    Rectangle circle = (Rectangle)shape;
                    Log.Debug($"碰撞位置矩： x: {circle.s_position.x}  z: {circle.s_position.z}");
                }
                //检测目标是否在技能范围
                if (!self.SkillHandler.CheckShape(uu.Position))
                {
                    continue;
                }
                */

                //检测目标是否在技能范围
                //圆形
                if (self.SkillHandler.SkillConf.DamgeRangeType == 1)
                {
                    if (Vector3.Distance(unit.Position, uu.Position) > self.DamageRange)
                    {
                        continue;
                    }
                }

                //方形
                if (self.SkillHandler.SkillConf.DamgeRangeType == 2)
                {
                    Rectangle ishape = self.SkillHandler.ICheckShape[0] as Rectangle;
                    ishape.s_position = unit.Position;

                    ishape.s_forward = (unit.Rotation * Vector3.forward).normalized;
                    int targetAngle = (int)Quaternion.QuaternionToEuler(unit.Rotation).y;
                    ishape.s_forward = (Quaternion.Euler(0, targetAngle, 0) * Vector3.forward).normalized;
                    ishape.x_range = (float)(self.SkillHandler.SkillConf.DamgeRange[0]) * 0.5f;
                    ishape.z_range = (float)(self.SkillHandler.SkillConf.DamgeRange[1] + 0);
                    //ishape.if333 = true;
                    self.SkillHandler.ICheckShape[0] = ishape;
    
                    if (!self.SkillHandler.CheckShape(uu.Position))
                    {
                        continue;
                    }
                    else {
                        if (self.SkillHandler.SkillConf.Id == 62004306)
                        {
                            Log.Info("logo =  uu.Position = " + uu.Position + " unit.Position = " + unit.Position + "ishape.x_range = " + ishape.x_range + " ishape.z_range" + ishape.z_range + " uu.Id = " + uu.Id + " unit.Id = " + unit.Id + " uu.Type = " + uu.Type + "unit.Type = " + unit.Type + " unit.rotation = " + Quaternion.QuaternionToEuler(unit.Rotation) + " uu.rotation = " + Quaternion.QuaternionToEuler(uu.Rotation) + ishape.s_forward);
                        }
                    }
                }


                //监测到对应碰撞体触发伤害
                self.SkillHandler.HurtIds.Add(uu.Id);
                self.SkillHandler.OnCollisionUnit(uu);
            }
        }

    }
}
