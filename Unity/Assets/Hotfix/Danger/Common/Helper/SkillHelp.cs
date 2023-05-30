
using System.Collections.Generic;

namespace ET
{ 
    public static class SkillHelp
    {

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

        public static int GetWeaponSkill(int skillId, int weapType)
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
            return skillId != 0 ? skillId : skillWeaponConfig.InitSkillID;
        }
    }
}
