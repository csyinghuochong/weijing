using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class AttackComponentAwakeSystem : AwakeSystem<AttackComponent>
    {
        public override void Awake(AttackComponent self)
        {

        }
    }

    [ObjectSystem]
    public class AttackComponentDestroySystemm : DestroySystem<AttackComponent>
    {
        public override void Destroy(AttackComponent self)
        {
            
        }
    }

    public static class AttackComponentSystem
    {
        public static void OnInit(this AttackComponent self)
        {
            //普通攻击
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ);
            self.UpdateSkillInfo(occConfig.InitActSkillID);

            self.UpdateComboTime();
        }

        public static void SetAttackSpeed(this AttackComponent self)
        {
            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float attackSpped = 1f + numericComponent.GetAsFloat(NumericType.Now_ActSpeedPro);
            self.SkillCDs = EquipType == (int)ItemEquipType.Knife ? new List<int>() { 500, 1000, 1000 } : new List<int>() { 800, 800, 800 };
            for (int i = 0; i < self.SkillCDs.Count; i++)
            {
                self.SkillCDs[i] = (int)(self.SkillCDs[i] / attackSpped);
            }
        }

        public static void SetComboSkill(this AttackComponent self, long timeNow)
        {
            if (timeNow - self.LastSkillTime > self.CombatEndTime)
            {
                self.ComboSkillId = self.SkillId;
            }
            else
            {
                self.ComboSkillId = SkillConfigCategory.Instance.Get(self.ComboSkillId).ComboSkillID;
            }

            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            if ((EquipType == (int)ItemEquipType.Sword
                || EquipType == (int)ItemEquipType.Common))
            {
                self.ComboSkillId = self.RandomGetSkill();
            }

            if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
            {
                self.ComboStartTime = 1250;
                self.CombatEndTime = 2000;
            }

            int index = self.SkillList.IndexOf(self.ComboSkillId);
            self.CDTime = self.SkillCDs[index];
        }

        //连击
        public static void UpdateComboTime(this AttackComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            if (bagComponent.GetEquipType() == ItemEquipType.Sword)
            {
                //剑
                self.ComboStartTime = 500;
                self.CombatEndTime = 1000;
            }
            else if (bagComponent.GetEquipType() == ItemEquipType.Knife)
            {
                //刀
                self.ComboStartTime = 1000;
                self.CombatEndTime = 2000;
            }
            else
            {
                //空手默认是剑
                self.ComboStartTime = 500;
                self.CombatEndTime = 1000;
            }
        }

        public static int RandomGetSkill(this AttackComponent self)
        {
            int index = RandomHelper.RandomByWeight(self.Weights);
            return self.SkillList[index];
        }

        public static int GetTargetAnagle(this AttackComponent self, Unit unit, Unit taretUnit)
        {
            if (taretUnit == null || taretUnit.IsDisposed)
            {
#if !SERVER && NOT_UNITY
                return (int)Quaternion.QuaternionToEuler(unit.Rotation).y;
#else
                return Mathf.FloorToInt(unit.Rotation.eulerAngles.y);
#endif
            }
            else
            {
#if !SERVER && NOT_UNITY
                Vector3 direction = taretUnit.Position - unit.Position;
                float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                return Mathf.FloorToInt(ange);
#else
                Vector3 direction = taretUnit.Position - unit.Position;
                float ange = Mathf.Rad2Deg * Mathf.Atan2(direction.x, direction.z);
                return Mathf.FloorToInt(ange);
#endif
            }
        }

        public static void AutoAttack_1(this AttackComponent self, Unit unit, Unit taretUnit)
        {
            long timeNow = TimeHelper.ClientNow();
            if (timeNow <= self.CDEndTime)
            {
                return;
            }
            self.SetAttackSpeed();
            self.SetComboSkill(timeNow);
            int targetAngle = self.GetTargetAnagle(unit, taretUnit);
            C2M_SkillCmd skillCmd = unit.GetComponent<SkillManagerComponent>().SkillCmd;
            skillCmd.SkillID = self.ComboSkillId;
            skillCmd.ItemId = 0;
            skillCmd.TargetAngle = targetAngle;
            skillCmd.TargetID = taretUnit != null ? taretUnit.Id : 0;
            skillCmd.TargetDistance = 0;
            unit.GetComponent<SkillManagerComponent>().ImmediateUseSkill(skillCmd).Coroutine();
            self.LastSkillTime = TimeHelper.ClientNow();
            self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
        }

        public static void UpdateAttackDis(this AttackComponent self, int skillid)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillid, bagComponent.GetEquipType()));
            self.AttackDistance = (float)skillConfig.SkillRangeSize;
        }

        public static void UpdateSkillInfo(this AttackComponent self, int skillid)
        {
            self.SkillId = skillid;
            self.ComboSkillId = SkillConfigCategory.Instance.Get(skillid).ComboSkillID;
            self.UpdateAttackDis(skillid);

            self.SkillList.Clear();
            while (skillid != 0 && self.SkillList.Count < 3)
            {
                self.SkillList.Add(skillid);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillid);
                skillid = skillConfig.ComboSkillID;
                if (!SkillConfigCategory.Instance.Contain(skillid))
                {
                    break;
                }
            }
            switch (self.SkillList.Count)
            {
                case 3:
                    self.Weights = new List<int>() { 70, 20, 20 };
                    break;
                case 2:
                    self.Weights = new List<int>() { 70, 20 };
                    break;
                case 1:
                    self.Weights = new List<int>() { 100 };
                    break;
            }
        }

    }
}
