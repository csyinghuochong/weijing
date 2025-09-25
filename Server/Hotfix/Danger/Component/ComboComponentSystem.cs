using System;
using System.Collections.Generic;


namespace ET
{

    [ObjectSystem]
    public class ComboComponentAwake : AwakeSystem<ComboComponent>
    {
        public override void Awake(ComboComponent self)
        {
           
        }
    }

    public static class ComboComponentSystem
    {
        public static void SetAttackSpeed(this ComboComponent self)
        {
            int EquipType = self.EquipType;
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float attackSpped = 1f + numericComponent.GetAsFloat(NumericType.Now_ActSpeedPro);
            self.SkillCDs = EquipType == (int)ItemEquipType.Knife ? new List<int>() { 500, 1000, 1000 } : new List<int>() { 700, 700, 700 };
            for (int i = 0; i < self.SkillCDs.Count; i++)
            {
                self.SkillCDs[i] = (int)(self.SkillCDs[i] / attackSpped);
            }
        }


        public static void SetComboSkill(this ComboComponent self, long timeNow)
        {
            int lastSkill = self.ComboSkillId;

            if (timeNow - self.LastSkillTime > self.CombatEndTime)
            {
                self.ComboSkillId = self.SkillId;
            }
            else
            {
                self.ComboSkillId = SkillConfigCategory.Instance.Get(self.ComboSkillId).ComboSkillID;
            }

            int EquipType = self.EquipType;
            if ((EquipType == (int)ItemEquipType.Sword
                || EquipType == (int)ItemEquipType.Common))
            {
                self.ComboSkillId = self.RandomGetSkill(lastSkill);
            }

            if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
            {
                self.ComboStartTime = 1250;
                self.CombatEndTime = 2000;
            }
            if (self.ComboSkillId == 0)
            {
                self.ComboSkillId = self.SkillList[0];
            }

            int index = self.SkillList.IndexOf(self.ComboSkillId);
            self.CDTime = self.SkillCDs[index];
        }

        //连击
        public static void UpdateComboTime(this ComboComponent self)
        {
            int equipType = self.EquipType;
            if (equipType == ItemEquipType.Sword)
            {
                //剑
                self.ComboStartTime = 500;
                self.CombatEndTime = 500;
            }
            else if (equipType == ItemEquipType.Knife)
            {
                //刀
                self.ComboStartTime = 1000;
                self.CombatEndTime = 2000;
            }
            else
            {
                //空手默认是剑
                self.ComboStartTime = 500;
                self.CombatEndTime = 500;
            }
        }

        public static int RandomGetSkill(this ComboComponent self, int lastSkill)
        {
            int index = RandomHelper.RandomByWeight(self.Weights);
            return self.SkillList[index];
        }

        public static int AutoAttack_1(this ComboComponent self)
        {
            long timeNow = TimeHelper.ServerNow();
           
            self.SetComboSkill(timeNow);
            self.LastSkillTime = timeNow;
            self.CDEndTime = self.LastSkillTime + self.CDTime;
            return self.ComboSkillId;
        }

        public static float UpdateAttackDis(this ComboComponent self)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(
                SkillHelp.GetWeaponSkill(self.SkillId, self.EquipType, null)
             );
            return (float)skillConfig.SkillRangeSize - 1;
        }

        public static void OnInitOcc(this ComboComponent self, int occ, int equipType)
        {
            if (equipType == 0)
            {
                equipType = ItemHelper.GetEquipType(occ, 0);
            }

            self.EquipType = equipType;
            //普通攻击
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(occ);
            self.UpdateSkillInfo(occConfig.InitActSkillID);
            self.UpdateComboTime();
            self.SetAttackSpeed();
        }

        public static void UpdateSkillInfo(this ComboComponent self, int skillid)
        {
            self.SkillId = skillid;
            self.ComboSkillId = SkillConfigCategory.Instance.Get(skillid).ComboSkillID;
            
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
                    self.Weights = new List<int>() { 50, 50, 40 };
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
