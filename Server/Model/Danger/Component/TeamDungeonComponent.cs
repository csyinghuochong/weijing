using System.Collections.Generic;

namespace ET
{
    public class TeamDungeonComponent : Entity, IAwake
    {
        public long EnterTime;
        public TeamInfo TeamInfo;
        public List<int> BoxReward = new List<int>();
        public Dictionary<long, long> ItemFlags = new Dictionary<long, long>();
    }
}
