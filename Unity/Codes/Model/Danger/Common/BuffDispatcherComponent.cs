
using System;
using System.Collections.Generic;

namespace ET
{
    public class BuffDispatcherComponent : Entity, IAwake, ILoad, IDestroy
    {
        public static BuffDispatcherComponent Instance;

        public Dictionary<string, Type> BuffTypes = new Dictionary<string, Type>();
    }
}
