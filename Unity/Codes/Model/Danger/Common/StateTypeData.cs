using System;

namespace ET
{

    [Flags]
    public enum StateTypeData:long
    {
        None = 1 << 0,

        /// <summary>
        /// 传送
        /// </summary>
        ChuanSong = 1 << 1,

        /// <summary>
        /// 空闲
        /// </summary>
        Idle = 1 << 2,

        /// <summary>
        /// 释放技能
        /// </summary>
        SkillRigidity = 1 << 3,

        /// <summary>
        /// 击退
        /// </summary>
        JiTui = 1 << 4,

        /// <summary>
        /// 沉默
        /// </summary>
        Silence = 1 << 6,

        /// <summary>
        /// 眩晕
        /// </summary>
        Dizziness = 1 << 7,

        /// <summary>
        /// 吟唱
        /// </summary>
        Singing = 1 << 8,

        /// <summary>
        /// 开箱子
        /// </summary>
        OpenBox = 1 << 9,

        /// <summary>
        /// 禁锢
        /// </summary>
        Shackle = 1 << 11,

        /// <summary>
        /// 打断
        /// </summary>
        Interrupt = 1 << 12,

        /// <summary>
        /// 遇到障碍物
        /// </summary>
        Obstruct = 1 << 13,

        /// <summary>
        /// 无敌
        /// </summary>
        WuDi = 1 << 18,
        /// <summary>
        /// 秒杀
        /// </summary>
        MiaoSha = 1 << 19,

        //护盾
        Shield = 1 << 20,
    }
}