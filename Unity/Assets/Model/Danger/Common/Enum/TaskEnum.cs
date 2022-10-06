

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

    public enum TaskTypeEnum
    {
        None = 0,
        Main =  1,      //主线任务
        Branch,         //支线任务
        EveryDay,       //每日任务
        Trial,          //试炼任务
        CountryDay = 5, //每日活跃
    }

    //1：杀怪
    //2：道具ID
    //3：找人
    //4：等级达到指定等级
    //5：击杀任意怪物
    //6：击杀任意BOSS级别怪物
    //7：通关某个副本
    //8: 装职
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
        KillMonsterID_1 = 1,     //击杀指定ID野怪
        ItemID_Number_2 = 2,                 //收集
        LookingFor_3 = 3,
        PlayerLv_4 = 4,
        KillMonster_5 = 5,           //击杀任意野怪
        KillBOSS_6 = 6,
        PassFubenID_7 = 7,
        ChangeOcc_8 = 8,

        KillTiaoZhanMonsterID_101 = 101, //击杀挑战难度以及以上怪物ID
        KillDiYuMonsterID_102 = 102,  //击杀地狱难度怪物
        PassTianZhanFubenID_111 = 111,   //通关挑战难度的副本
        PassDiYuFubenID_112 = 112,    //通关地狱难度的副本
        KillTianZhanMonsterNumber_121 = 121, //击杀挑战难度以及以上怪物数量
        KillDiYuMonsterNumber_122 = 122,  //击杀地狱难度怪物数量
        KillTianZhanBossNumber_131 = 131,     //击杀挑战难度以及以上Boss数量
        KillDiYuBossNumber_132 = 132,     //击杀地狱难度以及以上Boss数量
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
    }
}
