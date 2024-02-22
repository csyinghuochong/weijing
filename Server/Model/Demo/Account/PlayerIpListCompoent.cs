using System.Collections.Generic;

namespace ET
{
    public class PlayerIpListCompoent : Entity, IAwake, IDestroy
    {
        public Dictionary<string, long> PlayerIpNumber = new Dictionary<string, long>();    
    }
}
