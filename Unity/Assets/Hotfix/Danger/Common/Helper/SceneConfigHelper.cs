using UnityEngine;

namespace ET
{
    public static class SceneConfigHelper
    {
        public static bool ShowRightTopButton(int sceneType)
        {
            return sceneType != SceneTypeEnum.Battle 
                && sceneType != SceneTypeEnum.TrialDungeon
                && sceneType != SceneTypeEnum.Tower;
        }

        public static bool ShowLeftButton(int sceneType)
        {
            return sceneType != SceneTypeEnum.TrialDungeon
                && sceneType != SceneTypeEnum.MiJing;
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
