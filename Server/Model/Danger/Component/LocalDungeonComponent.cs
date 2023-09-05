using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    public class LocalDungeonComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public int FubenDifficulty;

        public int RandomMonster;
        public int RandomJingLing;

        public Unit MainUnit;
        public List<RefreshMonster> RefreshMonsters = new List<RefreshMonster>();

        public bool UseLastPosition;

        public Vector3 LastPosition;

        public long LastDungeonId;
    }
}
