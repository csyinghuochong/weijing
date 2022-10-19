using UnityEngine;
using System;

namespace ET
{

    [Timer(TimerType.FsmTimer)]
    public class FsmTimer : ATimer<FsmComponent>
    {
        public override void Run(FsmComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class FsmComponentAwakeSystem: AwakeSystem<FsmComponent>
    {
        public override void Awake(FsmComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            self.Animator = unit.GetComponent<AnimatorComponent>().Animator;
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            bool idle = moveComponent == null || moveComponent.IsArrived();
            self.ChangeState(idle ? FsmStateEnum.FsmIdleState : FsmStateEnum.FsmRunState, "");
        }
    }

    [ObjectSystem]
    public class FsmComponentDestroySystem : DestroySystem<FsmComponent>
    {
        public override void Destroy(FsmComponent self)
        {
            self.EndTimer();
        }
    }

    /// <summary>
    /// 适用于动画切换的栈式状态机
    /// </summary>
    public static class FsmComponentSystem
    {
        public static void Check(this FsmComponent self)
        {
            if (self.Animator == null)
            {
                int monsterId = self.GetParent<Unit>().GetComponent<UnitInfoComponent>().UnitCondigID;
                Log.Error($"{self.Animator == null} {self.GetParent<Unit>().UpdateUIType} {monsterId}");
                self.EndTimer();
                return;
            }

            switch (self.CurrentFsm)
            {
                case FsmStateEnum.FsmRunState:
                    if (TimeHelper.ClientNow() >= self.SkillMoveTime && self.SkillMoveTime != 0)
                    {
                        self.SetRunState();
                        self.EndTimer();
                    }
                    break;
                case FsmStateEnum.FsmSkillState:
                    if (self.SkillSingTime > 0 && TimeHelper.ClientNow() >= self.SkillSingTime)
                    {
                        self.Animator.SetBool("Idle", true);
                        self.EndTimer();
                    }
                    if (self.SkillSingTime == 0 && TimeHelper.ClientNow() >= self.SkillRigibTime)
                    {
                        self.Animator.SetBool("Idle", true);
                        self.EndTimer();
                    }
                    break;
            }
        }

        public static void EndTimer(this FsmComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void BeginTimer(this FsmComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.FsmTimer, self);
            }
        }

        public static void ChangeState(this FsmComponent self, int targetFsm, string parasmss = "")
        {
            if (self.Animator == null)
            {
                return;
            }
            switch (self.CurrentFsm)
            {
                case FsmStateEnum.FsmRunState:
                    if (targetFsm == FsmStateEnum.FsmRunState)
                    {
                        return;
                    }
                    break;
                case FsmStateEnum.FsmComboState:
                    break;
                case FsmStateEnum.FsmDeathState:
                    self.Animator.SetBool("Death", false);
                    break;
                case FsmStateEnum.FsmNpcSpeak:
                    self.Animator.SetBool("Idle", true);
                    break;
                case FsmStateEnum.FsmSinging:
                    self.Animator.SetBool("Run", false);
                    self.Animator.SetBool("Idle", true);
                    break;
                case FsmStateEnum.FsmSkillState:
                    self.Animator.SetBool("Run", false);
                    self.Animator.SetBool("Idle", true);
                    break;
                default:
                    break;
            }

            switch (targetFsm)
            {
                case FsmStateEnum.FsmComboState:
                    //this.ClearnAnimator();
                    self.Animator.SetBool("Idle", false);
                    self.Animator.SetBool("Run", false);
                    self.OnEnterFsmComboState(parasmss);
                    break;
                case FsmStateEnum.FsmDeathState:
                    self.Animator.SetBool("Idle", false);
                    self.Animator.SetBool("Death", true);
                    self.Animator.Play("Death");
                    break;
                case FsmStateEnum.FsmHui:
                    self.Animator.SetBool("Idle", false);
                    self.Animator.Play("Hui");
                    break;
                case FsmStateEnum.FsmIdleState:
                    self.OnEnterIdleState();
                    break;
                case FsmStateEnum.FsmNpcSpeak:
                    //this.ClearnAnimator();
                    self.Animator.SetBool("Idle", false);
                    self.Animator.SetBool("Run", false);
                    self.Animator.Play("Speak");
                    break;
                case FsmStateEnum.FsmRunState:
                    self.OnEnterFsmFsmRunState(parasmss);
                    break;
                case FsmStateEnum.FsmShiQuItem:
                    self.Animator.SetBool("Idle", false);
                    self.Animator.SetBool("Run", false);
                    self.Animator.Play("ShiQu");
                    break;
                case FsmStateEnum.FsmSinging:
                    self.Animator.SetBool("Idle", false);
                    self.Animator.SetBool("Run", false);
                    if (double.Parse(parasmss) > 0)
                    {
                        self.Animator.Play("YinChang");
                    }
                    break;
                case FsmStateEnum.FsmSkillState:
                    self.OnEnterFsmSkillState(parasmss);
                    break;
                case FsmStateEnum.FsmHorse:
                    self.Animator.SetBool("Idle", false);
                    self.Animator.SetBool("Run", false);
                    self.Animator.Play("Horse");
                    break;
                default:
                    break;
            }
            self.CurrentFsm = targetFsm;
        }

        public static void OnEnterFsmSkillState(this FsmComponent self, string paramss = "")
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
            long SkillMoveTime = (skillConfig.Id >= 61012201 && skillConfig.Id <= 61012206) ? skillConfig.SkillLiveTime + TimeHelper.ClientNow() : 0;
            paramss = $"{SkillMoveTime}@{skillConfig.SkillAnimation}@{skillConfig.SkillSingTime}@{skillConfig.SkillRigidity}";

            string[] animationinfos = paramss.Split('@');
            self.SkillMoveTime = long.Parse(animationinfos[0]);
            self.Animator.Play(animationinfos[1]);

            float singTime = float.Parse(animationinfos[2]);
            self.SkillSingTime = singTime == 0f ? 0 : TimeHelper.ClientNow() + (int)(1000f * singTime);

            float rigibTime = float.Parse(animationinfos[3]);
            self.SkillRigibTime = TimeHelper.ClientNow() + (int)(1000f * rigibTime);
            self.BeginTimer();
        }

