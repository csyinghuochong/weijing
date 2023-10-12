using System.Collections.Generic;

namespace ET
{
    public class RankSceneComponent : Entity, IAwake,IDestroy
    {
        public long Timer = 0;

        public long PassTime = 0;   

        public DBRankInfo DBRankInfo = new DBRankInfo();

        public DBServerInfo DBServerInfo = new DBServerInfo();


        public long RankingTrialLastTime = 0;
        public List<RankingInfo> RankingTrials = new List<RankingInfo>();   

        public int UpdateCombat = 0;
    }
}
