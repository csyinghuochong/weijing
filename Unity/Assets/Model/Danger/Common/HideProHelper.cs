namespace ET
{

    public static class HideProHelper
    {

        public static int RoleIntProId = 1001;
        public static int RoleIntSkillId = 2001;

        //危境宠物装备默认隐藏属性从10001开始， 宠物装备不能洗练,但是每次获得宠物装备会刷新激活一次洗练属性
        public static int PetIntProId = 10001; ///30001;
        public static int PetIntSkillId = 0;// 40001;

        //玩家装备洗练属性起始id:1001  洗练技能起始id:200

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