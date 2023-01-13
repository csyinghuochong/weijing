

using System.Collections.Generic;

namespace ET
{

    public struct WorldSayConfig
    {
        public int Time;
        public string Conent;
        public long ServerTime;
    }

    public struct CollectionWord
    {
        public string Words;
        public string Reward;
    }

    public static class CombatResultEnum
    {
        public const int None = 0;
        public const int Win = 1;
        public const int Fail = 2;
    }

    public static class CampEnum
    {
        public const int CampMonster1 = 0;
        public const int CampPlayer_1 = 1;
        public const int CampPlayer_2 = 2;
    }

    public static class LoginTypeEnum
    {
        public const int RegisterLogin = 0;     //注册账号登录
        public const int WeixLogin = 1;         //微信登录
        public const int QQLogin = 2;           //QQ登录
        public const int PhoneCodeLogin = 3;         //短信验证吗登录
        public const int PhoneNumLogin = 4;        //手机号登录
    }

    public static class PayTypeEnum
    {
        public const int WeiXinPay = 1;
        public const int AliPay = 2;
        public const int QuDaoPay = 3;
    }

    public static class HeadBarType
    {
        public const int TransferUI = 1;
        public const int NpcHeadBarUI = 2;
        public const int DropUI = 3;
        public const int HeroHeadBar = 4;
        public const int SceneItemUI = 5;
    }

    public static class ReddotType
    {
        public const int Friend = 100;
        public const int FriendApply = 101;
        public const int UnionMy = 102;
        public const int UnionApply = 103;

        public const int Team = 200;
        public const int TeamApply = 201;

        public const int Email = 300;

        /// <summary>
        /// 角色属性点
        /// </summary>
        public const int RolePoint = 400;

    }

    public enum GameSettingEnum
    {
        
        None,
        Music,
        Sound,
        YanGan,         //1移动 2固定
        MusicVolume,    //音乐大小
        SoundVolume,    //音效大小
        FenBianlLv,     //分辨率[1流暢 2一般]
        Click,
        Shadow,
    }

    //1：普通
    //2：精英
    //3：BOSS
    //4：怪物召唤
    //5：场景物【场景怪 能量台子 传送门】

    public static class MonsterTypeEnum
    {
        public const int None = 0;
        public const int Normal = 1;
        public const int Elite = 2;
        public const int Boss = 3;
        public const int ZhaoHuan = 4;
        public const int SceneItem = 5;
    }

}
