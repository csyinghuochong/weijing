

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
        public const int Daily = 3;          //赏金任务
        public const int Trial = 4;             //试炼任务(没做)
        public const int Weekly = 5;            //每周任务
        public const int Treasure = 6;          //挖宝任务
        public const int Union = 7;             //家族任务
        public const int Season = 8;            //赛季主线任务
        public const int Welfare = 9;           //福利任务
        public const int Ring = 10;             //跑环任务
        public const int System = 11;           //系统任务
    }

    public static class TaskCountryType
    {
        public const int Country = 1;    //活跃任务
        public const int Battle = 2;     //战场任务
        public const int ShowLie = 3;    //狩猎任务
        public const int UnionRace = 4;  //家族战
        public const int Mine = 5;       //宠物矿场
        public const int Season = 6;    //赛季每日任务
        public const int ActivityV1 = 7; //活动每日任务
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
    //26.使用普通藏宝图x次
    //27.使用高级藏宝图X次
    //28.封印之塔挑战X次
    //29:制造超过某个N品质的道具，制造X个道具（俩参数:品质，数量）
    //30.使用药剂或者合剂X次

    //31.获得X只新的宠物(接取任务才开始算获取)
    //32.合成1只战力达到X点的宠物
    //33.宠物使用宠之晶洗炼宠物达到X次
    //34.在孵化系统中孵化成功宠物X次
    //35.在孵化系统中孵化指定的宠物蛋成功X次（俩参数:宠物蛋ID，次数）
    //36.宠物使用技能书X次
    //37 宠物天梯战斗胜利次数

    //41.使用N点品质的鉴定附魔道具给装备附魔X次（俩参数:附魔道具品质，次数）
    //42.使用N点品质的鉴定道具给装备鉴定X次（俩参数:鉴定道具品质，次数）
    //43.鉴定装备时出一个大于N条属性的装备X个（俩参数:鉴定属性条目数量，数量）
    //44.洗炼出带有任何隐藏技能的装备X个
    //45.洗炼出带有指定属性的装备X个（俩参数:指定属性ID，数量）
    //46.增幅装备N次

    //81:试炼之地的输出排行榜进入前N名次，X次（俩参数:前N名，次数）
    //82:宠物天梯进入排行榜前N名次，X次（俩参数:前N名，次数）
    //83:战力排行榜进入前N名次，X次（俩参数:前N名，次数）
    //91: 家园烹饪次数
    //92: 家园种地种植次数
    //93: 家园种地收获次数
    //94: 家园牧场饲养次数
    //95: 家园牧场收货次数
    //96: 家园美味品尝次数

    //101：击杀挑战难度的指定ID怪物(击杀地狱也算)
    //102：击杀地狱你拿度指定ID怪物
    //111：通关挑战难度的副本(通关地狱也算)
    //112：通关地狱难度的副本
    //121：击败挑战难度任意数量怪物(通关地狱也算)
    //122：击败地狱难度任意数量怪物
    //131：击败挑战难度任意boss怪物(通关地狱也算)
    //132：击败地狱难度任意boss怪物
    //133: 战力达到多少
    //134: 试炼之地达到多少层
    //135: 挑战深渊模式的副本X次
    //136: 在N级组队副本中,自身输出超过X% (俩参数:副本等级,伤害百分比,比如40%就配置40)
    //137: 开启地图的宝箱X次
    //138: 与好友组队挑战1次副本
    //139: 获得1个多少级+橙色装备
    //140: 需要1件鉴定属性总计达到X点的装备
    //141: 击败x次y级以上地狱级的的领主

    //401 矿场占领次数
    //402 
    //403 

    //1001：登陆
    //1002：打任意怪
    //1003：打领主级怪
    //1004：通关一次组队副本
    //1005：消费指定数量金币
    //1006：制造任意的道具或道具
    //1007：宠物界面洗炼
    //1008：获得宠物
    //1009：装备重铸
    //1010：在线时间
    //1011：回收装备行为
    //1012：进入试炼之地
    //1013：进入挑战之地
    //1014：赏金任务完成次数
    //1015：拍卖行上架道具
    //1016：幸运探宝（抽奖）次数
    //1017：使用鉴定符鉴定一件装备
    //1018: 家园烹饪

    //1101： 战场胜利
    //1102： 战场击杀玩家数量
    //1103:  战场存在时间
    //1104:  战场死亡

    //1201 : 狩猎数量

    //1301:  家族战击杀玩家

    public static class TaskTargetType
    {
        public const int KillMonsterID_1 = 1;                    //击杀指定ID野怪
        public const int ItemID_Number_2 = 2;                    //收集
        public const int LookingFor_3 = 3;
        public const int PlayerLv_4 = 4;
        public const int KillMonster_5 = 5;                      //击杀任意野怪
        public const int KillBOSS_6 = 6;
        public const int PassFubenID_7 = 7;
        public const int ChangeOcc_8 = 8;
        public const int JoinUnion_9 = 9;
        public const int GiveItem_10 = 10;
        public const int PetNumber1_11 = 11;                      //11:获得任意宠物N个(算上之前)
        public const int MakeNumber_12 = 12;                     //12:制造N个道具
        public const int EquipXiLian_13 = 13;                    //13:洗炼装备次数N次
        public const int PetTianTiNumber_14 = 14;                 //14:宠物在天梯战斗N次
        public const int DuiHuanGold_15 = 15;                     //15:钻石兑换金币次数
        public const int EquipHuiShou_16 = 16;                   //16:装备重铸次数达到N次 （就是装备分解）
        public const int QiangHuaLevel_17 = 17;                   //17:强化装备最高一级达到N级
        public const int PetNSkill_18 = 18;                       //18:拥有一个N技能宠物
        public const int PetFubenId_19 = 19;                      //19:宠物探险通关第N关卡
        public const int TotalCostGold_20 = 20;                   //20:消耗X金币
        public const int KillPlayer_21 = 21;                      //21:在野外击败敌人X次
        public const int JiaYuanLevel_22 = 22;                    //22:家园等级达到X级
        public const int PetHeCheng_23 = 23;                      //23:进行一次宠物合成
        public const int PetNumber2_24 = 24;                      //24:获得任意宠物N个(不算之前)
        public const int GivePet_25 = 25;                         ////25: 给予任务(宠物)
        public const int TreasureMapNormal_26 = 26;               //26.使用普通藏宝图x次
        public const int TreasureMapHigh_27 = 27;                 //27.使用高级藏宝图
        public const int TowerOfSeal_28 = 28;                     //28.封印之塔挑战X
        public const int MakeQulityNumber_29 = 29;                //29:制造品质道具
        public const int BattleUseItem_30 = 30;                   //30.使用药剂或者合剂X次

        public const int PetNumber_31 = 31;                       //31.获得X只新的宠物(接取任务才开始算获取)  (24 / 31的区别)
        public const int PetHeChengCombat_32 = 32;                //32.合成1只战力达到X点的宠物
        public const int PetXiLian10010086_33 = 33;               //33.宠物使用宠之晶洗炼宠物达到X次
        public const int PetFuHuaNumber_34 = 34;                  //34.在孵化系统中孵化成功宠物X次
        public const int PetFuHuaId_35 = 35;                      //35.在孵化系统中孵化指定的宠物蛋成功X次（俩参数:宠物蛋ID，次数）
        public const int PetUseSkillBook_36 = 36;                 //36.宠物使用技能书X次
        public const int PetTianDiWin_37 = 37;     //37 宠物天梯战斗胜利次数

        public const int FuMoQulity_41 = 41;                     //41.使用N点品质的鉴定附魔道具给装备附魔X次（俩参数:附魔道具品质，次数）
        public const int JianDingQulity_42 = 42;                  //42.使用N点品质的鉴定道具给装备鉴定X次（俩参数:鉴定道具品质，次数）
        public const int JianDingAttrNumber_43 = 43;               //43.鉴定装备时出一个大于N条属性的装备X个（俩参数:鉴定属性条目数量，数量）
        public const int XiLianSkillNumber_44 = 44;            //44.洗炼出带有任何隐藏技能的装备X个
        public const int XiLianAttriId_45 = 45;                //45.洗炼出带有指定属性的装备X个（俩参数:指定属性ID，数量）
        public const int IncreaseNumber_46 = 46;                 //46.增幅装备N次

        public const int TrialRank_81 = 81;                    //81:试炼之地的输出排行榜进入前N名次，X次（俩参数:前N名，次数）
        public const int PetTianTiRank_82 = 82;                      //82:宠物天梯进入排行榜前N名次，X次（俩参数:前N名，次数）
        public const int CombatRank_83 = 83;                   //83:战力排行榜进入前N名次，X次（俩参数:前N名，次数）

        public const int JiaYuanCookNumber_91 = 91;       //91: 家园烹饪次数
        public const int JiaYuanPlantNumber_92 = 92;      //92: 家园种地种植次数
        public const int JiaYuanGatherPlant_93 = 93;//93: 家园种地收获次数
        public const int JiaYuanPastureNumber_94 = 94; //94: 家园牧场饲养次数
        public const int JiaYuanGatherPasture_95 = 95;//95: 家园牧场收货次数
        public const int JiaYuanDashiNumber_96 = 96; //96: 家园美味品尝次数

        public const int KillTiaoZhanMonsterID_101 = 101;        //击杀挑战难度以及以上怪物ID
        public const int KillDiYuMonsterID_102 = 102;            //击杀地狱难度怪物
        public const int PassTianZhanFubenID_111 = 111;          //通关挑战难度的副本
        public const int PassDiYuFubenID_112 = 112;              //通关地狱难度的副本
        public const int KillTianZhanMonsterNumber_121 = 121;    //击杀挑战难度以及以上怪物数量
        public const int KillDiYuMonsterNumber_122 = 122;        //击杀地狱难度怪物数量
        public const int KillTianZhanBossNumber_131 = 131;      //击杀挑战难度以及以上Boss数量
        public const int KillDiYuBossNumber_132 = 132;           //击杀地狱难度以及以上Boss数量
        public const int CombatToValue_133 = 133;                //战力评分达到指定值
        public const int TrialTowerCeng_134 = 134;               //试炼之塔达到多少层
        public const int ShenYuanNumber_135 = 135;              //135: 挑战深渊模式的副本X次
        public const int TeamDungeonHurt_136 = 136;              //组队副本伤害比较 
        public const int OpenBox_137 = 137;                 //开启地图的宝箱1次
        public const int FriendPassFuben_138 = 138;         //与好友组队挑战1次副本
        public const int GetOrangeEquip_139 = 139;              //获得1个多少级+橙色装备
        public const int JianDingValue_140 = 140;           //需要1件鉴定属性总计达到15点的装备
        public const int KillDiYuBoss_141 = 141;            //击败5次20级以上地狱级的的领主

        public const int MineHaveNumber_401 = 401;
        public const int MineBattleNumber_402 = 402;
        public const int MineWinNumber_403 = 403;

        public const int Login_1001 = 1001;
        public const int KillMonster_1002 = 1002;
        public const int KillBoss_1003 = 1003;
        public const int PassTeamFuben_1004 = 1004;
        public const int CostCoin_1005 = 1005;
        public const int MakeItem_1006 = 1006;
        public const int PetXiLian_1007 = 1007;
        public const int GetPet_1008 = 1008;
        public const int EquipXiLian_1009 = 1009;
        public const int OnLineTime_1010 = 1010;
        public const int ItemHuiShou_1011 = 1011;
        public const int TrialFuben_1012 = 1012;
        public const int Tower_1013 = 1013;
        public const int DailyTask_1014 = 1014;
        public const int PaiMaiSell_1015 = 1015;
        public const int ChouKa_1016 = 1016;
        public const int JianDing_1017 = 1017;
        public const int JiaYuanCook_1018 = 1018;
        public const int EveryDayTask_1019 = 1019;

        public const int BattleWin_1101 = 1101;
        public const int BattleKillPlayer_1102 = 1102;
        public const int BattleExist_1103 = 1103;
        public const int BattleDead_1104 = 1104;

        public const int ShowLieMonster_1201 = 1201;

        public const int UnionRaceKill_1301 = 1301;

    }
}
