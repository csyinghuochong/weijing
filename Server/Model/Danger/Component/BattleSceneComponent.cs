using System.Collections.Generic;

namespace ET
{
    public class BattleInfo : Entity, IAwake
    {
        public long FubenInstanceId = 0;
        public int PlayerNumber = 0;
    }

    public class BattleSceneComponent : Entity, IAwake, IDestroy
    {
        public List<BattleInfo> BattleInfos = new List<BattleInfo>();
    }
}
