using System.Collections.Generic;

namespace ET
{
    public class JiaYuanSceneComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<long, long> JiaYuanFubens = new Dictionary<long, long>();
    }
}
