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
        public List<RankingTrialInfo> RankingTrials = new List<RankingTrialInfo>();

        public long RankSeasonTowerLastTime = 0;
        public List<RankSeasonTowerInfo> RankSeasonTowers = new List<RankSeasonTowerInfo>();

        public int UpdateCombat = 0;
    }
}
