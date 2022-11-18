using UnityEngine;

namespace ET
{
    public static class SceneConfigHelper
    {
        public static bool ShowRightTopButton(int sceneType)
        {
            return sceneType != SceneTypeEnum.Battle && sceneType != SceneTypeEnum.TrialDungeon;
        }

        public static bool UseSceneConfig(int sceneType)
        {
            return sceneType != SceneTypeEnum.LocalDungeon
                 && sceneType != SceneTypeEnum.CellDungeon;
        }

        public static bool IfCanRevive(int sceneType, int sceneId)
        {
            if (!UseSceneConfig(sceneType))
            {
                return true;
            }
            return SceneConfigCategory.Instance.Get(sceneId).IfUseRes == 0;
        }

        public static bool ShowMiniMap(int sceneType, int sceneId)
        {
            if (!UseSceneConfig(sceneType))
            {
                return true;
            }
            return SceneConfigCategory.Instance.Get(sceneId).ifShowMinMap == 1;
        }
    }
}
