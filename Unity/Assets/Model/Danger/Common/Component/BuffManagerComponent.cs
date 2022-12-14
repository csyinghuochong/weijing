using System.Collections.Generic;

namespace ET
{
    public class BuffManagerComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public int Type;
        
#if !SERVER
        public List<ABuffHandler> m_Buffs = new List<ABuffHandler>();
#else
        public List<BuffHandler> m_Buffs = new List<BuffHandler>();
        public readonly M2C_UnitBuffUpdate m2C_UnitBuffUpdate = new M2C_UnitBuffUpdate();
#endif

    }
}
