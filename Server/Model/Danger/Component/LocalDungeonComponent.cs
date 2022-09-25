using System.Collections.Generic;

namespace ET
{

    public class LocalDungeonComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public int DungeonId;
        public Unit MainUnit;
        public int FubenDifficulty;

        public List<RefreshMonster> RefreshMonsters = new List<RefreshMonster>();
    }
}
