using System;
using System.Collections.Generic;

namespace ET
{
    public class FsmDispatchComponent : Entity, IAwake, ILoad,IDestroy
    {

        public static FsmDispatchComponent Instance;

        public Dictionary<int, Type> FsmTypes = new Dictionary<int, Type>();

    }
}
