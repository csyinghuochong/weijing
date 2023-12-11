#if SERVER
using MongoDB.Bson.Serialization.Attributes;
#endif


namespace ET
{

    public static class UserDataType
    {
        public const int None = 0;
        public const int Gold = 1;                 //金币
        public const int Exp = 2;               //经验值
        public const int Diamond = 3;                //钻石  
        public const int Vitality = 4;               //活力
        public const int PiLao = 5;                  //疲劳  
        public const int RongYu = 6;             //荣誉
        public const int FangRong = 7;           //繁荣度
        public const int MaoXianExp = 8;         //冒险家经验
        public const int DungeonTimes = 9;       //每日副本次数
        public const int Recharge = 10;          //充值
        public const int HuoYue = 11;                 //活跃
        public const int Sp = 12;                     //sp[技能点]
        public const int JiaYuanFund = 13;           //家园资金
        public const int JiaYuanExp = 14;            //家园经验
        public const int BaoShiDu = 15;
        public const int UnionZiJin = 16;            //家族贡献
        public const int UnionExp = 17;              //家族经验
        public const int JueXingExp = 18;

        public const int Lv = 19;                     //等级       
        public const int JiaYuanLv = 20;              //家园等级
        public const int Combat = 21;                 //zhanli战力  
        public const int Occ = 22;                    //职业
        public const int Name = 23;                   //名称
        public const int StallName = 24;              //摊位名字
        public const int PetStatus = 25;              //宠物出站状态
        public const int UnionName = 26;
        public const int DemonName = 27;
        public const int Message = 28;
        public const int PullBack = 29;
        public const int BuffSkill = 30;

        public const int SeasonExp = 31;                        //赛季经验
        public const int SeasonCoin = 32;                       //赛季币
        public const int SeasonLevel = 33;

        public const int InvestMent = 34;                       //投资资金
        public const int UnionGold = 35;                        //家族金币

        public const int Max = 100;
    }

#if SERVER
    public class UserInfoComponent : Entity, IAwake, IDestroy, ITransfer, IUnitCache
#else
     public class UserInfoComponent : Entity, IAwake
#endif
    {
        /// <summary>
        /// 登录或者零点刷新的时候会改变.主要用来体力恢复，刷新数据
        /// </summary>
        public long LastLoginTime;

        /// <summary>
        /// 领地经验
        /// </summary>
        public int LingDiOnLine;

        /// <summary>
        /// 今日在线时长
        /// </summary>
        public long TodayOnLine;

        public long LastJiaYuanExpTime = 0;
        public string RemoteAddress;
        public string DeviceName;
        public string UserName;
        public string Account;
        public UserInfo UserInfo = new UserInfo();
#if SERVER

        /// <summary>
        /// 狩猎击杀野怪数量
        /// </summary>
        public int ShouLieKill;

        public long ShouLieSendTime;

        [BsonIgnore]
        public readonly M2C_RoleDataBroadcast m2C_RoleDataBroadcast  = new M2C_RoleDataBroadcast();
        [BsonIgnore]
        public readonly M2C_RoleDataUpdate m2C_RoleDataUpdate = new M2C_RoleDataUpdate();

        [BsonIgnore]
        public long ShouLieUpLoadTimer;
#endif
    }
}
