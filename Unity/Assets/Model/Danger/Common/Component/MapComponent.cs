namespace ET
{
    public class MapComponent : Entity, ITransfer, IAwake
    {
        public int SceneTypeEnum;
        public int SceneId;
        public int SonSceneId;
        public string NavMeshId;
        public long LastQuitTime = 0;
        public bool OldNavMesh = true;
        public int FubenDifficulty = 0;
    }
}
