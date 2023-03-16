namespace ET
{
    public class Receipt
    {
        public string Payload;
    }

    /// <summary>
    /// 数据类型枚举
    /// </summary>
    public static class DataType
    {
        public const int None = 0;

        //更新玩家身上货币属性
        public const int UpdateRoleData = 1;

        //更新玩家战斗属性
        public const int UpdateRoleFightData = 2;

        /// <summary>
        /// 获得物品
        /// </summary>
        public const int BagItemAdd = 3;

        public const int PaiMaiBuy = 4;

        /// <summary>
        /// 背包物品
        /// </summary>
        public const int BagItemUpdate = 5;

        public const int SettingUpdate = 6;

        public const int ChengJiuUpdate = 7;

        public const int OnMailUpdate = 8;

        public const int OnRecvChat = 9;

        public const int HorseNotice = 10;

        /// <summary>
        /// 选择回收
        /// </summary>
        public const int HuiShouSelect = 11;

        //穿戴装备
        public const int EquipWear = 12;


        public const int EquipHuiShow = 14;

        //任务更新通知
        public const int TaskUpdate = 16;
        //任务追踪
        public const int TaskTrace = 17;
        //接取任务
        public const int TaskGet = 18;
        //完成任务
        public const int TaskComplete = 19;
        /// <summary>
        /// 放弃任务
        /// </summary>
        public const int TaskGiveUp = 20;

        public const int PetItemSelect = 21;

        public const int PetHeChengUpdate = 22;

        public const int PetXiLianUpdate = 23;
        public const int PetFenJieUpdate = 24;

        public const int PetUpStarUpdate = 25;

        public const int OnPetFightSet = 26;

        public const int SkillSetting = 27;

        public const int SkillReset = 28;

        public const int SkillUpgrade = 29;

        public const int OnActiveTianFu = 30;

        /// <summary>
        /// 组队更新
        /// </summary>
        public const int TeamUpdate = 33;

        /// <summary>
        /// 好友更新
        /// </summary>
        public const int FriendUpdate = 34;

        /// <summary>
        /// 好友聊天
        /// </summary>
        public const int FriendChat = 35;

        public const int SkillCDUpdate = 36;

        public const int MainHeroMove = 37;

        //接取任务
        public const int TaskLoopGet = 38;

        public const int SkillBeging = 39;

        public const int SkillFinish = 40;

        public const int OnDropItem = 41;
    }
}