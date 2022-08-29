
using System;
using System.Collections.Generic;

namespace ET
{
    public class EffectDispatcherComponent : Entity, IAwake, ILoad, IDestroy
    {
        public static EffectDispatcherComponent Instance;

        public Dictionary<string, Type> EffectTypes = new Dictionary<string, Type>();
        public List<AEffectHandler> EffectHandlers = new List<AEffectHandler>();

    }
}
