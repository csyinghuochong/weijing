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
        public static SkillCDItem GetSkillCD(this SkillManagerComponent self, int skillId)
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
            SkillCDItem skillCD = self.GetSkillCD(skillId);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zoneScene"></param>
        /// <param name="operatype">1新增  2移除</param>
        /// <param name="stateType"></param>
        /// <param name="stateValue"></param>
        public static void SendUpdateState(this SkillManagerComponent self, int operatype, long stateType, string stateValue)
        {
            C2M_UnitStateUpdate c2M_UnitStateUpdate = new C2M_UnitStateUpdate() { StateOperateType = operatype, StateType = stateType, StateValue = stateValue };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(c2M_UnitStateUpdate);
            if (operatype == 2 && stateType == (long)StateTypeEnum.Singing)
            {
                return;
            }
            if (operatype == 1 && stateType == (long)StateTypeEnum.Singing)
            {
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(stateValue));
                self.WaitUseSkill((long)(skillConfig.SkillFrontSingTime * 1000)).Coroutine();
            }
        }
        public static async ETTask WaitUseSkill(this SkillManagerComponent self, long waitTime)
        {
            await TimerComponent.Instance.WaitAsync(waitTime);
            Unit unit = self.GetParent<Unit>();
            if (!unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Singing))
            {
                return;
            }
            C2M_SkillCmd skillCmd = self.SkillCmd;
            self.SendUseSkill(skillCmd.SkillID, skillCmd.ItemId, skillCmd.TargetAngle, skillCmd.TargetID, skillCmd.TargetDistance, false).Coroutine();
        }

        public static async ETTask<int> SendUseSkill(this SkillManagerComponent self, int skillid, int itemId, int angle, long targetId, float distance, bool checksing = true)
        {
            try
            {
                Unit unit = self.GetParent<Unit>();
                C2M_SkillCmd skillCmd = self.SkillCmd;
                skillCmd.SkillID = skillid;
                skillCmd.TargetAngle = angle;
                skillCmd.TargetID = targetId;
                skillCmd.ItemId = itemId;
                skillCmd.TargetDistance = distance;
                int errorCode = self.CanUseSkill(skillid);

                Log.Debug($"errorCode: {errorCode}");
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillid);
                if (skillConfig.SkillFrontSingTime == 0f)
                {
                    checksing = false;
                }
                if (checksing && skillConfig.SkillFrontSingTime > 0)
                {
                    if (unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Singing))
                    {
                        return errorCode;
                    }
                    self.SendUpdateState(1, (int)StateTypeEnum.Singing, skillCmd.SkillID.ToString());
                    return ErrorCore.ERR_Success;
                }
                unit.GetComponent<StateComponent>().BeginMoveOrSkill();
                unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.NetWait);
                M2C_SkillCmd m2C_SkillCmd = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(skillCmd) as M2C_SkillCmd;
                unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.NetWait);
                if (m2C_SkillCmd.Error == 0)
                {
                    self.AddSkillCD(skillid, m2C_SkillCmd);
                    BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                    int weaponSkill = SkillHelp.GetWeaponSkillID(skillid, bagComponent.GetEquipType());
                    SkillConfig skillWeaponConfig = SkillConfigCategory.Instance.Get(weaponSkill);
                    unit.GetComponent<StateComponent>().RigidityEndTime = (long)(skillWeaponConfig.SkillRigidity * 1000) + TimeHelper.ServerNow();
                }
                return m2C_SkillCmd.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }


        public static void AddSkillCD(this SkillManagerComponent self, int skillId, M2C_SkillCmd skillCmd)
        {
            //添加技能CD列表
            SkillCDItem skillcd = self.GetSkillCD(skillId);
            if (skillcd == null)
            {
                skillcd = new SkillCDItem();
                self.SkillCDs.Add(skillcd);
            }
            skillcd.SkillID = skillId;
            skillcd.CDEndTime = skillCmd.CDEndTime + 100;
            self.SkillPublicCDTime = skillCmd.PublicCDTime + 100;
            EventType.SkillCD.Instance.Unit = self.GetParent<Unit>();
            Game.EventSystem.PublishClass(EventType.SkillCD.Instance);
            self.AddSkillTimer();
        }

        public static void AddSkillTimer(this SkillManagerComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.SkillTimer, self);
            }
        }

        public static void OnUseSkill(this SkillManagerComponent self, M2C_UnitUseSkill skillcmd )
        {
            Unit unit = self.GetParent<Unit>();
            //野怪技能指示器
            for (int i = 0; i < skillcmd.SkillInfos.Count; i++)
            {
                SkillConfig skillConfig1 = SkillConfigCategory.Instance.Get(skillcmd.SkillInfos[i].WeaponSkillID);
                int effctId = skillConfig1.SkillEffectID[0];
                if (effctId != 0 && !EffectConfigCategory.Instance.Contain(effctId))
                {
                    Log.Debug($"无效的effectid {effctId}");
                    continue;
                }

                ASkillHandler skillHandler = (ASkillHandler)ObjectPool.Instance.Fetch(SkillDispatcherComponent.Instance.SkillTypes[skillConfig1.GameObjectName]);
                skillHandler.OnInit(skillcmd.SkillInfos[i], unit);
                self.Skills.Add(skillHandler);
            }
            self.AddSkillTimer();
            if (skillcmd.SkillID == 0)
            {
                return;
            }
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillcmd.SkillInfos[0].WeaponSkillID);
            if (skillcmd.ItemId > 0 && !unit.GetComponent<MoveComponent>().IsArrived())
            {
                EventType.PlayAnimator.Instance.Animator = skillConfig.SkillAnimation;
                EventType.PlayAnimator.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.PlayAnimator.Instance);
                return;
            }
            if (!string.IsNullOrEmpty(skillConfig.SkillAnimation) && skillConfig.SkillAnimation != "0")
            {
                unit.Rotation = Quaternion.Euler(0, skillcmd.SkillInfos[0].TargetAngle, 0);
                EventType.FsmChange.Instance.FsmHandlerType = skillConfig.ComboSkillID > 0 ? 5 : 4;
                EventType.FsmChange.Instance.FsmValue = skillcmd.SkillInfos[0].WeaponSkillID;
                EventType.FsmChange.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.FsmChange.Instance);
            }
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

            SkillCDItem skillCDList = self.GetSkillCD(skillId);
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
