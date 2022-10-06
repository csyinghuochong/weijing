using System.Collections.Generic;

namespace ET
{
    public class BuffManagerComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        
#if !SERVER
        public List<ABuffHandler> m_Buffs = new List<ABuffHandler>();
#else
        public List<BuffHandler> m_Buffs = new List<BuffHandler>();
        public List<KeyValuePair> Buffs = new List<KeyValuePair>();
        public readonly M2C_UnitBuffUpdate m2C_UnitBuffUpdate = new M2C_UnitBuffUpdate();
#endif

    }
}