        public static void OnEnterFsmFsmRunState(this FsmComponent self, string paramss = "")
        {
            if (TimeHelper.ClientNow() > self.SkillMoveTime)
            {
                self.SetRunState();
            }
            else
            {
                self.BeginTimer();
            }
        }

        public static bool IsSkillMoveTime(this FsmComponent self)
        {
            return TimeHelper.ClientNow() < self.SkillMoveTime;
        }

        public static void OnEnterIdleState(this FsmComponent self)
        {
            if (TimeHelper.ClientNow() > self.SkillMoveTime)
            {
                self.SetIdleState();
            }
        }

        public static void SetIdleState(this FsmComponent self)
        {
            self.Animator.SetBool("Run", false);
            self.Animator.SetBool("Idle", true);
            self.Animator.Play("Idle");
        }

        public static void SetRunState(this FsmComponent self)
        {
            self.SkillMoveTime = 0;
            self.Animator.SetBool("Idle", false);
            self.Animator.SetBool("Run", true);
            self.Animator.Play("Run");
        }

        public static void OnEnterFsmComboState(this FsmComponent self, string paramss = "")
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
            int EquipType = (int)ItemEquipType.Common;
            int itemId = (int)self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
            if (itemId != 0)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                EquipType = itemConfig.EquipType;
            }
            paramss = $"{skillConfig.SkillAnimation}@{EquipType}";

            string[] animations = paramss.Split('@');
            string animation = animations[0];
            if (EquipType != 2)
            {
                if (animation == "Act_1")
                {
                    animation = "Act_11";
                }
                if (animation == "Act_2")
                {
                    animation = "Act_12";
                }
                if (animation == "Act_3")
                {
                    animation = "Act_13";
                }
            }
            self.Animator.Play(animation);
        }

        public static void ClearnAnimator(this FsmComponent self)
        {
            //重置参数
            self.Animator.SetBool("Idle", false);
            self.Animator.SetBool("Run", false);
            self.Animator.SetBool("Death", false);
            self.Animator.SetBool("CriAct", false);
            self.Animator.SetBool("Act_1", false);
            self.Animator.SetBool("Act_2", false);
            self.Animator.SetBool("Act_3", false);
        }
    }
}