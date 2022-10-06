
namespace ET
{ 
    public static class SkillHelp
    {

        public static int GetWeaponSkillID(int skillId, ItemEquipType weapType)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            if (skillConfig.WeaponType == 0)
                return skillId;
            if (!SkillWeaponConfigCategory.Instance.Contain(skillId))
            {
                Log.Debug("错误的技能配置[WeaponType]_:" + skillId.ToString());
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
