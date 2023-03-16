using System;

namespace ET
{


    public static class StateTypeEnum
    {
        public const long None = 1 << 0;

        /// <summary>
        /// 被拉扯
        /// </summary>
        public const long BePulled = 1 << 1;    

        /// <summary>
        /// 击退
        /// </summary>
        public const long JiTui = 1 << 4;

        /// <summary>
        /// 沉默免疫
        /// </summary>
        public const long SilenceImmune = 1 << 5;

        /// <summary>
        /// 沉默 不能放技能
        /// </summary>
        public const long Silence = 1 << 6;

        /// <summary>
        /// 眩晕 不能放技能不能移动
        /// </summary>
        public const long Dizziness = 1 << 7; 

        /// <summary>
        /// 吟唱
        /// </summary>
        public const long Singing = 1 << 8;

        /// <summary>
        /// 开箱子
        /// </summary>
        public const long OpenBox = 1 << 9;

        /// <summary>
        /// 嘲讽
        /// </summary>
        public const long ChaoFeng = 1<< 10;    

        /// <summary>
        /// 禁锢 不能移动
        /// </summary>
        public const long Shackle = 1 << 11;

        /// <summary>
        /// 眩晕免疫
        /// </summary>
        public const long DizzinessImmune = 1 << 14; 

        /// <summary>
        /// 无敌 （对怪有效）
        /// </summary>
        public const long WuDi = 1 << 18;
        /// <summary>
        /// 秒杀
        /// </summary>
        public const long MiaoSha = 1 << 19;

        /// <summary>
        /// 霸体 buff 霸体效果，免疫眩晕和禁锢状态
        /// </summary>
        public const long BaTi = 1 << 20;

        /// <summary>
        /// 无敌 （对怪物有效）
        /// </summary>
        public const long WuDiMonster = 1 << 21;
    }
}