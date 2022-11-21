namespace ET
{
    public class TowerComponent : Entity, IAwake, IDestroy
    {
        public int TowerId;
        public Unit MainUnit;
        public long Timer;
        public long WaveTime;
        public int FubenDifficulty;
    }
}
