namespace ET
{
    public class RankSceneComponent : Entity, IAwake,IDestroy
    {
        public long Timer = 0;

        public int RankNumber = 30;
        public int CampRankNumber = 50;
        public int PetRankNumber = 100;

        public DBRankInfo DBRankInfo = new DBRankInfo();

        public DBServerInfo DBServerInfo = new DBServerInfo();
    }
}
