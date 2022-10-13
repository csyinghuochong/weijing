using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMapMiniComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;

        public GameObject Lab_MapName;
        public GameObject MiniMapButton;
        public GameObject RawImage;
        public GameObject MainCityShow;
    }

    [ObjectSystem]
    public class UIMapMiniComponentAwakeSystem : AwakeSystem<UIMapMiniComponent, GameObject>
    {
        public override void Awake(UIMapMiniComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Lab_MapName = rc.Get<GameObject>("Lab_MapName");
            self.MiniMapButton = rc.Get<GameObject>("MiniMapButton");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.MainCityShow = rc.Get<GameObject>("MainCityShow");
        }
    }

    public static class UIMapMiniComponentSystem
    {
        public static void OnEnterScene(this UIMapMiniComponent self, int sceneType)
        {
            self.MainCityShow.SetActive(UICommonHelper.ShowBigMap((int)sceneType));

            int sceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            int sceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            //显示地图名称
            if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                //显示地图名称
                self.Lab_MapName.GetComponent<Text>().text = ChapterConfigCategory.Instance.Get(sceneId).ChapterName;
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.MainCityScene
                || sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon
                || sceneTypeEnum == (int)SceneTypeEnum.YeWaiScene
                || sceneTypeEnum == (int)SceneTypeEnum.Tower)
            {
                //显示地图名称
                self.Lab_MapName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(sceneId).Name;
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                self.Lab_MapName.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(sceneId).ChapterName;
            }
        }
    }
}
