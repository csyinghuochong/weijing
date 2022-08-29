using System.Collections.Generic;

namespace ET
{

    public class LocalDungeonComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public int DungeonId;
        public Unit MainUnit;
        public int Difficulty;

        public List<RefreshMonster> RefreshMonsters = new List<RefreshMonster>();
    }
}
