using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.SkillTimer)]
    public class SkillViewTimer : ATimer<SkillManagerComponent>
    {
        public override void Run(SkillManagerComponent self)
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
    public class SkillManagerComponentAwakeSystem : AwakeSystem<SkillManagerComponent>
    {
        public override void Awake(SkillManagerComponent self)
        {
            self.Skills.Clear();
            self.SkillCDs.Clear();
            self.FangunSkillId = int.Parse(GlobalValueConfigCategory.Instance.Get(2).Value);
            self.SkillPublicCDTime = 0;
        }
    }

    [ObjectSystem]
    public class SkillManagerComponentDestroySystem : DestroySystem<SkillManagerComponent>
    {
        public override void Destroy(SkillManagerComponent self)
        {
            self.OnDispose();
            self.SkillCDs.Clear();
        }
    }

    /// <summary>
    /// 技能管理
    /// </summary>

    public static class SkillManagerComponentSystem
    {
        public static SkillCDList GetSkillCD(this SkillManagerComponent self, int skillId)
        {
            for (int i = 0; i < self.SkillCDs.Count; i++)
            {
                if (self.SkillCDs[i].SkillID == skillId)
                {
                    return self.SkillCDs[i];
                }
            }
            return null;
        }

        public static long GetCdTime(this SkillManagerComponent self, int skillId, long nowTime)
        {
            SkillCDList skillCD = self.GetSkillCD(skillId);
            if (skillCD!=null)
            {
                return skillCD.CDEndTime - nowTime;
            }
            return 0;
        }

        public static void OnUpdate(this SkillManagerComponent self)
        {
            long nowTime = TimeHelper.ServerNow();
            for (int i = self.SkillCDs.Count - 1; i >= 0; i--)
            {
                if (self.SkillCDs[i].CDEndTime < nowTime)
                {
                    self.SkillCDs.RemoveAt(i);
                }
            }

            for (int i = self.Skills.Count - 1; i >= 0; i--)
            {
                ASkillHandler skillHandler = self.Skills[i];
                if (skillHandler.IsSkillFinied())
                {
                    skillHandler.OnFinished();
                    self.Skills.RemoveAt(i);
                    ObjectPool.Instance.Recycle(skillHandler);
                    continue;
                }
                self.Skills[i].OnUpdate();
            }

            if (self.Skills.Count == 0 && self.SkillCDs.Count == 0 && self.Timer!=0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void OnDispose(this SkillManagerComponent self)
        {
            for (int i = self.Skills.Count - 1; i >= 0; i--)
            {
                ASkillHandler skillHandler = self.Skills[i];
                skillHandler.OnFinished();
                self.Skills.RemoveAt(i);
                ObjectPool.Instance.Recycle(skillHandler);
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void AddSkillCD(this SkillManagerComponent self, int skillId, SkillConfig skillConfig, long cdEndTime)
        {
            //添加技能CD列表
            if (cdEndTime == 0)
            {
                return;
            }

            SkillCDList skillcd = self.GetSkillCD(skillId);
            if (skillcd == null)
            {
                skillcd = new SkillCDList();
                self.SkillCDs.Add(skillcd);
            }
            skillcd.SkillID = skillId;
            skillcd.CDStartTime = TimeHelper.ServerNow();
            skillcd.CDEndTime = cdEndTime + 200;
            if (skillConfig.IfPublicSkillCD == 0)
            {
                //添加技能公共CD /公共1秒CD  
                self.SkillPublicCDTime = skillcd.CDStartTime + 1200;
            }
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.SkillTimer, self);
            }
            EventType.SkillCD.Instance.Unit = self.GetParent<Unit>();
            Game.EventSystem.PublishClass(EventType.SkillCD.Instance);
        }

        public static void OnUseSkill(this SkillManagerComponent self, M2C_UnitUseSkill skillcmd )
        {
            Unit from = self.GetParent<Unit>();
            //野怪技能指示器
            for (int i = 0; i < skillcmd.SkillInfos.Count; i++)
            {
                SkillConfig skillConfig1 = SkillConfigCategory.Instance.Get(skillcmd.SkillInfos[i].WeaponSkillID);

                ASkillHandler skillHandler = (ASkillHandler)ObjectPool.Instance.Fetch(SkillDispatcherComponent.Instance.SkillTypes[skillConfig1.GameObjectName]);
                skillHandler.OnInit(skillcmd.SkillInfos[i], from);
                self.Skills.Add(skillHandler);
                self.OnShowSkillIndicator(skillcmd.SkillInfos[i]);
            }

            if (from.MainHero && self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.SkillTimer, self);
            }
            if (skillcmd.SkillID == 0)
            {
                //随机延迟释放的技能，不再播放动作和计入CD
                return;
            }

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillcmd.SkillInfos[0].WeaponSkillID);
            if (!string.IsNullOrEmpty(skillConfig.SkillAnimation) && skillConfig.SkillAnimation != "0")
            {
                from.Rotation = Quaternion.Euler(0, skillcmd.SkillInfos[0].TargetAngle, 0);
                EventType.FsmChange.Instance.FsmHandlerType = skillConfig.ComboSkillID > 0 ? 5 : 4;
                EventType.FsmChange.Instance.FsmValue = skillcmd.SkillInfos[0].WeaponSkillID;
                EventType.FsmChange.Instance.Unit = from;
                Game.EventSystem.PublishClass(EventType.FsmChange.Instance);
            }
        }

        public static void  OnShowSkillIndicator(this SkillManagerComponent self, SkillInfo skillcmd)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.GetComponent<UnitInfoComponent>().Type != UnitType.Monster)
                return;

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            if (skillConfig.SkillZhishiType == 0)
                return;
            if (skillConfig.SkillDelayTime == 0)
                return;

            EventType.SkillYuJing.Instance.Unit = unit;
            EventType.SkillYuJing.Instance.SkillInfo = skillcmd;
            EventType.SkillYuJing.Instance.SkillConfig = skillConfig;
            Game.EventSystem.PublishClass(EventType.SkillYuJing.Instance);
        }

        public static void InterruptSkill(this SkillManagerComponent self, int skillId)
        {
            for (int i = self.Skills.Count - 1; i >= 0; i--)
            {
                ASkillHandler skillHandler = self.Skills[i];
                if (skillHandler.SkillConf.Id != skillId)
                {
                    continue;
                }
                skillHandler.SetSkillState(SkillState.Finished);
            }
        }

        public static int CanUseSkill(this SkillManagerComponent self, int skillId)
        {
            Unit unit = self.GetParent<Unit>();

            SkillCDList skillCDList = self.GetSkillCD(skillId);
            if (skillCDList != null )
            {
                return 1;
            }
            if (TimeHelper.ServerNow() < self.SkillPublicCDTime)
            {
                return 2;
            }
            if (!unit.GetComponent<StateComponent>().CanUseSkill())
            {
                return 3;
            }
            return 0;
        }
    }

}
