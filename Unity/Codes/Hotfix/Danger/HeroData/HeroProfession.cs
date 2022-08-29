using System;
using ET;

namespace ET
{

    /// <summary>
    /// 英雄职业
    /// </summary>
    [Flags]
    public enum HeroProfession
    {
        //"法师"
        Caster = 1 << 1,           

        //"射手"
        Archer = 1 << 2,

        //"战士"
        Warrior = 1 << 3,
    }
}