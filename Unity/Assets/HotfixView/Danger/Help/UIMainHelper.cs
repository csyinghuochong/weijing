using UnityEngine;

namespace ET
{
    public static class UIMainHelper
    {
        public static bool ShowRightTopButton(int sceneType)
        {
            return sceneType != SceneTypeEnum.Battle && sceneType != SceneTypeEnum.TrialDungeon;
        }

        public static bool UseSceneConfig(int sceneType)
        {
            return sceneType == SceneTypeEnum.MainCityScene
                 || sceneType == SceneTypeEnum.PetTianTi
                 || sceneType == SceneTypeEnum.PetDungeon
                 || sceneType == SceneTypeEnum.TeamDungeon
                 || sceneType == SceneTypeEnum.YeWaiScene
                 || sceneType == SceneTypeEnum.Tower
                 || sceneType == SceneTypeEnum.Battle
                 || sceneType == SceneTypeEnum.TrialDungeon;
        }

        public static bool ShowMiniMap(int sceneType)
        {
            return sceneType == SceneTypeEnum.MainCityScene
                 || sceneType == SceneTypeEnum.LocalDungeon
                 || sceneType == SceneTypeEnum.TeamDungeon
                 || sceneType == SceneTypeEnum.YeWaiScene
                 || sceneType == SceneTypeEnum.Tower
                 || sceneType == SceneTypeEnum.Battle
                 || sceneType == SceneTypeEnum.TrialDungeon;
        }
    }
}
