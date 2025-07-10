using System.Collections.Generic;

namespace ET
{
    public class AccountCenterComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public int TianQITime = 0;
        public int TianQiValue= 0;

        public int CheckIndex = 0;
        public DBCenterSerialInfo DBCenterSerialInfo = new DBCenterSerialInfo();

        public Dictionary<string, KeyValuePair<long, string>> PhoneVerification = new Dictionary<string, KeyValuePair<long, string>>();
    }
}
