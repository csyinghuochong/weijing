namespace ET
{
    public class MapComponent : Entity, ITransfer, IAwake
    {
        public int SceneTypeEnum;
        public int SceneId;
        public int SonSceneId;
        public string NavMeshId;

        public bool OldNavMesh = true;
    }
}
