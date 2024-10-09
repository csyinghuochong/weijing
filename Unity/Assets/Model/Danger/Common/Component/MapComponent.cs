using System.Collections.Generic;

namespace ET
{
    public class MapComponent : Entity, ITransfer, IAwake, IDestroy
    {
        public int SceneId;
        public int SonSceneId;
        public int NavMeshId;
        public int SceneTypeEnum;
        public long LastQuitTime = 0;
        public bool OldNavMesh = true;
        public int FubenDifficulty = 0;

#if SERVER
        public long Timer;
        public Dictionary<long, M2C_PathfindingRequest> MoveMessageList = new Dictionary<long, M2C_PathfindingRequest>();

        //临时
        public long num;
        public long timechar;
        public long messagelenght;

#endif
    }
}
