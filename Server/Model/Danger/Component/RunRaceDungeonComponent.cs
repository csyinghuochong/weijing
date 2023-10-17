namespace ET
{
    public class RunRaceDungeonComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public long NextTransforTime;

        public bool Close;

        public int CheckTime;

        public bool HaveArrived;
    }
}
