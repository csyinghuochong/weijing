using System.Collections.Generic;

namespace ET
{
    public class BehaviourDispatcherComponent : Entity, IAwake, IDestroy, ILoad
    {
        public static BehaviourDispatcherComponent Instance;
        public Dictionary<string, BehaviourHandler> AIHandlers = new Dictionary<string, BehaviourHandler>();
    }
}
