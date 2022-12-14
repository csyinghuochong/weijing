namespace ET
{
    public static class NumericType
    {
        //最小值，小于此值的都被认为是原始属性
        public const int Min = 0;

        //当前属性[玩家刷新属性的时候不会清掉这些值]
        public const int Now_Hp = 3001;                                         //生命值
        public const int Now_Dead = 3002;                                       //0活 1死
        public const int ReviveTime = 3003;
        public const int Now_Shield_HP = 3004;                                  //护盾当前值
        public const int Now_Shield_MaxHP = 3005;                               //护盾最大格挡值
        public const int Now_Shield_DamgeCostPro = 3006;                        //护盾减免系数
        public const int Now_Stall = 3010;                                       //摆摊状态
        public const int Now_Weapon = 3011;
        public const int Now_Damage = 3012;
        public const int Now_XiLian = 3013;                                         //今日洗练次数
        public const int MainCity_X = 3014;
        public const int MainCity_Y = 3015;
        public const int MainCity_Z = 3016;
        public const int PetChouKa = 3017;
        public const int YueKaAward = 3018;                                       //领取时间戳
        public const int Born_X = 3019;
        public const int Born_Y = 3020;
        public const int Born_Z = 3021;
        public const int TowerId = 3022;
        public const int MasterId = 3023;                                          //主人ID
        public const int UnionLeader = 3025;                                        //家族族长
        public const int LastGameTime = 3026;
        public const int Ling_DiLv = 3027;
        public const int Ling_DiExp = 3028;
        public const int ZeroClock = 3029;
        public const int XiuLian_ExpNumber = 3030;                                   //经验修炼次数
        public const int XiuLian_CoinNumber = 3031;                                  //金币修炼次数
        public const int XiuLian_ExpTime = 3032;
        public const int XiuLian_CoinTime = 3033;
        public const int TaskDungeonId = 3034;                                     //机器人用，记录当前的副本进度
        public const int PetSkin = 3035;                                           //宠物皮肤
        public const int TiLiKillNumber = 3036;                                   //击杀单人副本5个普通怪会消耗1点体力,体力为0击杀普通怪物无任何经验和掉落奖励
        public const int HongBao = 3037;
        public const int RandomTowerId = 3038;                                    //随机塔
        public const int ChouKa = 3039;
        public const int ChouKaOneTime = 3040;                                      //抽卡在线时间
        public const int ChouKaTenTime = 3041;                                      //抽卡在线时间
        public const int PointLiLiang = 3042;
        public const int PointZhiLi  = 3043;
        public const int PointTiZhi = 3044;
        public const int PointNaiLi = 3045;
        public const int PointMinJie = 3046;
        public const int PointRemain = 3047;
        public const int CampId = 3048;
        public const int CangKuNumber = 3049;
        public const int MaoXianExp = 3050;
        public const int YueKaEndTime = 3051;
        public const int MakeType = 3052;
        public const int ExpToGoldTimes = 3053;
        public const int MakeShuLianDu = 3054;
        public const int RechargeNumber = 3055;
        public const int ItemXiLianDu = 3056;                                    //洗练家等级
        public const int BossInCombat = 3057;                                    //进入战斗
        public const int UseMasterModel = 3058;                                  //使用主人形象
        /// <summary>
        /// 签到充值奖励，每日重置 0不能领取1 可以领取2已领取
        /// </summary>
        public const int RechargeSign = 3059;                                   
        public const int RechargeBuChang = 3060;                                 //充值补偿
        public const int Now_Lv = 3061;                                         //当前等级
        public const int BattleCamp = 3062;                                     //战斗阵营
        public const int TaskLoopNumber = 3063;                                 //赏金任务完成数量                          
        public const int TaskLoopGiveId = 3064;
        public const int YueKaRemainTimes = 3066;                               //月卡剩余次数                    
        public const int TeamDungeonTimes = 3067;
        public const int Now_AI = 3068;
        public const int TrialDungeonId = 3069;
        public const int Now_Horse = 3070;
        public const int BattleTodayCamp = 3071;                                   //今日战场
        public const int TeamId = 3072;
        public const int BattleTodayKill = 3073;                                   //战场击杀人数
        public const int PetExtendNumber = 3074;                                    //宠物扩展数量

        public const int Max = 10000;
        public const int Now_MaxHp = 1002;                                       //生命总值
        public const int Base_MaxHp_Base = Now_MaxHp * 100 + 1;                  //属性累加
        public const int Base_MaxHp_Mul = Now_MaxHp * 100 + 2;                   //属性乘法
        public const int Base_MaxHp_Add = Now_MaxHp * 100 + 3;                   //属性附加
        public const int Extra_Buff_MaxHp_Add = Now_MaxHp * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MaxHp_Mul = Now_MaxHp * 100 + 12;            //属性Buff附加乘法

        public const int Now_MinAct = 1003;         //最低攻击
        public const int Base_MinAct_Base = Now_MinAct * 100 + 1;                 //属性累加
        public const int Base_MinAct_Mul = Now_MinAct * 100 + 2;                  //属性乘法
        public const int Base_MinAct_Add = Now_MinAct * 100 + 3;                  //属性附加
        public const int Extra_Buff_MinAct_Add = Now_MinAct * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MinAct_Mul = Now_MinAct * 100 + 12;           //属性Buff附加乘法

        public const int Now_MaxAct = 1004;         //最高攻击
        public const int Base_MaxAct_Base = Now_MaxAct * 100 + 1;                 //属性累加
        public const int Base_MaxAct_Mul = Now_MaxAct * 100 + 2;                  //属性乘法
        public const int Base_MaxAct_Add = Now_MaxAct * 100 + 3;                  //属性附加
        public const int Extra_Buff_MaxAct_Add = Now_MaxAct * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MaxAct_Mul = Now_MaxAct * 100 + 12;           //属性Buff附加乘法

        public const int Now_MinDef = 1005;         //最低防御
        public const int Base_MinDef_Base = Now_MinDef * 100 + 1;                 //属性累加
        public const int Base_MinDef_Mul = Now_MinDef * 100 + 2;                  //属性乘法
        public const int Base_MinDef_Add = Now_MinDef * 100 + 3;                  //属性附加
        public const int Extra_Buff_MinDef_Add = Now_MinDef * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MinDef_Mul = Now_MinDef * 100 + 12;           //属性Buff附加乘法

        public const int Now_MaxDef = 1006;         //最高防御
        public const int Base_MaxDef_Base = Now_MaxDef * 100 + 1;                 //属性累加
        public const int Base_MaxDef_Mul = Now_MaxDef * 100 + 2;                  //属性乘法
        public const int Base_MaxDef_Add = Now_MaxDef * 100 + 3;                  //属性附加
        public const int Extra_Buff_MaxDef_Add = Now_MaxDef * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MaxDef_Mul = Now_MaxDef * 100 + 12;           //属性Buff附加乘法

        public const int Now_MinAdf = 1007;         //最低魔防
        public const int Base_MinAdf_Base = Now_MinAdf * 100 + 1;                 //属性累加
        public const int Base_MinAdf_Mul = Now_MinAdf * 100 + 2;                  //属性乘法
        public const int Base_MinAdf_Add = Now_MinAdf * 100 + 3;                  //属性附加
        public const int Extra_Buff_MinAdf_Add = Now_MinAdf * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MinAdf_Mul = Now_MinAdf * 100 + 12;           //属性Buff附加乘法

        public const int Now_MaxAdf = 1008;         //最高魔御
        public const int Base_MaxAdf_Base = Now_MaxAdf * 100 + 1;                 //属性累加
        public const int Base_MaxAdf_Mul = Now_MaxAdf * 100 + 2;                  //属性乘法
        public const int Base_MaxAdf_Add = Now_MaxAdf * 100 + 3;                  //属性附加
        public const int Extra_Buff_MaxAdf_Add = Now_MaxAdf * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MaxAdf_Mul = Now_MaxAdf * 100 + 12;           //属性Buff附加乘法

        public const int Now_Speed = 1009;          //当前移动速度
        public const int Base_Speed_Base = Now_Speed * 100 + 1;                 //属性累加
        public const int Base_Speed_Mul = Now_Speed * 100 + 2;                  //属性乘法
        public const int Base_Speed_Add = Now_Speed * 100 + 3;                  //属性附加
        public const int Extra_Buff_Speed_Add = Now_Speed * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Speed_Mul = Now_Speed * 100 + 12;           //属性Buff附加乘法

        public const int Now_Mage = 1010;          //当前法术攻击
        public const int Base_Mage_Base = Now_Mage * 100 + 1;                 //属性累加
        public const int Base_Mage_Mul = Now_Mage * 100 + 2;                  //属性乘法
        public const int Base_Mage_Add = Now_Mage * 100 + 3;                  //属性附加
        public const int Extra_Buff_Mage_Add = Now_Mage * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Mage_Mul = Now_Mage * 100 + 12;           //属性Buff附加乘法

        public const int Now_Power = 1051;          //力量
        public const int Base_Power_Base = Now_Power * 100 + 1;                 //属性累加
        public const int Base_Power_Mul = Now_Power * 100 + 2;                  //属性乘法
        public const int Base_Power_Add = Now_Power * 100 + 3;                  //属性附加
        public const int Extra_Buff_Power_Add = Now_Power * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Power_Mul = Now_Power * 100 + 12;           //属性Buff附加乘法

        public const int Now_Agility = 1052;         //敏捷
        public const int Base_Agility_Base = Now_Agility * 100 + 1;                 //属性累加
        public const int Base_Agility_Mul = Now_Agility * 100 + 2;                  //属性乘法
        public const int Base_Agility_Add = Now_Agility * 100 + 3;                  //属性附加
        public const int Extra_Buff_Agility_Add = Now_Agility * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Agility_Mul = Now_Agility * 100 + 12;           //属性Buff附加乘法

        public const int Now_Intellect = 1053;       //智力
        public const int Base_Intellect_Base = Now_Intellect * 100 + 1;                 //属性累加
        public const int Base_Intellect_Mul = Now_Intellect * 100 + 2;                  //属性乘法
        public const int Base_Intellect_Add = Now_Intellect * 100 + 3;                  //属性附加
        public const int Extra_Buff_Intellect_Add = Now_Intellect * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Intellect_Mul = Now_Intellect * 100 + 12;           //属性Buff附加乘法

        public const int Now_Stamina = 1054;         //耐力
        public const int Base_Stamina_Base = Now_Stamina * 100 + 1;                 //属性累加
        public const int Base_Stamina_Mul = Now_Stamina * 100 + 2;                  //属性乘法
        public const int Base_Stamina_Add = Now_Stamina * 100 + 3;                  //属性附加
        public const int Extra_Buff_Stamina_Add = Now_Stamina * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Stamina_Mul = Now_Stamina * 100 + 12;           //属性Buff附加乘法

        public const int Now_Constitution = 1055;    //体质
        public const int Base_Constitution_Base = Now_Constitution * 100 + 1;                 //属性累加
        public const int Base_Constitution_Mul = Now_Constitution * 100 + 2;                  //属性乘法
        public const int Base_Constitution_Add = Now_Constitution * 100 + 3;                  //属性附加
        public const int Extra_Buff_Constitution_Add = Now_Constitution * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Constitution_Mul = Now_Constitution * 100 + 12;           //属性Buff附加乘法

        public const int Now_GeDang = 1101;          //当前格挡值
        public const int Base_GeDang_Base = Now_GeDang * 100 + 1;                 //属性累加
        public const int Base_GeDang_Mul = Now_GeDang * 100 + 2;                  //属性乘法
        public const int Base_GeDang_Add = Now_GeDang * 100 + 3;                  //属性附加
        public const int Extra_Buff_GeDang_Add = Now_GeDang * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_GeDang_Mul = Now_GeDang * 100 + 12;           //属性Buff附加乘法 

        public const int Now_ZhongJi = 1102;          //当前重击固定值
        public const int Base_ZhongJi_Base = Now_ZhongJi * 100 + 1;                 //属性累加
        public const int Base_ZhongJi_Mul = Now_ZhongJi * 100 + 2;                  //属性乘法
        public const int Base_ZhongJi_Add = Now_ZhongJi * 100 + 3;                  //属性附加
        public const int Extra_Buff_ZhongJi_Add = Now_ZhongJi * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_ZhongJi_Mul = Now_ZhongJi * 100 + 12;           //属性Buff附加乘法

        public const int Now_ZhenShi = 1103;          //当前真实伤害
        public const int Base_ZhenShi_Base = Now_ZhenShi * 100 + 1;                 //属性累加
        public const int Base_ZhenShi_Mul = Now_ZhenShi * 100 + 2;                  //属性乘法
        public const int Base_ZhenShi_Add = Now_ZhenShi * 100 + 3;                  //属性附加
        public const int Extra_Buff_ZhenShi_Add = Now_ZhenShi * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_ZhenShi_Mul = Now_ZhenShi * 100 + 12;           //属性Buff附加乘法

        /*
        Now_XiXue = 1104;          //当前吸血值
        Base_XiXue_Base = Now_XiXue * 100 + 1;                 //属性累加
        Base_XiXue_Mul = Now_XiXue * 100 + 2;                  //属性乘法
        Base_XiXue_Add = Now_XiXue * 100 + 3;                  //属性附加
        Extra_Buff_XiXue_Add = Now_XiXue * 100 + 11;           //属性Buff附加加法
        Extra_Buff_XiXue_Mul = Now_XiXue * 100 + 12;           //属性Buff附加乘法
        */

        public const int Now_HuiXue = 1105;          //当前回血值
        public const int Base_HuiXue_Base = Now_HuiXue * 100 + 1;                 //属性累加
        public const int Base_HuiXue_Mul = Now_HuiXue * 100 + 2;                  //属性乘法
        public const int Base_HuiXue_Add = Now_HuiXue * 100 + 3;                  //属性附加
        public const int Extra_Buff_HuiXue_Add = Now_HuiXue * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_HuiXue_Mul = Now_HuiXue * 100 + 12;           //属性Buff附加乘法

        public const int Now_HuShiDef = 1181;          //当前忽视目标防御值
        public const int Base_HuShiDef_Base = Now_HuShiDef * 100 + 1;                 //属性累加
        public const int Base_HuShiDef_Mul = Now_HuShiDef * 100 + 2;                  //属性乘法
        public const int Base_HuShiDef_Add = Now_HuShiDef * 100 + 3;                  //属性附加
        public const int Extra_Buff_HuShiDef_Add = Now_HuShiDef * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_HuShiDef_Mul = Now_HuShiDef * 100 + 12;           //属性Buff附加乘法

        public const int Now_HuShiAdf = 1182;          //当前忽视目标魔防值
        public const int Base_HuShiAdf_Base = Now_HuShiAdf * 100 + 1;                 //属性累加
        public const int Base_HuShiAdf_Mul = Now_HuShiAdf * 100 + 2;                  //属性乘法
        public const int Base_HuShiAdf_Add = Now_HuShiAdf * 100 + 3;                  //属性附加
        public const int Extra_Buff_HuShiAdf_Add = Now_HuShiAdf * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_HuShiAdf_Mul = Now_HuShiAdf * 100 + 12;           //属性Buff附加乘法

        public const int Now_CriLv = 1191;          //当前暴击等级
        public const int Base_CriLv_Base = Now_CriLv * 100 + 1;                 //属性累加
        public const int Base_CriLv_Mul = Now_CriLv * 100 + 2;                  //属性乘法
        public const int Base_CriLv_Add = Now_CriLv * 100 + 3;                  //属性附加
        public const int Extra_Buff_CriLv_Add = Now_CriLv * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_CriLv_Mul = Now_CriLv * 100 + 12;           //属性Buff附加乘法

        public const int Now_ResLv = 1192;          //当前韧性等级
        public const int Base_ResLv_Base = Now_ResLv * 100 + 1;                 //属性累加
        public const int Base_ResLv_Mul = Now_ResLv * 100 + 2;                  //属性乘法
        public const int Base_ResLv_Add = Now_ResLv * 100 + 3;                  //属性附加
        public const int Extra_Buff_ResLv_Add = Now_ResLv * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_ResLv_Mul = Now_ResLv * 100 + 12;           //属性Buff附加乘法

        public const int Now_HitLv = 1193;          //当前命中等级
        public const int Base_HitLv_Base = Now_HitLv * 100 + 1;                 //属性累加
        public const int Base_HitLv_Mul = Now_HitLv * 100 + 2;                  //属性乘法
        public const int Base_HitLv_Add = Now_HitLv * 100 + 3;                  //属性附加
        public const int Extra_Buff_HitLv_Add = Now_HitLv * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_HitLv_Mul = Now_HitLv * 100 + 12;           //属性Buff附加乘法

        public const int Now_DodgeLv = 1194;          //当前闪避等级
        public const int Base_DodgeLv_Base = Now_DodgeLv * 100 + 1;                 //属性累加
        public const int Base_DodgeLv_Mul = Now_DodgeLv * 100 + 2;                  //属性乘法
        public const int Base_DodgeLv_Add = Now_DodgeLv * 100 + 3;                  //属性附加
        public const int Extra_Buff_DodgeLv_Add = Now_DodgeLv * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_DodgeLv_Mul = Now_DodgeLv * 100 + 12;           //属性Buff附加乘法

        public const int Now_Luck = 1201;          //当前幸运值
        public const int Base_Luck_Base = Now_Luck * 100 + 1;                 //属性累加
        public const int Base_Luck_Mul = Now_Luck * 100 + 2;                  //属性乘法
        public const int Base_Luck_Add = Now_Luck * 100 + 3;                  //属性附加
        public const int Extra_Buff_Luck_Add = Now_Luck * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_Luck_Mul = Now_Luck * 100 + 12;           //属性Buff附加乘法

        public const int Now_ExpAdd = 1202;          //当前经验收益
        public const int Base_ExpAdd_Base = Now_ExpAdd * 100 + 1;                 //属性累加
        public const int Base_ExpAdd_Mul = Now_ExpAdd * 100 + 2;                  //属性乘法
        public const int Base_ExpAdd_Add = Now_ExpAdd * 100 + 3;                  //属性附加
        public const int Extra_Buff_ExpAdd_Add = Now_ExpAdd * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_ExpAdd_Mul = Now_ExpAdd * 100 + 12;           //属性Buff附加乘法

        public const int Now_GoldAdd = 1203;          //当前金币收益
        public const int Base_GoldAdd_Base = Now_GoldAdd * 100 + 1;                 //属性累加
        public const int Base_GoldAdd_Mul = Now_GoldAdd * 100 + 2;                  //属性乘法
        public const int Base_GoldAdd_Add = Now_GoldAdd * 100 + 3;                  //属性附加
        public const int Extra_Buff_GoldAdd_Add = Now_GoldAdd * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_GoldAdd_Mul = Now_GoldAdd * 100 + 12;           //属性Buff附加乘法

        public const int Now_MonsterDis = 1204;          //怪物发现目标距离
        public const int Base_MonsterDis_Base = Now_MonsterDis * 100 + 1;                 //属性累加
        public const int Base_MonsterDis_Mul = Now_MonsterDis * 100 + 2;                  //属性乘法
        public const int Base_MonsterDis_Add = Now_MonsterDis * 100 + 3;                  //属性附加
        public const int Extra_Buff_MonsterDis_Add = Now_MonsterDis * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MonsterDis_Mul = Now_MonsterDis * 100 + 12;           //属性Buff附加乘法

        public const int Now_JumpDisAdd = 1205;          //冲锋距离加成
        public const int Base_JumpDisAdd_Base = Now_JumpDisAdd * 100 + 1;                 //属性累加
        public const int Base_JumpDisAdd_Mul = Now_JumpDisAdd * 100 + 2;                  //属性乘法
        public const int Base_JumpDisAdd_Add = Now_JumpDisAdd * 100 + 3;                  //属性附加
        public const int Extra_Buff_JumpDisAdd_Add = Now_JumpDisAdd * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_JumpDisAdd_Mul = Now_JumpDisAdd * 100 + 12;           //属性Buff附加乘法

        public const int Now_ActQiangDuAdd = 1206;          //攻击强度
        public const int Base_ActQiangDuAdd_Base = Now_ActQiangDuAdd * 100 + 1;                 //属性累加
        public const int Base_ActQiangDuAdd_Mul = Now_ActQiangDuAdd * 100 + 2;                  //属性乘法
        public const int Base_ActQiangDuAdd_Add = Now_ActQiangDuAdd * 100 + 3;                  //属性附加
        public const int Extra_Buff_ActQiangDuAdd_Add = Now_ActQiangDuAdd * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_ActQiangDuAdd_Mul = Now_ActQiangDuAdd * 100 + 12;           //属性Buff附加乘法

        public const int Now_MageQiangDuAdd = 1207;          //法术强度
        public const int Base_MageQiangDuAdd_Base = Now_ActQiangDuAdd * 100 + 1;                 //属性累加
        public const int Base_MageQiangDuAdd_Mul = Now_ActQiangDuAdd * 100 + 2;                  //属性乘法
        public const int Base_MageQiangDuAdd_Add = Now_ActQiangDuAdd * 100 + 3;                  //属性附加
        public const int Extra_Buff_MageQiangDuAdd_Add = Now_ActQiangDuAdd * 100 + 11;           //属性Buff附加加法
        public const int Extra_Buff_MageQiangDuAdd_Mul = Now_ActQiangDuAdd * 100 + 12;           //属性Buff附加乘法


        //浮点数 2001-2999   其余区间为整数
        public const int Now_Cri = 2001;          //当前暴击概率
        public const int Base_Cri_Base = Now_Cri * 100 + 1;                  //属性累加
        public const int Base_Cri_Mul = Now_Cri * 100 + 2;                   //属性乘法
        public const int Base_Cri_Add = Now_Cri * 100 + 3;                   //属性附加
        public const int Extra_Buff_Cri_Add = Now_Cri * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Cri_Mul = Now_Cri * 100 + 12;            //属性Buff附加乘法

        public const int Now_Hit = 2002;          //当前命中概率
        public const int Base_Hit_Base = Now_Hit * 100 + 1;                  //属性累加
        public const int Base_Hit_Mul = Now_Hit * 100 + 2;                   //属性乘法
        public const int Base_Hit_Add = Now_Hit * 100 + 3;                   //属性附加
        public const int Extra_Buff_Hit_Add = Now_Hit * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Hit_Mul = Now_Hit * 100 + 12;            //属性Buff附加乘法

        public const int Now_Dodge = 2003;          //当前闪避概率
        public const int Base_Dodge_Base = Now_Dodge * 100 + 1;                  //属性累加
        public const int Base_Dodge_Mul = Now_Dodge * 100 + 2;                   //属性乘法
        public const int Base_Dodge_Add = Now_Dodge * 100 + 3;                   //属性附加
        public const int Extra_Buff_Dodge_Add = Now_Dodge * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Dodge_Mul = Now_Dodge * 100 + 12;            //属性Buff附加乘法

        public const int Now_Res = 2004;          //当前韧性概率
        public const int Base_Res_Base = Now_Res * 100 + 1;                  //属性累加
        public const int Base_Res_Mul = Now_Res * 100 + 2;                   //属性乘法
        public const int Base_Res_Add = Now_Res * 100 + 3;                   //属性附加
        public const int Extra_Buff_Res_Add = Now_Res * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Res_Mul = Now_Res * 100 + 12;            //属性Buff附加乘法

        public const int Now_ActDamgeAddPro = 2005;          //当前物理伤害加成
        public const int Base_ActDamgeAddPro_Base = Now_ActDamgeAddPro * 100 + 1;                  //属性累加
        public const int Base_ActDamgeAddPro_Mul = Now_ActDamgeAddPro * 100 + 2;                   //属性乘法
        public const int Base_ActDamgeAddPro_Add = Now_ActDamgeAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActDamgeAddPro_Add = Now_ActDamgeAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActDamgeAddPro_Mul = Now_ActDamgeAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_MageDamgeAddPro = 2006;          //当前魔法伤害加成
        public const int Base_MageDamgeAddPro_Base = Now_MageDamgeAddPro * 100 + 1;                  //属性累加
        public const int Base_MageAddPro_Mul = Now_MageDamgeAddPro * 100 + 2;                        //属性乘法
        public const int Base_MageDamgeAddPro_Add = Now_MageDamgeAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MageDamgeAddPro_Add = Now_MageDamgeAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MageDamgeAddPro_Mul = Now_MageDamgeAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ActDamgeSubPro = 2007;          //当前物理伤害减免
        public const int Base_ActDamgeSubPro_Base = Now_ActDamgeSubPro * 100 + 1;                  //属性累加
        public const int Base_ActDamgeSubPro_Mul = Now_ActDamgeSubPro * 100 + 2;                   //属性乘法
        public const int Base_ActDamgeSubPro_Add = Now_ActDamgeSubPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActDamgeSubPro_Add = Now_ActDamgeSubPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActDamgeSubPro_Mul = Now_ActDamgeSubPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_MageDamgeSubPro = 2008;          //当前魔法伤害减免
        public const int Base_MageDamgeSubPro_Base = Now_MageDamgeSubPro * 100 + 1;                  //属性累加
        public const int Base_MageDamgeSubPro_Mul = Now_MageDamgeSubPro * 100 + 2;                   //属性乘法
        public const int Base_MageDamgeSubPro_Add = Now_MageDamgeSubPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MageDamgeSubPro_Add = Now_MageDamgeSubPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MageDamgeSubPro_Mul = Now_MageDamgeSubPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_DamgeAddPro = 2009;          //当前伤害加成
        public const int Base_DamgeAddPro_Base = Now_DamgeAddPro * 100 + 1;                  //属性累加
        public const int Base_DamgeAddPro_Mul = Now_DamgeAddPro * 100 + 2;                   //属性乘法
        public const int Base_DamgeAddPro_Add = Now_DamgeAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_DamgeAddPro_Add = Now_DamgeAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_DamgeAddPro_Mul = Now_DamgeAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_DamgeSubPro = 2010;          //当前伤害减免
        public const int Base_DamgeSubPro_Base = Now_DamgeSubPro * 100 + 1;                  //属性累加
        public const int Base_DamgeSubPro_Mul = Now_DamgeSubPro * 100 + 2;                   //属性乘法
        public const int Base_DamgeSubPro_Add = Now_DamgeSubPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_DamgeSubPro_Add = Now_DamgeSubPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_DamgeSubPro_Mul = Now_DamgeSubPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ZhongJiPro = 2021;          //当前重击概率
        public const int Base_ZhongJiPro_Base = Now_ZhongJiPro * 100 + 1;                  //属性累加
        public const int Base_ZhongJiPro_Mul = Now_ZhongJiPro * 100 + 2;                   //属性乘法
        public const int Base_ZhongJiPro_Add = Now_ZhongJiPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ZhongJiPro_Add = Now_ZhongJiPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ZhongJiPro_Mul = Now_ZhongJiPro * 100 + 12;            //属性Buff附加乘法


        public const int Now_HuShiActPro = 2022;          //当前攻击穿透
        public const int Base_HuShiActPro_Base = Now_HuShiActPro * 100 + 1;                  //属性累加
        public const int Base_HuShiActPro_Mul = Now_HuShiActPro * 100 + 2;                   //属性乘法
        public const int Base_HuShiActPro_Add = Now_HuShiActPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_HuShiActPro_Add = Now_HuShiActPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_HuShiActPro_Mul = Now_HuShiActPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_HuShiMagePro = 2023;          //当前魔法穿透
        public const int Base_HuShiMagePro_Base = Now_HuShiMagePro * 100 + 1;                   //属性累加
        public const int Base_HuShiMagePro_Mul = Now_HuShiMagePro * 100 + 2;                    //属性乘法
        public const int Base_HuShiMagePro_Add = Now_HuShiMagePro * 100 + 3;                    //属性附加
        public const int Extra_Buff_HuShiMagePro_Add = Now_HuShiMagePro * 100 + 11;             //属性Buff附加加法
        public const int Extra_Buff_HuShiMagePro_Mul = Now_HuShiMagePro * 100 + 12;             //属性Buff附加乘法

        public const int Now_XiXuePro = 2024;          //当前吸血概率
        public const int Base_XiXuePro_Base = Now_XiXuePro * 100 + 1;              //属性累加
        public const int Base_XiXuePro_Mul = Now_XiXuePro * 100 + 2;               //属性乘法
        public const int Base_XiXuePro_Add = Now_XiXuePro * 100 + 3;                   //属性附加
        public const int Extra_Buff_XiXuePro_Add = Now_XiXuePro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_XiXuePro_Mul = Now_XiXuePro * 100 + 12;            //属性Buff附加乘法

        /*
        public const int Now_ActReboundPro = 2025;          //当前攻击反弹
        public const int Base_ActReboundPro_Base = Now_ActReboundPro * 100 + 1;              //属性累加
        public const int Base_ActReboundPro_Mul = Now_ActReboundPro * 100 + 2;               //属性乘法
        public const int Base_ActReboundPro_Add = Now_ActReboundPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActReboundPro_Add = Now_ActReboundPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActReboundPro_Mul = Now_ActReboundPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_MageReboundPro = 2026;          //当前魔法反弹
        public const int Base_MageReboundPro_Base = Now_MageReboundPro * 100 + 1;              //属性累加
        public const int Base_MageReboundPro_Mul = Now_MageReboundPro * 100 + 2;               //属性乘法
        public const int Base_MageReboundPro_Add = Now_MageReboundPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MageReboundPro_Add = Now_MageReboundPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MageReboundPro_Mul = Now_MageReboundPro * 100 + 12;            //属性Buff附加乘法
        */

        public const int Now_ActReboundDamgePro = 2027;          //当前攻击反弹伤害比例
        public const int Base_ActReboundDamgePro_Base = Now_ActReboundDamgePro * 100 + 1;              //属性累加
        public const int Base_ActReboundDamgePro_Mul = Now_ActReboundDamgePro * 100 + 2;               //属性乘法
        public const int Base_ActReboundDamgePro_Add = Now_ActReboundDamgePro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActReboundDamgePro_Add = Now_ActReboundDamgePro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActReboundDamgePro_Mul = Now_ActReboundDamgePro * 100 + 12;            //属性Buff附加乘法

        public const int Now_MageReboundDamgePro = 2028;          //当前魔法反弹伤害比例
        public const int Base_MageReboundDamgePro_Base = Now_MageReboundDamgePro * 100 + 1;              //属性累加
        public const int Base_MageReboundDamgePro_Mul = Now_MageReboundDamgePro * 100 + 2;               //属性乘法
        public const int Base_MageReboundDamgePro_Add = Now_MageReboundDamgePro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MageReboundDamgePro_Add = Now_MageReboundDamgePro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MageReboundDamgePro_Mul = Now_MageReboundDamgePro * 100 + 12;            //属性Buff附加乘法

        /*
        public const int Now_HuiXuePro = 2029;          //当前回血加成
        public const int Base_HuiXuePro_Base = Now_HuiXuePro * 100 + 1;                  //属性累加
        public const int Base_HuiXuePro_Mul = Now_HuiXuePro * 100 + 2;                   //属性乘法
        public const int Base_HuiXuePro_Add = Now_HuiXuePro * 100 + 3;                   //属性附加
        public const int Extra_Buff_HuiXuePro_Add = Now_HuiXuePro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_HuiXuePro_Mul = Now_HuiXuePro * 100 + 12;            //属性Buff附加乘法
        */

        public const int Now_ActBossPro = 2030;                                            //当前BOSS普通攻击加成
        public const int Base_ActBossPro_Base = Now_ActBossPro * 100 + 1;                  //属性累加
        public const int Base_ActBossPro_Mul = Now_ActBossPro * 100 + 2;                   //属性乘法
        public const int Base_ActBossPro_Add = Now_ActBossPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActBossPro_Add = Now_ActBossPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActBossPro_Mul = Now_ActBossPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_MageBossPro = 2031;                                             //当前Boss技能攻击加成
        public const int Base_MageBossPro_Base = Now_MageBossPro * 100 + 1;                  //属性累加
        public const int Base_MageBossPro_Mul = Now_MageBossPro * 100 + 2;                   //属性乘法
        public const int Base_MageBossPro_Add = Now_MageBossPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MageBossPro_Add = Now_MageBossPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MageBossPro_Mul = Now_MageBossPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ActBossSubPro = 2032;          //当前受到Boss技能减免
        public const int Base_ActBossSubPro_Base = Now_ActBossSubPro * 100 + 1;                  //属性累加
        public const int Base_ActBossSubPro_Mul = Now_ActBossSubPro * 100 + 2;                   //属性乘法
        public const int Base_ActBossSubPro_Add = Now_ActBossSubPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActBossSubPro_Add = Now_ActBossSubPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActBossSubPro_Mul = Now_ActBossSubPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_MageBossSubPro = 2033;          //当前受到Boss技能减免
        public const int Base_MageBossSubPro_Base = Now_MageBossSubPro * 100 + 1;                //属性累加
        public const int Base_MageBossSubPro_Mul = Now_MageBossSubPro * 100 + 2;                 //属性乘法
        public const int Base_MageBossSubPro_Add = Now_MageBossSubPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MageBossSubPro_Add = Now_MageBossSubPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MageBossSubPro_Mul = Now_MageBossSubPro * 100 + 12;            //属性Buff附加乘法

        /*
        public const int Now_PetDamgeAddPro = 2034;          //当前宠物攻击加成
        public const int Base_PetDamgeAddPro_Base = Now_PetDamgeAddPro * 100 + 1;                  //属性累加
        public const int Base_PetDamgeAddPro_Mul = Now_PetDamgeAddPro * 100 + 2;                   //属性乘法
        public const int Base_PetDamgeAddPro_Add = Now_PetDamgeAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_PetDamgeAddPro_Add = Now_PetDamgeAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_PetDamgeAddPro_Mul = Now_PetDamgeAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_PetDamgeSubPro = 2035;          //当前宠物受到伤害减免
        public const int Base_PetDamgeSubPro_Base = Now_PetDamgeSubPro * 100 + 1;                  //属性累加
        public const int Base_PetDamgeSubPro_Mul = Now_PetDamgeSubPro * 100 + 2;                   //属性乘法
        public const int Base_PetDamgeSubPro_Add = Now_PetDamgeSubPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_PetDamgeSubPro_Add = Now_PetDamgeSubPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_PetDamgeSubPro_Mul = Now_PetDamgeSubPro * 100 + 12;            //属性Buff附加乘法
        */

        public const int Now_SkillCDTimeCostPro = 2036;          //当前技能冷却时间缩减
        public const int Base_SkillCDTimeCostPro_Base = Now_SkillCDTimeCostPro * 100 + 1;                    //属性累加
        public const int Base_SkillCDTimeCostPro_Mul = Now_SkillCDTimeCostPro * 100 + 2;                     //属性乘法
        public const int Base_SkillCDTimeCostPro_Add = Now_SkillCDTimeCostPro * 100 + 3;                     //属性附加
        public const int Extra_Buff_SkillCDTimeCostPro_Add = Now_SkillCDTimeCostPro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_SkillCDTimeCostPro_Mul = Now_SkillCDTimeCostPro * 100 + 12;              //属性Buff附加乘法

        public const int Now_MiaoSha_Pro = 2037;          //当前秒杀概率
        public const int Base_MiaoSha_Pro_Base = Now_MiaoSha_Pro * 100 + 1;              //属性累加
        public const int Base_MiaoSha_Pro_Mul = Now_MiaoSha_Pro * 100 + 2;               //属性乘法
        public const int Base_MiaoSha_Pro_Add = Now_MiaoSha_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_MiaoSha_Pro_Add = Now_MiaoSha_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_MiaoSha_Pro_Mul = Now_MiaoSha_Pro * 100 + 12;            //属性Buff附加乘法

        /*
        public const int Now_SummonAddPro = 2037;          //当前召唤生物属性加成
        public const int Base_SummonAddPro_Base = Now_SummonAddPro * 100 + 1;              //属性累加
        public const int Base_SummonAddPro_Mul = Now_SummonAddPro * 100 + 2;               //属性乘法
        public const int Base_SummonAddPro_Add = Now_SummonAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_SummonAddPro_Add = Now_SummonAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_SummonAddPro_Mul = Now_SummonAddPro * 100 + 12;            //属性Buff附加乘法
        */
        public const int Now_FuHuoPro = 2038;          //当前复活几率
        public const int Base_FuHuoPro_Base = Now_FuHuoPro * 100 + 1;              //属性累加
        public const int Base_FuHuoPro_Mul = Now_FuHuoPro * 100 + 2;               //属性乘法
        public const int Base_FuHuoPro_Add = Now_FuHuoPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_FuHuoPro_Add = Now_FuHuoPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_FuHuoPro_Mul = Now_FuHuoPro * 100 + 12;            //属性Buff附加乘法
                
        public const int Now_WuShiFangYuPro = 2039;          //当前无视防御
        public const int Base_WuShiFangYuPro_Base = Now_WuShiFangYuPro * 100 + 1;              //属性累加
        public const int Base_WuShiFangYuPro_Mul = Now_WuShiFangYuPro * 100 + 2;               //属性乘法
        public const int Base_WuShiFangYuPro_Add = Now_WuShiFangYuPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_WuShiFangYuPro_Add = Now_WuShiFangYuPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_WuShiFangYuPro_Mul = Now_WuShiFangYuPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_SkillNoCDPro = 2040;          //释放技能不触发技能冷却
        public const int Base_SkillNoCDPro_Base = Now_SkillNoCDPro * 100 + 1;                    //属性累加
        public const int Base_SkillNoCDPro_Mul = Now_SkillNoCDPro * 100 + 2;                     //属性乘法
        public const int Base_SkillNoCDPro_Add = Now_SkillNoCDPro * 100 + 3;                     //属性附加
        public const int Extra_Buff_SkillNoCDPro_Add = Now_SkillNoCDPro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_SkillNoCDPro_Mul = Now_SkillNoCDPro * 100 + 12;              //属性Buff附加乘法

        public const int Now_SkillMoreDamgePro = 2041;          //技能倍伤概率
        public const int Base_SkillMoreDamgePro_Base = Now_SkillMoreDamgePro * 100 + 1;                    //属性累加
        public const int Base_SkillMoreDamgePro_Mul = Now_SkillMoreDamgePro * 100 + 2;                     //属性乘法
        public const int Base_SkillMoreDamgePro_Add = Now_SkillMoreDamgePro * 100 + 3;                     //属性附加
        public const int Extra_Buff_SkillMoreDamgePro_Add = Now_SkillMoreDamgePro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_SkillMoreDamgePro_Mul = Now_SkillMoreDamgePro * 100 + 12;              //属性Buff附加乘法

        public const int Now_SkillDodgePro = 2042;          //技能闪避
        public const int Base_SkillDodgePro_Base = Now_SkillDodgePro * 100 + 1;                    //属性累加
        public const int Base_SkillDodgePro_Mul = Now_SkillDodgePro * 100 + 2;                     //属性乘法
        public const int Base_SkillDodgePro_Add = Now_SkillDodgePro * 100 + 3;                     //属性附加
        public const int Extra_Buff_SkillDodgePro_Add = Now_SkillDodgePro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_SkillDodgePro_Mul = Now_SkillDodgePro * 100 + 12;              //属性Buff附加乘法

        public const int Now_ShenNongPro = 2043;          //神农
        public const int Base_ShenNongPro_Base = Now_ShenNongPro * 100 + 1;                    //属性累加
        public const int Base_ShenNongPro_Mul = Now_ShenNongPro * 100 + 2;                     //属性乘法
        public const int Base_ShenNongPro_Add = Now_ShenNongPro * 100 + 3;                     //属性附加
        public const int Extra_Buff_ShenNongPro_Add = Now_ShenNongPro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_ShenNongPro_Mul = Now_ShenNongPro * 100 + 12;              //属性Buff附加乘法

        public const int Now_SecHpAddPro = 2044;          //每秒百分比恢复
        public const int Base_SecHpAddPro_Base = Now_SecHpAddPro * 100 + 1;                    //属性累加
        public const int Base_SecHpAddPro_Mul = Now_SecHpAddPro * 100 + 2;                     //属性乘法
        public const int Base_SecHpAddPro_Add = Now_SecHpAddPro * 100 + 3;                     //属性附加
        public const int Extra_Buff_SecHpAddPro_Add = Now_SecHpAddPro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_SecHpAddPro_Mul = Now_SecHpAddPro * 100 + 12;              //属性Buff附加乘法

        public const int Now_DiKangPro = 2045;          //抵抗减益Buff概率
        public const int Base_DiKangPro_Base = Now_DiKangPro * 100 + 1;                    //属性累加
        public const int Base_DiKangPro_Mul = Now_DiKangPro * 100 + 2;                     //属性乘法
        public const int Base_DiKangPro_Add = Now_DiKangPro * 100 + 3;                     //属性附加
        public const int Extra_Buff_DiKangPro_Add = Now_DiKangPro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_DiKangPro_Mul = Now_DiKangPro * 100 + 12;              //属性Buff附加乘法

        public const int Now_MageDodgePro = 2046;          //魔法闪避
        public const int Base_MageDodgePro_Base = Now_MageDodgePro * 100 + 1;                    //属性累加
        public const int Base_MageDodgePro_Mul = Now_MageDodgePro * 100 + 2;                     //属性乘法
        public const int Base_MageDodgePro_Add = Now_MageDodgePro * 100 + 3;                     //属性附加
        public const int Extra_Buff_MageDodgePro_Add = Now_MageDodgePro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_MageDodgePro_Mul = Now_MageDodgePro * 100 + 12;              //属性Buff附加乘法

        public const int Now_ZhuanZhuPro = 2047;            //专注  释放技能有概率释放2次
        public const int Base_ZhuanZhuPro_Base = Now_MageDodgePro * 100 + 1;                    //属性累加
        public const int Base_ZhuanZhuPro_Mul = Now_MageDodgePro * 100 + 2;                     //属性乘法
        public const int Base_ZhuanZhuPro_Add = Now_MageDodgePro * 100 + 3;                     //属性附加
        public const int Extra_Buff_ZhuanZhuPro_Add = Now_MageDodgePro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_ZhuanZhuPro_Mul = Now_MageDodgePro * 100 + 12;              //属性Buff附加乘法

        public const int Now_ShenYouPro = 2048;          //当前神佑几率   （跟复活的区别时满血）  
        public const int Base_ShenYouPro_Base = Now_ShenYouPro * 100 + 1;              //属性累加
        public const int Base_ShenYouPro_Mul = Now_ShenYouPro * 100 + 2;               //属性乘法
        public const int Base_ShenYouPro_Add = Now_ShenYouPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ShenYouPro_Add = Now_ShenYouPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ShenYouPro_Mul = Now_ShenYouPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ActDodgePro = 2049;          //物理闪避
        public const int Base_ActDodgePro_Base = Now_ActDodgePro * 100 + 1;                    //属性累加
        public const int Base_ActDodgePro_Mul = Now_ActDodgePro * 100 + 2;                     //属性乘法
        public const int Base_ActDodgePro_Add = Now_ActDodgePro * 100 + 3;                     //属性附加
        public const int Extra_Buff_ActDodgePro_Add = Now_ActDodgePro * 100 + 11;              //属性Buff附加加法
        public const int Extra_Buff_ActDodgePro_Mul = Now_ActDodgePro * 100 + 12;              //属性Buff附加乘法

        public const int Now_ActSpeedPro = 2050;          //当前攻击速度
        public const int Base_ActSpeedPro_Base = Now_ActSpeedPro * 100 + 1;                  //属性累加
        public const int Base_ActSpeedPro_Mul = Now_ActSpeedPro * 100 + 2;                   //属性乘法
        public const int Base_ActSpeedPro_Add = Now_ActSpeedPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ActSpeedPro_Add = Now_ActSpeedPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ActSpeedPro_Mul = Now_ActSpeedPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_DaoActAddPro = 2051;          //刀附加伤害
        public const int Base_DaoActAddPro_Base = Now_DaoActAddPro * 100 + 1;                  //属性累加
        public const int Base_DaoActAddPro_Mul = Now_DaoActAddPro * 100 + 2;                   //属性乘法
        public const int Base_DaoActAddPro_Add = Now_DaoActAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_DaoActAddPro_Add = Now_DaoActAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_DaoActAddPro_Mul = Now_DaoActAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_JianActAddPro = 2052;          //剑附加伤害
        public const int Base_JianActAddPro_Base = Now_JianActAddPro * 100 + 1;                  //属性累加
        public const int Base_JianActAddPro_Mul = Now_JianActAddPro * 100 + 2;                   //属性乘法
        public const int Base_JianActAddPro_Add = Now_JianActAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_JianActAddPro_Add = Now_JianActAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_JianActAddPro_Mul = Now_JianActAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_FaZhangActAddPro = 2053;          //法杖附加伤害
        public const int Base_FaZhangActAddPro_Base = Now_FaZhangActAddPro * 100 + 1;                  //属性累加
        public const int Base_FaZhangActAddPro_Mul = Now_FaZhangActAddPro * 100 + 2;                   //属性乘法
        public const int Base_FaZhangActAddPro_Add = Now_FaZhangActAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_FaZhangActAddPro_Add = Now_FaZhangActAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_FaZhangActAddPro_Mul = Now_FaZhangActAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ShuActAddPro = 2054;          //魔法书附加伤害
        public const int Base_ShuActAddPro_Base = Now_ShuActAddPro * 100 + 1;                  //属性累加
        public const int Base_ShuActAddPro_Mul = Now_ShuActAddPro * 100 + 2;                   //属性乘法
        public const int Base_ShuActAddPro_Add = Now_ShuActAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ShuActAddPro_Add = Now_ShuActAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ShuActAddPro_Mul = Now_ShuActAddPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ZhanShaPro = 2025;          //当前斩杀比例  血量低于35%触发斩杀
        public const int Base_ZhanShaPro_Base = Now_ZhanShaPro * 100 + 1;              //属性累加
        public const int Base_ZhanShaPro_Mul = Now_ZhanShaPro * 100 + 2;               //属性乘法
        public const int Base_ZhanShaPro_Add = Now_ZhanShaPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ZhanShaPro_Add = Now_ZhanShaPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ZhanShaPro_Mul = Now_ZhanShaPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ChaoFengPro = 2026;          //当前嘲讽比例  
        public const int Base_ChaoFengPro_Base = Now_ChaoFengPro * 100 + 1;              //属性累加
        public const int Base_ChaoFengPro_Mul = Now_ChaoFengPro * 100 + 2;               //属性乘法
        public const int Base_ChaoFengPro_Add = Now_ChaoFengPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ChaoFengPro_Add = Now_ChaoFengPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ChaoFengPro_Mul = Now_ChaoFengPro * 100 + 12;            //属性Buff附加乘法

        public const int Now_PuGongAddPro = 2027;          //当前普攻加成比例  
        public const int Base_PuGongAddPro_Base = Now_PuGongAddPro * 100 + 1;              //属性累加
        public const int Base_PuGongAddPro_Mul = Now_PuGongAddPro * 100 + 2;               //属性乘法
        public const int Base_PuGongAddPro_Add = Now_PuGongAddPro * 100 + 3;                   //属性附加
        public const int Extra_Buff_PuGongAddPro_Add = Now_PuGongAddPro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_PuGongAddPro_Mul = Now_PuGongAddPro * 100 + 12;            //属性Buff附加乘法

        //----------------抗性-------------

        public const int Now_Resistance_Shine_Pro = 2101;          //当前神圣抗性
        public const int Base_Resistance_Shine_Pro_Base = Now_Resistance_Shine_Pro * 100 + 1;              //属性累加
        public const int Base_Resistance_Shine_Pro_Mul = Now_Resistance_Shine_Pro * 100 + 2;               //属性乘法
        public const int Base_Resistance_Shine_Pro_Add = Now_Resistance_Shine_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Resistance_Shine_Pro_Add = Now_Resistance_Shine_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Resistance_Shine_Pro_Mul = Now_Resistance_Shine_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Resistance_Shadow_Pro = 2102;          //当前暗影抗性
        public const int Base_Resistance_Shadow_Pro_Base = Now_Resistance_Shadow_Pro * 100 + 1;              //属性累加
        public const int Base_Resistance_Shadow_Pro_Mul = Now_Resistance_Shadow_Pro * 100 + 2;               //属性乘法
        public const int Base_Resistance_Shadow_Pro_Add = Now_Resistance_Shadow_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Resistance_Shadow_Pro_Add = Now_Resistance_Shadow_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Resistance_Shadow_Pro_Mul = Now_Resistance_Shadow_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ResistIcece_Ice_Pro = 2103;          //当前冰霜抗性
        public const int Base_ResistIcece_Ice_Pro_Base = Now_ResistIcece_Ice_Pro * 100 + 1;              //属性累加
        public const int Base_ResistIcece_Ice_Pro_Mul = Now_ResistIcece_Ice_Pro * 100 + 2;               //属性乘法
        public const int Base_ResistIcece_Ice_Pro_Add = Now_ResistIcece_Ice_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ResistIcece_Ice_Pro_Add = Now_ResistIcece_Ice_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ResistIcece_Ice_Pro_Mul = Now_ResistIcece_Ice_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ResistFirece_Fire_Pro = 2104;          //当前火焰抗性
        public const int Base_ResistFirece_Fire_Pro_Base = Now_ResistFirece_Fire_Pro * 100 + 1;              //属性累加
        public const int Base_ResistFirece_Fire_Pro_Mul = Now_ResistFirece_Fire_Pro * 100 + 2;               //属性乘法
        public const int Base_ResistFirece_Fire_Pro_Add = Now_ResistFirece_Fire_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ResistFirece_Fire_Pro_Add = Now_ResistFirece_Fire_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ResistFirece_Fire_Pro_Mul = Now_ResistFirece_Fire_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ResistThunderce_Thunder_Pro = 2105;          //当前闪电抗性
        public const int Base_ResistThunderce_Thunder_Pro_Base = Now_ResistThunderce_Thunder_Pro * 100 + 1;              //属性累加
        public const int Base_ResistThunderce_Thunder_Pro_Mul = Now_ResistThunderce_Thunder_Pro * 100 + 2;               //属性乘法
        public const int Base_ResistThunderce_Thunder_Pro_Add = Now_ResistThunderce_Thunder_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ResistThunderce_Thunder_Pro_Add = Now_ResistThunderce_Thunder_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ResistThunderce_Thunder_Pro_Mul = Now_ResistThunderce_Thunder_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Resistance_Beast_Pro = 2111;          //当前野兽抗性
        public const int Base_Resistance_Beast_Pro_Base = Now_Resistance_Beast_Pro * 100 + 1;              //属性累加
        public const int Base_Resistance_Beast_Pro_Mul = Now_Resistance_Beast_Pro * 100 + 2;               //属性乘法
        public const int Base_Resistance_Beast_Pro_Add = Now_Resistance_Beast_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Resistance_Beast_Pro_Add = Now_Resistance_Beast_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Resistance_Beast_Pro_Mul = Now_Resistance_Beast_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Resistance_Hum_Pro = 2112;          //当前人物抗性
        public const int Base_Resistance_Hum_Pro_Base = Now_Resistance_Hum_Pro * 100 + 1;              //属性累加
        public const int Base_Resistance_Hum_Pro_Mul = Now_Resistance_Hum_Pro * 100 + 2;               //属性乘法
        public const int Base_Resistance_Hum_Pro_Add = Now_Resistance_Hum_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Resistance_Hum_Pro_Add = Now_Resistance_Hum_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Resistance_Hum_Pro_Mul = Now_Resistance_Hum_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Resistance_Demon_Pro = 2113;          //当前恶魔抗性
        public const int Base_Resistance_Demon_Pro_Base = Now_Resistance_Demon_Pro * 100 + 1;              //属性累加
        public const int Base_Resistance_Demon_Pro_Mul = Now_Resistance_Demon_Pro * 100 + 2;               //属性乘法
        public const int Base_Resistance_Demon_Pro_Add = Now_Resistance_Demon_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Resistance_Demon_Pro_Add = Now_Resistance_Demon_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Resistance_Demon_Pro_Mul = Now_Resistance_Demon_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Damge_Beast_Pro = 2121;          //当前野兽伤害
        public const int Base_Damge_Beast_Pro_Base = Now_Damge_Beast_Pro * 100 + 1;              //属性累加
        public const int Base_Damge_Beast_Pro_Mul = Now_Damge_Beast_Pro * 100 + 2;               //属性乘法
        public const int Base_Damge_Beast_Pro_Add = Now_Damge_Beast_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Damge_Beast_Pro_Add = Now_Damge_Beast_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Damge_Beast_Pro_Mul = Now_Damge_Beast_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Damge_Hum_Pro = 2122;          //当前人物伤害
        public const int Base_Damge_Hum_Pro_Base = Now_Damge_Hum_Pro * 100 + 1;              //属性累加
        public const int Base_Damge_Hum_Pro_Mul = Now_Damge_Hum_Pro * 100 + 2;               //属性乘法
        public const int Base_Damge_Hum_Pro_Add = Now_Damge_Hum_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Damge_Hum_Pro_Add = Now_Damge_Hum_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Damge_Hum_Pro_Mul = Now_Damge_Hum_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_Damge_Demon_Pro = 2123;          //当前恶魔伤害
        public const int Base_Damge_Demon_Pro_Base = Now_Damge_Demon_Pro * 100 + 1;              //属性累加
        public const int Base_Damge_Demon_Pro_Mul = Now_Damge_Demon_Pro * 100 + 2;               //属性乘法
        public const int Base_Damge_Demon_Pro_Add = Now_Damge_Demon_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_Damge_Demon_Pro_Add = Now_Damge_Demon_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_Damge_Demon_Pro_Mul = Now_Damge_Demon_Pro * 100 + 12;            //属性Buff附加乘法


        
        public const int Now_GoldAdd_Pro = 2201;          //经验收益
        public const int Base_GoldAdd_Pro_Base = Now_GoldAdd_Pro * 100 + 1;                  //属性累加
        public const int Base_GoldAdd_Pro_Mul = Now_GoldAdd_Pro * 100 + 2;                   //属性乘法
        public const int Base_GoldAdd_Pro_Add = Now_GoldAdd_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_GoldAdd_Pro_Add = Now_GoldAdd_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_GoldAdd_Pro_Mul = Now_GoldAdd_Pro * 100 + 12;            //属性Buff附加乘法

        public const int Now_ExpAdd_Pro = 2202;          //金币收益
        public const int Base_ExpAdd_Pro_Base = Now_ExpAdd_Pro * 100 + 1;                  //属性累加
        public const int Base_ExpAdd_Pro_Mul = Now_ExpAdd_Pro * 100 + 2;                   //属性乘法
        public const int Base_ExpAdd_Pro_Add = Now_ExpAdd_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_ExpAdd_Pro_Add = Now_ExpAdd_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_ExpAdd_Pro_Mul = Now_ExpAdd_Pro * 100 + 12;            //属性Buff附加乘法
        

        public const int Now_DropAdd_Pro = 2203;          //爆率收益
        public const int Base_DropAdd_Pro_Base = Now_DropAdd_Pro * 100 + 1;                  //属性累加
        public const int Base_DropAdd_Pro_Mul = Now_DropAdd_Pro * 100 + 2;                   //属性乘法
        public const int Base_DropAdd_Pro_Add = Now_DropAdd_Pro * 100 + 3;                   //属性附加
        public const int Extra_Buff_DropAdd_Pro_Add = Now_DropAdd_Pro * 100 + 11;            //属性Buff附加加法
        public const int Extra_Buff_DropAdd_Pro_Mul = Now_DropAdd_Pro * 100 + 12;            //属性Buff附加乘法

        public const int AOI = 2204;
        public const int AOIBase = AOI * 10 + 1;
        public const int AOIAdd = AOI * 10 + 2;
        public const int AOIPct = AOI * 10 + 3;
        public const int AOIFinalAdd = AOI * 10 + 4;
        public const int AOIFinalPct = AOI * 10 + 5;
}
}
