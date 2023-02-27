using System.Collections.Generic;

namespace ET
{
    public class BattleInfo : Entity, IAwake
    {
        public long FubenId = 0;
        public long FubenInstanceId = 0;
        public int PlayerNumber = 0;
        public int SceneId = 0;

        public List<long> Camp1Player = new List<long>();
        public List<long> Camp2Player = new List<long>();
    }

    public class BattleSceneComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public int BattleSceneStatu;
        public List<BattleInfo> BattleInfos = new List<BattleInfo>();
    }
}
