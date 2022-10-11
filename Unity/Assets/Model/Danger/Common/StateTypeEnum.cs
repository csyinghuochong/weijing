using System;

namespace ET
{


    public static class StateTypeEnum
    {
        public const long None = 1 << 0;

        /// <summary>
        /// 传送
        /// </summary>
        public const long ChuanSong = 1 << 1;

        /// <summary>
        /// 空闲
        /// </summary>
        public const long  Idle = 1 << 2;

        /// <summary>
        /// 释放技能
        /// </summary>
        public const long SkillRigidity = 1 << 3;

        /// <summary>
        /// 击退
        /// </summary>
        public const long JiTui = 1 << 4;

        /// <summary>
        /// 沉默 不能放技能
        /// </summary>
        public const long Silence = 1 << 6;

        /// <summary>
        /// 眩晕
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
        /// 禁锢 不能移动
        /// </summary>
        public const long Shackle = 1 << 11;

        /// <summary>
        /// 打断
        /// </summary>
        public const long Interrupt = 1 << 12;

        /// <summary>
        /// 遇到障碍物
        /// </summary>
        public const long Obstruct = 1 << 13;

        /// <summary>
        /// 无敌
        /// </summary>
        public const long WuDi = 1 << 18;
        /// <summary>
        /// 秒杀
        /// </summary>
        public const long MiaoSha = 1 << 19;

        //护盾
        public const long Shield = 1 << 20;
    }
}