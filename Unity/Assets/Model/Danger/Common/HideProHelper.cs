namespace ET
{

    public static class HideProHelper
    {

        public static int RoleIntProId = 1001;
        public static int RoleIntSkillId = 2001;

        public static int PetIntProId = 30001;
        public static int PetIntSkillId = 40001;

        //玩家装备洗练属性起始id:1001  洗练技能起始id:200
        //玩家装备洗练属性起始id:30001  洗练技能起始id:40001
        public static int GetInitProId(ItemConfig itemConfig)
        {
            if (itemConfig.EquipType == 301)
            {
                return PetIntProId;
            }
            return RoleIntProId;
        }

        public static int GetInitSkillId(ItemConfig itemConfig)
        {
            if (itemConfig.EquipType == 301)
            {
                return PetIntSkillId;
            }
            return RoleIntSkillId;
        }
    }

}