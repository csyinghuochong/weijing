using System.Collections.Generic;

namespace ET
{
    public struct RefreshMonster
    {
        public int MonsterId;
        public long RefreshTime;
        public float PositionX;
        public float PositionY;
        public float PositionZ;
        public float Range;
        public int Number;

        public string Time;
    }

    public class YeWaiRefreshComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public List<RefreshMonster> RefreshMonsters = new List<RefreshMonster>();  
    }
}
