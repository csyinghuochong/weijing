

namespace ET
{ 

    public static class SettingHelper
    {

        /// <summary>
        /// 主城周围超过50个人不再进行显示
        /// </summary>
        public static int NoShowPlayer = 5;

        /// <summary>
        /// 称号周围同屏超过50个人不再进行显示
        /// </summary>
        public static int NoShowTitle = 10;

        /// <summary>
        /// 同屏超过50个人不显示光环特效(特效名称关键字: GuangHuan)
        /// </summary>
        public static int NotGuangHuan = 15;


        public static int CurrentShow = 0;

        /// <summary>
        /// 特效
        /// </summary>
        public static bool ShowTitle = true;    

        /// <summary>
        /// 血条
        /// </summary>
        public static bool ShowBlood = true;
        /// <summary>
        /// 特效
        /// </summary>
        public static bool ShowEffect = true;

        /// <summary>
        /// 动画
        /// </summary>
        public static bool ShowAnimation = true;
        
        /// <summary>
        /// 音效
        /// </summary>
        public static bool PlaySound = true;

        public static bool UsePool = true;

    }
}