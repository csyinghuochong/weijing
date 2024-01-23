namespace ET
{
    public class HappyDungeonComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public M2C_HappyInfoResult M2C_HappyInfoResult = new M2C_HappyInfoResult();
    }
}
