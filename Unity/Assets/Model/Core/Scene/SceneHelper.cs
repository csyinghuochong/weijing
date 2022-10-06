namespace ET
{
    public static class SceneHelper
    {
        public static int DomainZone(this Entity entity)
        {
            return ((Scene) entity.Domain)?.Zone ?? 0;
        }

        public static Scene DomainScene(this Entity entity)
        {
            return (Scene) entity.Domain;
        }

        public static int GetSceneId(this Entity entity)
        {
            Scene scene = entity as Scene;
            if (!scene.Name.Contains("Map"))
            {
                return 0;
            }
            string map = scene.Name.Substring(3, scene.Name.Length - 3);
            int sceneId = int.Parse(map);
            return sceneId;
        }
    }
}