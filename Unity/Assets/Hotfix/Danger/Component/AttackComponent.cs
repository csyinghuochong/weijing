using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public  class AttackComponent : Entity, IAwake
    {
        public int SkillId;
        public int ComboSkillId;
        public long LastSkillTime;
        public long ComboStartTime;
        public long CombatEndTime;

        public float AttackDistance;
        public List<int> Weights = new List<int>();
        public List<int> SkillList = new List<int> { };
        public SkillConfig SkillConfig;
        public readonly C2M_SkillCmd c2mSkillCmd = new C2M_SkillCmd();
        public long CDTime = 800;
        public long CDEndTime;
    }

    [ObjectSystem]
    public class AttackComponentAwakeSystem : AwakeSystem<AttackComponent>
    {
        public override void Awake(AttackComponent self)
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
            float cdTime = EquipType == (int)ItemEquipType.Knife ? 1000 : 800;
            self.CDTime = (int)(cdTime / attackSpped);
        }

        public static void SetComboSkill(this AttackComponent self)
        {
            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            if ((EquipType == (int)ItemEquipType.Sword
                || EquipType == (int)ItemEquipType.Common))
            {
                self.ComboSkillId = self.RandomGetSkill();
            }
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

        public static int GetTargetAnagle(this AttackComponent self, Unit unit,  Unit taretUnit)
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
            if (timeNow - self.LastSkillTime > self.CombatEndTime)
            {
                self.ComboSkillId = self.SkillId;
            }
            else
            {
                self.ComboSkillId = SkillConfigCategory.Instance.Get(self.ComboSkillId).ComboSkillID;
            }
            self.SetAttackSpeed();
            self.SetComboSkill();
            int targetAngle = self.GetTargetAnagle(unit, taretUnit);
            unit.GetComponent<SkillManagerComponent>().SendUseSkill(self.ComboSkillId, 0, targetAngle, taretUnit!=null?taretUnit.Id:0, 0).Coroutine();
            self.LastSkillTime = TimeHelper.ClientNow();
            self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
            if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
            {
                self.ComboStartTime = 1250;
                self.CombatEndTime = 2000;
            }
        }

        public static void UpdateAttackDis(this AttackComponent self, int skillid)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkillID(skillid, bagComponent.GetEquipType()));
            self.AttackDistance = (float)skillConfig.SkillRangeSize;
        }

        public static void UpdateSkillInfo(this AttackComponent self, int skillid)
        {
            self.SkillId = skillid;
            self.SkillConfig = SkillConfigCategory.Instance.Get(skillid);
            self.ComboSkillId = self.SkillConfig.ComboSkillID;
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
