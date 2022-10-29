using System.Collections.Generic;

namespace ET
{
    public struct RefreshMonster
    {
        public int MonsterId;
        public float PositionX;
        public float PositionY;
        public float PositionZ;
        public long NextTime;
        public float Range;
        public int Number;
        public int Interval;
    }

    public class YeWaiRefreshComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public List<RefreshMonster> RefreshMonsters = new List<RefreshMonster>();  
    }
}
