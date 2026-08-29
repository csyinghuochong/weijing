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
        /// <summary>本轮战场开启后是否已通知过本区机器人（首个战场 Scene 创建时通知）</summary>
        public bool RobotBattleOpenNotified;
        public List<BattleInfo> BattleInfos = new List<BattleInfo>();
    }
}
