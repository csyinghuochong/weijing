namespace ET
{
    public class RankSceneComponent : Entity, IAwake,IDestroy
    {
        public long Timer = 0;

        public DBRankInfo DBRankInfo = new DBRankInfo();

        public DBServerInfo DBServerInfo = new DBServerInfo();

        public int UpdateCombat = 0;
    }
}
