using System.Collections.Generic;

namespace ET
{
    public class MiJingComponent : Entity, IAwake, IDestroy
    {
        public int BossId;
        public long LastTime;
        public List<TeamPlayerInfo> PlayerDamageList = new List<TeamPlayerInfo>();
        public M2C_SyncMiJingDamage M2C_SyncMiJingDamage = new M2C_SyncMiJingDamage();
    }
}
