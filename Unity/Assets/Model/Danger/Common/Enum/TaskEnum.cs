

namespace ET
{
    //0未激活 1已接取 2已完成 3已领取
    public enum TaskStatuEnum :int
    {
        UnActive = 0,
        Accepted,       //已接取
        Completed,      //已完成
        Commited,       //已领取
    }

    public static class TaskTypeEnum
    {
        public const int None = 0;
        public const int Main = 1;              //主线任务
        public const int Branch = 2;            //支线任务
        public const int EveryDay = 3;          //赏金任务
        public const int Trial = 4;             //试炼任务
        public const int Weekly = 5;            //每周任务
        public const int Treasure = 6;          //挖宝任务
        public const int Union = 7;             //家族任务
        public const int Season = 8;            //赛季主线任务
        public const int Welfare = 9;           //福利任务
    }

    public static class TaskCountryType
    {
        public const int Country = 1;    //活跃任务
        public const int Battle = 2;     //战场任务
        public const int ShowLie = 3;    //狩猎任务
        public const int UnionRace = 4;  //家族战
        public const int Mine = 5;       //宠物矿场
        public const int Season = 6;    //赛季每日任务
    }

    //1：杀怪
    //2：道具ID
    //3：找人
    //4：等级达到指定等级
    //5：击杀任意怪物
    //6：击杀任意BOSS级别怪物
    //7：通关某个副本
    //8: 转职
    //9: 加入家族
    //10：给与任务

    //11:获得任意宠物N个(算上之前)
    //12:制造N个道具
    //13:洗炼装备次数N次
    //14:宠物在天梯战斗N次
    //15:钻石兑换金币次数
    //16:装备重铸次数达到N次 （就是装备分解）
    //17:强化装备最高一级达到N级
    //18:拥有一个N技能宠物
    //19:宠物探险通关第N关卡
    //20:消耗X金币
    //21:在野外击败敌人X次
    //22:家园等级达到X级
    //23:进行一次宠物合成
    //24:获得任意宠物N个(不算之前)
    //25: 给予任务(宠物)

    //101：击杀挑战难度的指定ID怪物(击杀地狱也算)
    //102：击杀地狱难度指定ID怪物
    //111：通关挑战难度的副本(通关地狱也算)
    //112：通关地狱难度的副本
    //121：击败挑战难度任意数量怪物(通关地狱也算)
    //122：击败地狱难度任意数量怪物
    //131：击败挑战难度任意boss怪物(通关地狱也算)
    //132：击败地狱难度任意boss怪物
    public enum TaskTargetType
    { 
        KillMonsterID_1 = 1,                    //击杀指定ID野怪
        ItemID_Number_2 = 2,                    //收集
        LookingFor_3 = 3,
        PlayerLv_4 = 4,
        KillMonster_5 = 5,                      //击杀任意野怪
        KillBOSS_6 = 6,
        PassFubenID_7 = 7,
        ChangeOcc_8 = 8,
        JoinUnion_9 = 9,
        GiveItem_10 = 10,

        PetNumber1_11,                      //11:获得任意宠物N个(算上之前)
        MakeNumber_12,                      //12:制造N个道具
        EquipXiLian_13,                     //13:洗炼装备次数N次
        PetTianTiNumber_14,                 //14:宠物在天梯战斗N次
        DuiHuanGold_15,                     //15:钻石兑换金币次数
        EquipHuiShou_16,                    //16:装备重铸次数达到N次 （就是装备分解）
        QiangHuaLevel_17,                   //17:强化装备最高一级达到N级
        PetNSkill_18,                       //18:拥有一个N技能宠物
        PetFubenId_19,                      //19:宠物探险通关第N关卡
        TotalCostGold_20,                   //20:消耗X金币
        KillPlayer_21,                      //21:在野外击败敌人X次
        JiaYuanLevel_22,                    //22:家园等级达到X级
        PetHeCheng_23,                      //23:进行一次宠物合成
        PetNumber2_24,                      //24:获得任意宠物N个(不算之前)
        GivePet_25,

        MakeQulityNumber_29,                //26:制造品质道具

        KillTiaoZhanMonsterID_101 = 101,        //击杀挑战难度以及以上怪物ID
        KillDiYuMonsterID_102 = 102,            //击杀地狱难度怪物
        PassTianZhanFubenID_111 = 111,          //通关挑战难度的副本
        PassDiYuFubenID_112 = 112,              //通关地狱难度的副本
        KillTianZhanMonsterNumber_121 = 121,    //击杀挑战难度以及以上怪物数量
        KillDiYuMonsterNumber_122 = 122,        //击杀地狱难度怪物数量
        KillTianZhanBossNumber_131 = 131,       //击杀挑战难度以及以上Boss数量
        KillDiYuBossNumber_132 = 132,           //击杀地狱难度以及以上Boss数量

        CombatToValue_133 = 133,                //战力评分达到指定值
        TrialTowerCeng_134 = 134,               //试炼之塔达到多少层
    }

    //1：登陆
    //2：打任意怪
    //3：打领主级怪
    //4：通关一次组队副本
    //5：消费指定数量金币
    //6：制造任意的道具或道具
    //7：宠物界面洗炼
    //8：获得宠物
    //9：装备重铸
    //10：在线时间
    //11：回收装备行为
    //12：进入试炼之地
    //13：进入挑战之地
    //14：赏金任务完成次数
    //15：拍卖行上架道具
    //16：幸运探宝（抽奖）次数
    //17：使用鉴定符鉴定一件装备
    //18: 家园烹饪

    //101： 战场胜利
    //102： 战场击杀玩家数量
    //103:  战场存在时间
    //104:  战场死亡

    //201 : 狩猎数量

    //301:  家族战击杀玩家

    //401:  占领矿场数量
    //402:  矿场挑战次数
    public enum TaskCountryTargetType
    { 
        Login_1 =1,
        KillMonster_2 = 2,
        KillBoss_3 = 3,
        PassTeamFuben_4 = 4,
        CostCoin_5 = 5,
        MakeItem_6 = 6,
        PetXiLian_7 = 7,
        GetPet_8 = 8,
        EquipXiLian_9 = 9,
        OnLineTime_10 = 10,
        ItemHuiShou_11 =11,
        TrialFuben_12 = 12,
        Tower_13 = 13,
        TaskLoop_14 = 14,
        PaiMaiSell_15 = 15,
        ChouKa_16 = 16,
        JianDing_17 = 17,
        JiaYuanCook_18 = 18,
        EveryDayTask_19 = 19,

        BattleWin_101 = 101,
        BattleKillPlayer_102 = 102,
        BattleExist_103 = 103,
        BattleDead_104 = 104,

        ShowLieMonster_201 = 201,

        UnionRaceKill_301 = 301,

        MineHaveNumber_401 = 401,
        MineBattleNumber_402 = 402,
    }
}
