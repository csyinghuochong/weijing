using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMapMiniComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;

        public GameObject Lab_MapName;
        public GameObject MiniMapButton;
        public GameObject RawImage;
        public GameObject MainCityShow;

        public GameObject MapCamera;
        public int SceneId;
        public float ScaleRateX;
        public float ScaleRateY;
    }

    [ObjectSystem]
    public class UIMapMiniComponentDestroySystem : DestroySystem<UIMapMiniComponent>
    {
        public override void Destroy(UIMapMiniComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.MainHeroMove, self);
        }
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

            DataUpdateComponent.Instance.AddListener(DataType.MainHeroMove, self);
        }
    }

    public static class UIMapMiniComponentSystem
    {
        public static void OnMainHeroPosition(this UIMapMiniComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit == null || self.MapCamera == null)
            {
                return;
            }
            Vector3 vector3 = unit.Position;
            Vector3 vector31 = new Vector3(vector3.x, vector3.z, 0f);
            Vector2 localPosition = self.GetWordToUIPositon(vector31);
            self.RawImage.transform.localPosition = new Vector2(localPosition.x * -1, localPosition.y * -1);
        }

        public static Vector3 GetWordToUIPositon(this UIMapMiniComponent self, Vector3 vector3)
        {
            GameObject mapCamera = self.MapCamera;
            vector3.x -= mapCamera.transform.position.x;
            vector3.y -= mapCamera.transform.position.z;

            Quaternion rotation = Quaternion.Euler(0, 0, 1 * mapCamera.transform.eulerAngles.y);
            vector3 = rotation * vector3;

            vector3.x *= self.ScaleRateX;
            vector3.y *= self.ScaleRateY;
            return vector3;
        }

        public static async ETTask LoadMapCamera(this UIMapMiniComponent self)
        {
            GameObject mapCamera = GameObject.Find("MapCamera");
            if (mapCamera == null)
            {
                var path = ABPathHelper.GetUnitPath("Component/MapCamera");
                GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                mapCamera = GameObject.Instantiate(prefab);
                mapCamera.name = "MapCamera";
            }
            Camera camera = mapCamera.GetComponent<Camera>();
            camera.enabled = true;

            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(mapComponent.SceneId);
                mapCamera.transform.position = new Vector3((float)dungeonConfig.CameraPos[0], (float)dungeonConfig.CameraPos[1], (float)dungeonConfig.CameraPos[2]);
                mapCamera.transform.eulerAngles = new Vector3(90, 0, (float)dungeonConfig.CameraPos[3]);
                camera.orthographicSize = (float)dungeonConfig.CameraPos[4];
            }
            if(mapComponent.SceneTypeEnum == SceneTypeEnum.MainCityScene
                 || mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon
                 || mapComponent.SceneTypeEnum == SceneTypeEnum.YeWaiScene
                 || mapComponent.SceneTypeEnum == SceneTypeEnum.Tower
                 || mapComponent.SceneTypeEnum == SceneTypeEnum.Battle)
            {
                SceneConfig dungeonConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
                mapCamera.transform.position = new Vector3((float)dungeonConfig.CameraPos[0], (float)dungeonConfig.CameraPos[1], (float)dungeonConfig.CameraPos[2]);
                mapCamera.transform.eulerAngles = new Vector3(90, 0, (float)dungeonConfig.CameraPos[3]);
                camera.orthographicSize = (float)dungeonConfig.CameraPos[4];
            }
            self.MapCamera = mapCamera;

            self.SceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            self.ScaleRateX = self.RawImage.GetComponent<RectTransform>().rect.height / (camera.orthographicSize * 2);
            self.ScaleRateY = self.RawImage.GetComponent<RectTransform>().rect.height / (camera.orthographicSize * 2);
            self.RawImage.transform.localPosition = Vector2.zero;
            await TimerComponent.Instance.WaitAsync(200);
            camera.enabled = false;

            self.OnMainHeroPosition();
        }

        public static void OnEnterScene(this UIMapMiniComponent self, int sceneType)
        {
            self.LoadMapCamera().Coroutine();

            self.MainCityShow.SetActive(UICommonHelper.ShowBigMap((int)sceneType));

            int sceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            int sceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            //显示地图名称
            if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                //显示地图名称
                self.Lab_MapName.GetComponent<Text>().text = ChapterConfigCategory.Instance.Get(sceneId).ChapterName;
            }
            else if (sceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                self.Lab_MapName.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(sceneId).ChapterName;
            }
            else
            {
                //显示地图名称
                self.Lab_MapName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(sceneId).Name;
            }
        }
    }
}
