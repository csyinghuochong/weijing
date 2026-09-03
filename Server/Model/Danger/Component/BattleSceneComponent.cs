using System.Collections.Generic;

namespace ET
{
    public class BattleInfo : Entity, IAwake
    {
        public int SceneId = 0;
        public long FubenId = 0;
        public int PlayerNumber = 0;
        public long ProgressId = 0;
        public long FubenInstanceId = 0;

        public List<long> Camp1Player = new List<long>();
        public List<long> Camp2Player = new List<long>();
    }

    public class BattleSceneComponent : Entity, IAwake, IDestroy
    {
        public bool BattleOpen;
        /// <summary>本轮已通知过机器人的战场 SceneId（每种图只拉一次）</summary>
        public HashSet<int> RobotBattleOpenNotifiedScenes = new HashSet<int>();
        public List<BattleInfo> BattleInfos = new List<BattleInfo>();
    }
}
