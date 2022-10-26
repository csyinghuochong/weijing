using System.Collections.Generic;

namespace ET
{
    public class TeamDropItem : Entity, IAwake
    {
        public long EndTime = 0;
        public DropInfo DropInfo; 
        public List<long> NeedPlayers = new List<long>();
        public List<long> GivePlayers = new List<long>();
    }

    public class TeamDungeonComponent : Entity, IAwake, IDestroy
    {

        public long Timer;
        public long EnterTime;
        public TeamInfo TeamInfo;
        public List<int> BoxReward = new List<int>();
        public List<TeamDropItem> TeamDropItems = new List<TeamDropItem>();
        public Dictionary<long, long> ItemFlags = new Dictionary<long, long>();

        public M2C_TeamPickMessage m2C_TeamPickMessage = new M2C_TeamPickMessage();
        public M2C_SyncChatInfo m2C_SyncChatInfo = new M2C_SyncChatInfo();
    }
}
