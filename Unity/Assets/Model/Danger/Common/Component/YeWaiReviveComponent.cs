using System.Collections.Generic;

namespace ET
{

    public class YeWaiReviveComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<long, long> WaitReviveIds = new Dictionary<long, long>();
    }
}
