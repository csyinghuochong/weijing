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

        public static void CheckHuiXue(this SkillPassiveComponent self)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong((int)NumericType.Now_Hp) >= numericComponent.GetAsLong((int)NumericType.Now_MaxHp))
                return;

            self.GetParent<Unit>().GetComponent<NumericComponent>().ApplyChange(null, NumericType.Now_Hp,
                (long)(numericComponent.GetAsLong((int)NumericType.Now_MaxHp) * 0.1f), 0, true);
        }

        public static void Activeted(this SkillPassiveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.SkillPassive, self);

            Unit unit = self.GetParent<Unit>();
            if (unit.GetComponent<UnitInfoComponent>().Type == UnitType.Player)
            {
                int equipId = unit.GetComponent<BagComponent>().GetWuqiItemId();
                self.OnTrigegerPassiveSkill(SkillPassiveTypeEnum.WandBuff_8, equipId);
            }
        }

        public static void Check(this SkillPassiveComponent self)
        {
            UnitInfoComponent unitInfoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.Type == UnitType.Pet)
            {
                self.CheckHuiXue();
            }

            self.OnTrigegerPassiveSkill( SkillPassiveTypeEnum.XueLiang_2 );
        }

        public static void AddRolePassiveSkill(this SkillPassiveComponent self, int skilId)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skilId);
            self.AddPassiveSkillByType(skillConfig);
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
            int configId = self.GetParent<Unit>().GetComponent<UnitInfoComponent>().UnitCondigID;
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(configId);
            int[] aiSkillIDList = MonsterCof.SkillID;

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

        public static void UpdatePetPassiveSkill(this SkillPassiveComponent self)
        {
            self.SkillPassiveInfos.Clear();
            int configId = self.GetParent<Unit>().GetComponent<UnitInfoComponent>().UnitCondigID;
            PetConfig MonsterCof = PetConfigCategory.Instance.Get(configId);
            int zhuanZhuSkillID = int.Parse(MonsterCof.ZhuanZhuSkillID);

            SkillConfig skillConfig = null;
            if (zhuanZhuSkillID != 0)
            {
                skillConfig = SkillConfigCategory.Instance.Get(zhuanZhuSkillID);
                self.AddPassiveSkillByType(skillConfig);
            }

            string[] baseSkillID = MonsterCof.BaseSkillID.Split(';');
            for (int i = 0; i < baseSkillID.Length; i++ )
            {
                int baseSkillId = int.Parse(baseSkillID[i]);
                if (baseSkillId == 0)
                {
                    continue;
                }

                skillConfig = SkillConfigCategory.Instance.Get(baseSkillId);
                self.AddPassiveSkillByType(skillConfig);
            }
        }

        public static void AddPassiveSkillByType(this SkillPassiveComponent self,SkillConfig  skillConfig)
        {
            if (skillConfig.PassiveSkillType == 0)
                return;
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

        public static void OnTrigegerPassiveSkill(this SkillPassiveComponent self, SkillPassiveTypeEnum skillPassiveTypeEnum, long targetId = 0)
        {
            List<SkillPassiveInfo> skillPassiveInfos = new List<SkillPassiveInfo>();
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

            SkillPassiveInfo skillIfo = skillPassiveInfos[RandomHelper.RandomNumber(0, skillPassiveInfos.Count)];
            if (skillPassiveTypeEnum == SkillPassiveTypeEnum.WandBuff_8)
            {
                int weapontype = Convert.ToInt32(skillIfo.SkillPro);
                int buffId = SkillConfigCategory.Instance.Get(skillIfo.SkillId).InitBuffID[0];
                ItemEquipType weaponType = targetId == 0 ? ItemEquipType.Common: (ItemEquipType)ItemConfigCategory.Instance.Get((int)targetId).EquipType;
                if (weaponType != (ItemEquipType)weapontype)
                {
                    self.GetParent<Unit>().GetComponent<BuffManagerComponent>().BuffRemove(buffId);
                }
                if (weaponType == (ItemEquipType)weapontype)
                {
                    BuffData buffData_1 = new BuffData();
                    buffData_1.BuffConfig = SkillBuffConfigCategory.Instance.Get(buffId);
                    buffData_1.BuffClassScript = buffData_1.BuffConfig.BuffScript;
                    self.GetParent<Unit>().GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, self.GetParent<Unit>(), null);
                }
                return;
            }

            //只触发一次
            if (skillIfo.LastTriggerTime > 0 && skillIfo.TriggerOnce == 1)
            {
                return;
            }
            //触发限制
            if (skillIfo.TriggerInterval > 0 && TimeHelper.ServerNow() - skillIfo.LastTriggerTime < skillIfo.TriggerInterval)
            {
                return;
            }
            bool trigger = false;
            switch (skillPassiveTypeEnum)
            {
                case SkillPassiveTypeEnum.AckGaiLv_1:
                    trigger = skillIfo.SkillPro >=  RandomHelper.RandFloat01();
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
                    trigger = skillIfo.SkillPro >= RandomHelper.RandFloat01();
                    break;
            }

            if (!trigger)
            {
                return;
            }

            Unit unit = self.GetParent<Unit>();
            C2M_SkillCmd cmd = new C2M_SkillCmd();
            cmd.TargetAngle = (int)Quaternion.QuaternionToEuler(unit.Rotation).y;
            cmd.SkillID = skillIfo.SkillId;

            if (targetId == 0 && unit.GetComponent<AIComponent>() != null)
            {
                targetId = unit.GetComponent<AIComponent>().TargetID;
            }
            cmd.TargetID = targetId;

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillIfo.SkillId);
            if (!string.IsNullOrEmpty(skillConfig.SkillAnimation) && skillConfig.SkillAnimation != "0")
            {
                unit.Stop(0);
            }
            int error = unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd).Item1;
            if (error == ErrorCore.ERR_Success)
            {
                skillIfo.LastTriggerTime = TimeHelper.ServerNow();
            }
        }
    }
}
