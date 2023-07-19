using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.SkillPassive)]
    public class SkillPassiveTimer : ATimer<SkillPassiveComponent>
    {
        public override void Run(SkillPassiveComponent self)
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


    [Timer(TimerType.MonsterSingingTimer)]
    public class MonsterSingingTimer : ATimer<SkillPassiveComponent>
    {
        public override void Run(SkillPassiveComponent self)
        {
            try
            {
                self.OnSingOver();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }


    [ObjectSystem]
    public class SkillPassiveComponentAwakeSystem : AwakeSystem<SkillPassiveComponent>
    {
        public override void Awake(SkillPassiveComponent self)
        {

        }
    }

    [ObjectSystem]
    public class SkillPassiveComponentDestroySystem : DestroySystem<SkillPassiveComponent>
    {
        public override void Destroy(SkillPassiveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class SkillPassiveComponentSystem
    {

        public static void Stop(this SkillPassiveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void Reset(this SkillPassiveComponent self)
        {
            for (int i = 0; i < self.SkillPassiveInfos.Count; i++)
            {
                self.SkillPassiveInfos[i].Reset();
            }
        }

        public static void Activeted(this SkillPassiveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) != 0)
            {
                return;
            }

            if (unit.Type == UnitType.Player)
            {
                int equipId = unit.GetComponent<BagComponent>().GetWuqiItemId();
                self.OnTrigegerPassiveSkill(SkillPassiveTypeEnum.WandBuff_8, equipId);
            }

            bool xueliangcheck = false;
            TimerComponent.Instance?.Remove(ref self.Timer);
            if (unit.Type == UnitType.Player || unit.Type == UnitType.Pet)
            {
                xueliangcheck = true;
            }
            else if (unit.Type == UnitType.Monster)
            {
                for (int i = 0; i < self.SkillPassiveInfos.Count; i++)
                {
                    if (self.SkillPassiveInfos[i].SkillPassiveTypeEnum == SkillPassiveTypeEnum.XueLiang_2)
                    {
                        xueliangcheck = true;
                        break;
                    }
                }
            }
            if (xueliangcheck)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.SkillPassive, self);
            }
            //缓存值
            self.UnitType = unit.Type;
            self.StateComponent = unit.GetComponent<StateComponent>();
            self.NumericComponent = unit.GetComponent<NumericComponent>();
        }

        public static void CheckHuiXue(this SkillPassiveComponent self)
        {
            self.HuixueTimeNum = self.HuixueTimeNum + 1;
            //5秒触发一次回血
            if (self.HuixueTimeNum >= 5)
            {
                self.HuixueTimeNum = 0;
            }
            else
            {
                return;
            }

            //只有玩家和宠物有回血
            if (self.UnitType == UnitType.Pet)
            {
                //满血不触发回血
                if (self.NumericComponent.GetAsLong((int)NumericType.Now_Hp) >= self.NumericComponent.GetAsLong((int)NumericType.Now_MaxHp))
                    return;

                //每5秒恢复5%生命
                self.NumericComponent.ApplyChange(null, NumericType.Now_Hp, (long)(self.NumericComponent.GetAsLong((int)NumericType.Now_MaxHp) * 0.05f), 0, true);
            }

            if (self.UnitType == UnitType.Player)
            {
                long maxHp = self.NumericComponent.GetAsLong(NumericType.Now_MaxHp);

                //满血不触发回血
                if (self.NumericComponent.GetAsLong((int)NumericType.Now_Hp) >= maxHp)
                    return;

                long addHpValue = 0;
                float now_SecHpAddPro = self.NumericComponent.GetAsFloat(NumericType.Now_SecHpAddPro);
                if (now_SecHpAddPro > 0f)
                {
                    addHpValue = (long)(maxHp * now_SecHpAddPro);
                }

                long now_HuiXue = self.NumericComponent.GetAsLong(NumericType.Now_HuiXue);
                if (now_HuiXue > 0f)
                {
                    addHpValue = now_HuiXue * 5;
                }

                if (addHpValue > 0)
                {
                    self.NumericComponent.ApplyChange(null, NumericType.Now_Hp, addHpValue, 0, true);
                }
            }
        }

        public static void Check(this SkillPassiveComponent self)
        {
            self.CheckHuiXue();
            self.OnTrigegerPassiveSkill(SkillPassiveTypeEnum.XueLiang_2, self.GetParent<Unit>().Id);
        }

        public static void AddRolePassiveSkill(this SkillPassiveComponent self, int skillId)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            self.AddPassiveSkillByType(skillConfig);
            self.CheckSkillTianFu(skillId, true);
        }

        public static void CheckSkillTianFu(this SkillPassiveComponent self, int skillId, bool active)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            if (skillConfig.SkillType == 1 || skillConfig.PassiveSkillType != 11)
            {
                return;
            }
            int tianfuid = int.Parse(skillConfig.ComObjParameter);
            self.GetParent<Unit>().GetComponent<SkillSetComponent>().AddiontTianFu(tianfuid, active);
        }

        public static void RemoveRolePassiveSkill(this SkillPassiveComponent self, int skillId)
        {
            for (int i = self.SkillPassiveInfos.Count - 1; i >= 0; i--)
            {
                if (self.SkillPassiveInfos[i].SkillId != skillId)
                {
                    continue;
                }
                self.SkillPassiveInfos.RemoveAt(i);
                break;
            }
            self.CheckSkillTianFu(skillId, false);
        }

        /// <summary>
        /// 更新角色被动技能
        /// </summary>
        /// <param name="self"></param>
        public static void UpdatePassiveSkill(this SkillPassiveComponent self)
        {
            self.SkillPassiveInfos.Clear();

            List<SkillPro> skillList = self.GetParent<Unit>().GetComponent<SkillSetComponent>().SkillList;
            for (int i = 0; i < skillList.Count; i++)
            {
                if (skillList[i].SkillSetType == (int)SkillSetEnum.Item)
                {
                    continue;
                }
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillList[i].SkillID);
                self.AddPassiveSkillByType(skillConfig);
            }
        }

        /// <summary>
        /// 更新怪物被动技能
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateMonsterPassiveSkill(this SkillPassiveComponent self)
        {
            self.SkillPassiveInfos.Clear();
            int configId = self.GetParent<Unit>().ConfigId;
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(configId);
            int[] aiSkillIDList = MonsterCof.SkillID;
            if (aiSkillIDList == null)
            {
                return;
            }
            for (int i = 0; i < aiSkillIDList.Length; i++)
            {
                if (aiSkillIDList[i] == 0)
                {
                    continue;
                }
                if (!SkillConfigCategory.Instance.Contain(aiSkillIDList[i]))
                {
                    continue;
                }
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(aiSkillIDList[i]);
                self.AddPassiveSkillByType(skillConfig);
            }
        }

        public static void UpdatePastureSkill(this SkillPassiveComponent self)
        {

        }

        public static void UpdateJingLingSkill(this SkillPassiveComponent self, int jinglingid)
        {
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(jinglingid);
            if (jingLingConfig.FunctionType == JingLingFunctionType.AddSkill)
            {
                self.AddRolePassiveSkill(int.Parse(jingLingConfig.FunctionValue));
            }
        }

        public static void UpdatePetPassiveSkill(this SkillPassiveComponent self, RolePetInfo rolePetInfo)
        {
            self.SkillPassiveInfos.Clear();
            int configId = self.GetParent<Unit>().ConfigId;
            PetConfig MonsterCof = PetConfigCategory.Instance.Get(configId);
            int zhuanZhuSkillID = int.Parse(MonsterCof.ZhuanZhuSkillID);

            SkillConfig skillConfig = null;
            if (zhuanZhuSkillID != 0)
            {
                skillConfig = SkillConfigCategory.Instance.Get(zhuanZhuSkillID);
                self.AddPassiveSkillByType(skillConfig);
            }

            string[] baseSkillID = MonsterCof.BaseSkillID.Split(';');
            for (int i = 0; i < baseSkillID.Length; i++)
            {
                int baseSkillId = int.Parse(baseSkillID[i]);
                if (baseSkillId == 0)
                {
                    continue;
                }

                skillConfig = SkillConfigCategory.Instance.Get(baseSkillId);
                self.AddPassiveSkillByType(skillConfig);
            }

            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                int baseSkillId = rolePetInfo.PetSkill[i];
                if (baseSkillId == 0)
                {
                    continue;
                }

                skillConfig = SkillConfigCategory.Instance.Get(baseSkillId);
                self.AddPassiveSkillByType(skillConfig);
            }
        }

        public static void AddPassiveSkillByType(this SkillPassiveComponent self, SkillConfig skillConfig)
        {
            if (skillConfig.SkillType == 1 || skillConfig.PassiveSkillType == 0)
            {
                return;
            }
            for (int i = 0; i < self.SkillPassiveInfos.Count; i++)
            {
                if (self.SkillPassiveInfos[i].SkillId == skillConfig.Id)
                {
                    return;
                }
            }

            SkillPassiveInfo skillPassiveInfo = new SkillPassiveInfo(skillConfig.PassiveSkillType, skillConfig.Id,
                (float)skillConfig.PassiveSkillPro, skillConfig.PassiveSkillTriggerOnce, skillConfig.SkillCD);
            self.SkillPassiveInfos.Add(skillPassiveInfo);
        }

        public static  void BeginSingSkill(this SkillPassiveComponent self, SkillPassiveInfo skillIfo, long targetId = 0)
        {
            TimerComponent.Instance.Remove(ref self.SingTimer);

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillIfo.SkillId);
            self.StateComponent.StateTypeAdd(StateTypeEnum.Singing, skillIfo.SkillId.ToString());
            self.SingTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + (long)(skillConfig.SkillFrontSingTime * 1000), TimerType.UISingingTimer, self);
        }

        public static void OnSingOver(this SkillPassiveComponent self)
        {
            if (self.SingSkillIfo != null)
            {
                self.ImmediateUseSkill(self.SingSkillIfo, self.SingTargetId);
            }
            self.StateComponent.StateTypeRemove(StateTypeEnum.Singing);
        }

        public static void BeAttacking(this SkillPassiveComponent self)
        {
            if (self.SingTimer > 0)
            {
                TimerComponent.Instance.Remove( ref self.SingTimer );
                self.StateComponent.StateTypeRemove(StateTypeEnum.Singing);
            }
        }

        public static void ImmediateUseSkill(this SkillPassiveComponent self,SkillPassiveInfo skillIfo, long targetId = 0)
        {
            Unit unit = self.GetParent<Unit>();
            List<long> targetIdList = new List<long>();
            AIComponent aIComponent = unit.GetComponent<AIComponent>();
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillIfo.SkillId);
            if (aIComponent != null)
            {
                targetId = aIComponent.TargetID;
                Unit aiTarget = unit.GetParent<UnitComponent>().Get(targetId);
                if (aiTarget != null && skillConfig.SkillTargetType == (int)SkillTargetType.TargetOnly
                    && PositionHelper.Distance2D(unit.Position, aiTarget.Position) > aIComponent.ActDistance)
                {
                    return;
                }

                if (skillConfig.SkillTargetType > 0)
                {
                    targetIdList.AddRange(AIHelp.GetNearestEnemyIds(unit, (float)aIComponent.ActRange, skillConfig.SkillTargetType));
                }
                else
                {
                    targetIdList.Add(targetId);
                }
            }
            if (targetIdList.Count == 0)
            {
                targetId = targetId > 0 ? targetId : self.GetParent<Unit>().Id;
                targetIdList.Add(targetId);
            }

            int targetAngle = (int)Quaternion.QuaternionToEuler(unit.Rotation).y;
            Unit target = unit.GetParent<UnitComponent>().Get(targetId);
            if (target != null && target.Id != targetId)
            {
                Vector3 direction = target.Position - unit.Position;
                targetAngle = (int)Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
            }
            SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();
            for (int i = 0; i < targetIdList.Count; i++)
            {
                C2M_SkillCmd cmd = self.C2M_SkillCmd;
                cmd.TargetAngle = targetAngle;
                cmd.SkillID = skillIfo.SkillId;
                cmd.TargetID = targetIdList[i];
                skillManagerComponent.OnUseSkill(cmd, false);
            }

            long serverTime = TimeHelper.ServerNow();
            long rigidityEndTime  = (long)(skillConfig.SkillRigidity * 1000) + serverTime;
            if (unit.IsDisposed)
            {
                Log.Debug("SkillPassiveComponent :unit.IsDisposed ");
                return;
            }
            self.StateComponent.SetRigidityEndTime(rigidityEndTime);
        }

        public static void OnTrigegerPassiveSkill(this SkillPassiveComponent self, int skillPassiveTypeEnum, long targetId = 0, int skillid = 0)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.Type == UnitType.Player)
            {
                ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
                if (chengJiuComponent.JingLingUnitId != 0 && unit.GetParent<UnitComponent>().Get(chengJiuComponent.JingLingUnitId) != null)
                {
                    Unit jingling = unit.GetParent<UnitComponent>().Get(chengJiuComponent.JingLingUnitId);
                    jingling.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(skillPassiveTypeEnum, targetId, skillid);
                }
            }

            using ListComponent<SkillPassiveInfo> skillPassiveInfos = ListComponent<SkillPassiveInfo>.Create();
            for (int i = 0; i < self.SkillPassiveInfos.Count; i++)
            {
                if (self.SkillPassiveInfos[i].SkillPassiveTypeEnum == (int)skillPassiveTypeEnum)
                {
                    skillPassiveInfos.Add(self.SkillPassiveInfos[i]);
                }
            }
            if (skillPassiveInfos.Count == 0)
            {
                return;
            }
            long serverTime = TimeHelper.ServerNow();
            for (int s = 0; s < skillPassiveInfos.Count; s++)
            {
                SkillPassiveInfo skillIfo = skillPassiveInfos[s];
                if (skillPassiveTypeEnum == SkillPassiveTypeEnum.WandBuff_8)
                {
                    int weapontype = Convert.ToInt32(skillIfo.SkillPro);
                    int buffId = SkillConfigCategory.Instance.Get(skillIfo.SkillId).InitBuffID[0];
                    int weaponType = targetId == 0 ? ItemEquipType.Common : (int)ItemConfigCategory.Instance.Get((int)targetId).EquipType;
                    if (weaponType != weapontype)
                    {
                        unit.GetComponent<BuffManagerComponent>().BuffRemove(buffId);
                    }
                    if (weaponType == weapontype)
                    {
                        BuffData buffData_1 = new BuffData();
                        buffData_1.SkillId = skillIfo.SkillId;
                        buffData_1.BuffId = buffId;
                        unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, unit, null);
                    }
                    continue;
                }
                //只触发一次
                if (skillIfo.LastTriggerTime > 0 && skillIfo.TriggerOnce == 1)
                {
                    continue;
                }
                //触发限制
                if (skillIfo.TriggerInterval > 0 && serverTime - skillIfo.LastTriggerTime < skillIfo.TriggerInterval)
                {
                    continue;
                }
                bool trigger = false;
                switch (skillPassiveTypeEnum)
                {
                    case SkillPassiveTypeEnum.AckGaiLv_1:
                        trigger = skillIfo.SkillPro >= RandomHelper.RandFloat01();
                        break;
                    case SkillPassiveTypeEnum.XueLiang_2:
                        NumericComponent numCom = self.GetParent<Unit>().GetComponent<NumericComponent>();
                        long nowHp = numCom.GetAsLong((int)NumericType.Now_Hp);
                        long maxHp = numCom.GetAsLong((int)NumericType.Now_MaxHp);
                        float hpPro = (float)nowHp / (float)maxHp;
                        trigger = hpPro <= skillIfo.SkillPro;   
                        break;
                    case SkillPassiveTypeEnum.BeHurt_3:
                    case SkillPassiveTypeEnum.Critical_4:
                    case SkillPassiveTypeEnum.ShanBi_5:
                    case SkillPassiveTypeEnum.WillDead_6:
                    case SkillPassiveTypeEnum.SkillGaiLv_7:
                    case SkillPassiveTypeEnum.AckDistance_9:
                    case SkillPassiveTypeEnum.AckDistance_10:
                        trigger = skillIfo.SkillPro >= RandomHelper.RandFloat01();
                        break;
                    case SkillPassiveTypeEnum.TeamerEnter:
                        trigger = true;
                        break;
                }
                if (!trigger)
                {
                    continue;
                }
                
                if (skillid == skillIfo.SkillId)
                {
                    Log.Debug($"SkillPassiveComponent: {skillIfo.SkillId}");
                    continue;
                }

                SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();   
                if (skillManagerComponent.IsCanUseSkill(skillIfo.SkillId) != ErrorCore.ERR_Success)
                {
                    continue;
                }

                //int weaponSkill = unit.GetWeaponSkill(skillIfo.SkillId);
                //SkillConfig skillConfig = SkillConfigCategory.Instance.Get(weaponSkill);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillIfo.SkillId);
                if (skillConfig.SkillFrontSingTime > 0f)
                {
                    self.BeginSingSkill(skillIfo, targetId);
                }
                else
                {
                    self.ImmediateUseSkill(skillIfo, targetId);
                }
                skillIfo.LastTriggerTime = serverTime;
            }
        }
    }
}
