namespace ET
{
    public class AccountCenterComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public DBCenterSerialInfo DBCenterSerialInfo = new DBCenterSerialInfo();
    }
}
