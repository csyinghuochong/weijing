


namespace ET
{
    public enum ChannelEnum
    { 
        Word =0 ,               //世界 
        Team = 1,               //组队
        System = 2,             //系统
        Union = 3,                  //帮派
        Friend = 11,             //私聊
    }

    public static class NoticeType
    { 
        public const int Notice = 0;
        public const int StopSever = 1;  //停服
        public const int RemoteLogin = 2;//异地登录

        public const int UnitDisconnect = 3;
        public const int BattleOpen = 3;
        public const int BattleNotice = 4;
        public const int BattleClose = 5;
        public const int TeamDungeon = 6;
        public const int YeWaiBoss = 7;
        public const int TeamExit = 8;
    }

}
