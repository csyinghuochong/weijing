namespace ET
{

    public enum UserDataType:int
    {
        None,
        Gold=1,                 //金币
        Exp = 2,                //经验值
        Diamond = 3,                //钻石  
        Vitality = 4,               //活力
        PiLao = 5,                  //疲劳  
        RongYu = 6,             //荣誉
        FangRong = 7,           //繁荣度
        Lv,                     //等级            
        Occ,                    //职业
        HuoYue,                 //活跃
        Sp,                     //sp[技能点]
        Name,                   //名称
        TeamDungeonTimes,             //每日副本次数
        StallName,              //摊位名字
        Union,                  //公会
        Combat,                 //zhanli战力
        PetStatus,              //宠物出站状态
        UnionName,
        Max,
    }

    public class UserInfoComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public long LastLoginTime;
        public long TotalOnLineTime;
        public int LingDiOnLine;
        public string RemoteAddress;
        public string UserName;
        public string Account;
        public UserInfo UserInfo = new UserInfo();
#if SERVER
        public readonly M2C_RoleDataBroadcast m2C_RoleDataBroadcast  = new M2C_RoleDataBroadcast();
        public readonly M2C_RoleDataUpdate m2C_RoleDataUpdate = new M2C_RoleDataUpdate();
#endif
    }
}
