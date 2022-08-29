namespace ET
{

    public class DeathTimeComponent : Entity, IAwake<long>, IDestroy
    {
        public long Timer;
    }
}
