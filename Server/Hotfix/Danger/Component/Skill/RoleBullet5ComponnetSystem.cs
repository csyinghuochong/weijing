using System;
using System.Collections.Generic;

namespace ET
{
    [Timer(TimerType.RoleBullet5Timer)]
    public class RoleBullet5Timer: ATimer<RoleBullet5Componnet>
    {
        public override void Run(RoleBullet5Componnet self)
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
    public class RoleBullet5ComponnetAwake: AwakeSystem<RoleBullet5Componnet>
    {
        public override void Awake(RoleBullet5Componnet self)
        {
        }
    }

    [ObjectSystem]
    public class RoleBullet5ComponnetDestroy: DestroySystem<RoleBullet5Componnet>
    {
        public override void Destroy(RoleBullet5Componnet self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class RoleBullet5ComponnetSystem
    {
        public static void OnBaseBulletInit(this RoleBullet5Componnet self, SkillHandler skillHandler, long masterid)
        {
            self.PassTime = 0;
            self.Masterid = masterid;
            self.BuffState = BuffState.Running;
            self.SkillHandler = skillHandler;
            self.BeginTime = TimeHelper.ServerNow();
            self.DelayTime = (long)(1000 * skillHandler.SkillConf.SkillDelayTime);
            self.DamageRange = skillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageRange) + (float)skillHandler.SkillConf.DamgeRange[0];
            self.BuffEndTime = 1000 * (int)skillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime) +
                    skillHandler.SkillConf.SkillLiveTime + TimeHelper.ServerNow();

            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.RoleBullet5Timer, self);
        }

        public static void OnUpdate(this RoleBullet5Componnet self)
        {
            Unit bullet = self.GetParent<Unit>();
            UnitComponent unitComponent = bullet.GetParent<UnitComponent>();
            long nowTime = TimeHelper.ServerNow();
            if (bullet.IsDisposed || self.SkillHandler.TheUnitFrom.IsDisposed || nowTime > self.BuffEndTime || self.SkillHandler.IsFinished())
            {
                unitComponent.Remove(bullet.Id);
                self.BuffState = BuffState.Finished;
                return;
            }

            //获取当前全部的unit进行范围监测
            List<Unit> units = unitComponent.GetAll();
            self.SkillHandler.UpdateCheckPoint(bullet.Position);

            for (int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i];

                if (uu.IsDisposed || uu.Id == bullet.Id || uu.Id == self.Masterid)
                {
                    continue;
                }

                if (!self.SkillHandler.CheckShape(uu.Position))
                {
                    continue;
                }

                if (MongoHelper.WuDiBullet && !ComHelp.IsInnerNet())
                {
                    continue;
                }

                if (!uu.IsCanBeAttack())
                {
                    continue;
                }
                
                if (!self.SkillHandler.TheUnitFrom.IsCanAttackUnit(uu))
                {
                    continue;
                }

                if (!self.SkillHandler.HurtIds.Contains(uu.Id))
                {
                    self.SkillHandler.HurtIds.Add(uu.Id);
                }

                Skill_ComTargetMove_RangDamge_5 handler = self.SkillHandler as Skill_ComTargetMove_RangDamge_5;
                if (!self.SkillHandler.LastHurtTimes.ContainsKey(uu.Id))
                {
                    // 第一次伤害
                    self.SkillHandler.LastHurtTimes.Add(uu.Id, nowTime);
                    self.SkillHandler.OnCollisionUnit(uu);
                    // 推怪
                    handler.PushUnit(uu);
                }

                if (self.SkillHandler.SkillTriggerInvelTime > 0)
                {
                    // 间隔伤害
                    if (nowTime - self.SkillHandler.LastHurtTimes[uu.Id] > self.SkillHandler.SkillTriggerInvelTime)
                    {
                        self.SkillHandler.OnCollisionUnit(uu);
                        self.SkillHandler.LastHurtTimes[uu.Id] = nowTime;
                    }
                }

                handler.ReSetPush(uu);
            }
        }
    }
}