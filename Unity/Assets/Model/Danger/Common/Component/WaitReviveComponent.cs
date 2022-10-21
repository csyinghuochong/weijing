using System.Collections.Generic;

namespace ET
{

    //刷新组件
    public class WaitReviveComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<long, long> WaitReviveIds = new Dictionary<long, long>();
    }
}
