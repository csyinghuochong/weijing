using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class EffectViewComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public List<AEffectHandler> Effects = new List<AEffectHandler>();
    }

}
