using System.Collections.Generic;

namespace ET
{

    public class LocalDungeonComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public int DungeonId;
        public int FubenDifficulty;

        public int RandomMonster;
        public int RandomJingLing;

        public Unit MainUnit;
        public List<RefreshMonster> RefreshMonsters = new List<RefreshMonster>();
    }
}
