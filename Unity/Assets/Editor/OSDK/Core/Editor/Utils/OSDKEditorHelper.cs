using UnityEditor;
using UnityEngine.SceneManagement;

namespace Douyin.Game
{
    public static class OSDKEditorHelper
    {
        private const string DEMO_SCENE_NAME = "OSDKDemo";

        // 检测当前构建场景为demo场景
        public static bool IsBuildDemoScene()
        {
            if (EditorBuildSettings.scenes.Length == 0)
            {
                return false;
            }

            var scene = EditorBuildSettings.scenes[0];
            if (scene.path.Contains(DEMO_SCENE_NAME) && scene.enabled)
            {
                return true;
            }

            return false;
        }
    }
}