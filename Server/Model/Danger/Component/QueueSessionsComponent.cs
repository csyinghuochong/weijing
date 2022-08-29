using System.Collections.Generic;

namespace ET
{
    public class QueueSessionsComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<long, long> QueueSessionsDictionary = new Dictionary<long, long>();
        public Dictionary<long, string> QueueTokenDictionary = new Dictionary<long, string>();
    }
}
