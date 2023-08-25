
using System.Collections.Generic;

namespace ET
{ 
    public static class SkillHelp
    {

        public static List<int> BaoShiBuff = new List<int>() { 99001042, 99001031, 99001032, 99001011 };
        public static List<int> DonationBuff = new List<int>() { 99003011 , 99003012, 99003013, 99003021, 99003022, 99003023,
                                                                99003031, 99003032, 99003033,99003041,  99003042, 99003043,
                                                                99003051, 99003052,99003053,99003061,99003062,99003063, 99003064};


        public static string ChongJiSkill = "Skill_Other_ChongJi_1";

        public static List<string> NotCombatSkill = new List<string>() { "Act_11", "Act_12", "Act_13" };

        public static Dictionary<string, long> AckExitTime = new Dictionary<string, long>()
                {
                    {"Act_1", 700 },
                    {"Act_2", 1100 },
                    {"Act_3", 1100 },
                    {"Act_11", 900 },
                    {"Act_12", 900 },
                    {"Act_13", 900 },
        };

        public static bool IsChongJi(string skillname)
        {
            return skillname.Equals(ChongJiSkill);
        }

        /// <summary>
        /// 强化技能
        /// </summary>
        /// <param name="occ"></param>
        /// <param name="skillId"></param>
        /// <returns></returns>
        public static bool IsQiangHuaSkill(int occ, int skillId)
        {
            int baseskill = SkillConfigCategory.Instance.GetBaseSkill(skillId);
            if (baseskill == 0)
            {
                return false;
            }

            int[] baseList = OccupationConfigCategory.Instance.Get(occ).BaseSkill;
            for (int i = 0; i < baseList.Length; i++)
            {
                if (baseList[i] == baseskill)
                {
                    return true;
                }
            }
           
            return false;
        }

        public static int GetBaseSkill(int weapSkillId)
        {
            Dictionary<int, SkillWeaponConfig> skillWeapons = SkillWeaponConfigCategory.Instance.GetAll();

            foreach (var item in skillWeapons)
            {
                if(item.Key == weapSkillId || item.Value.InitSkillID == weapSkillId || item.Value.InitSkillID_1 == weapSkillId
                    || item.Value.InitSkillID_2 == weapSkillId || item.Value.InitSkillID_3 == weapSkillId || item.Value.InitSkillID_4 == weapSkillId)
                {

                    return item.Key;
                }
            }

            return weapSkillId;
        }

        public static int GetWeaponSkill(int skillId, int weapType, List<SkillPro> skillPros)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            if (skillConfig.WeaponType == 0)
                return skillId;
            if (!SkillWeaponConfigCategory.Instance.Contain(skillId))
            {
                Log.Error("错误的技能配置[WeaponType]_:" + skillId.ToString());
                return skillId;
            }

            SkillWeaponConfig skillWeaponConfig = SkillWeaponConfigCategory.Instance.Get(skillId);
            if (skillWeaponConfig == null)
                return skillId;
            switch (weapType)
            {
                case ItemEquipType.Sword:
                    skillId = skillWeaponConfig.InitSkillID_1;
                    break;
                case ItemEquipType.Knife:
                    skillId = skillWeaponConfig.InitSkillID_2;
                    break;
                case ItemEquipType.Wand:
                    skillId = skillWeaponConfig.InitSkillID_3;
                    break;
                case ItemEquipType.Book:
                    skillId = skillWeaponConfig.InitSkillID_4;
                    break;
                default:
                    skillId = skillWeaponConfig.InitSkillID;
                    break;
            }
            int weaponid = skillId != 0 ? skillId : skillWeaponConfig.InitSkillID;
            if (SkillConfigCategory.Instance.Get(weaponid).SkillLv == 0)
            {
                return weaponid;
            }

            int newskill =  SkillConfigCategory.Instance.GetNewSkill(skillPros, weaponid);
            newskill = newskill != 0 ? newskill : weaponid;
            return newskill;
        }
    }
}
