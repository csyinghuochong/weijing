namespace ET
{

    public class HappySceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public long FubenUnitId;

        public long FubenInstanceId;

        public M2C_HappyInfoResult M2C_HappyInfoResult = new M2C_HappyInfoResult(); 
    }
}
