using System.Collections.Generic;

namespace ET
{

    public struct ActivityTimer
    {
        public long BeginTime;
        public int FunctionId;
        public int FunctionType; //1开始 2结束
    }

    public sealed class SMSSVerifyResult
    {
        //认证结果
        public int status;
        
        public string error;
    }

    public struct PropertyValue
    {
        public int HideID;
        public long HideValue;
    }

    public struct JianDingDate
    {
        public int MaxNum;
        public int MinNum;
    }

    public struct ActivityTipConfig
    {
        public long OpenTime;
        public long CloseTime;
        public string Conent;
        public string UIType;
        public List<int> OpenDay;
    }

    public struct WorldSayConfig
    {
        public int Time;
        public string Conent;
        public long ServerTime;
        public List<int> OpenDay;
    }

    public struct BuyCellCost
    {
        public string Cost;
        public string Get;
    }

    //家园收购
    public struct JiaYuanPurchase
    {
        public int ItemID;
        public int ItemNum;
        public int BuyMinZiJin;
        public int BuyMaxZiJin;
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
        public const int TapTap = 5;                //taptap登录
    }

    public static class PayTypeEnum
    {
        public const int WeiXinPay = 1;
        public const int AliPay = 2;
        public const int QuDaoPay = 3;
        public const int IOSPay = 4;
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
        public const int FriendChat = 102;
        public const int UnionMy = 110;
        public const int UnionApply = 111;


        public const int Team = 200;
        public const int TeamApply = 201;

        public const int Email = 300;

        /// <summary>
        /// 角色属性点
        /// </summary>
        public const int RolePoint = 400;

        /// <summary>
        /// 技能点
        /// </summary>
        public const int SkillUp = 500;
    }

    public enum GameSettingEnum
    {
        None = 0,
        Music,
        Sound,
        YanGan,         //1移动 2固定
        MusicVolume,    //音乐大小
        SoundVolume,    //音效大小
        FenBianlLv,     //分辨率[1流暢 2一般]
        HighFps,         //0 30帧 1 60帧
        Click,
        Shadow,
        RandomHorese,  //随机坐骑
        OneSellSet,    //一键出售
        AttackMode,
        AttackTarget,
        Smooth,         //流畅模式
        NoShowOther,          //显示其他玩家
        AutoAttack,         //自动攻击

        //挂机相关设置
        GuaJiSell = 201,      //一键出售  
        GuaJiRang = 202,      //挂机范围
        GuaJiAutoUseItem = 203,     //自动使用药剂

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
