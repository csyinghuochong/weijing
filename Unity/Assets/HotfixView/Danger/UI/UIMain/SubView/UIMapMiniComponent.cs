using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    
    [Timer(TimerType.MapMiniTimer)]
    public class MapMiniTimer : ATimer<UIMapMiniComponent>
    {
        public override void Run(UIMapMiniComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIMapMiniComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;

        public GameObject Lab_MapName;
        public GameObject MiniMapButton;
        public GameObject RawImage;
        public GameObject MainCityShow;
        public GameObject HeadList;
        public GameObject HeadSelf;
        public GameObject Teammer;
        public GameObject Enemyer;

        public GameObject MapCamera;
        public float ScaleRateX;
        public float ScaleRateY;
        public int SceneId;
        public long Timer;

        public List<GameObject> TeamPointList = new List<GameObject>();
        public List<GameObject> EnemyPointList = new List<GameObject>();

        public Vector3 NoVector3 = new Vector3(-2000, -2000, 0);
    }

    [ObjectSystem]
    public class UIMapMiniComponentDestroySystem : DestroySystem<UIMapMiniComponent>
    {
        public override void Destroy(UIMapMiniComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.MainHeroMove, self);
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UIMapMiniComponentAwakeSystem : AwakeSystem<UIMapMiniComponent, GameObject>
    {
        public override void Awake(UIMapMiniComponent self, GameObject a)
        {
            self.GameObject = a;
            self.TeamPointList.Clear();
            self.EnemyPointList.Clear();
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Lab_MapName = rc.Get<GameObject>("Lab_MapName");
            self.MiniMapButton = rc.Get<GameObject>("MiniMapButton");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.MainCityShow = rc.Get<GameObject>("MainCityShow");
            self.HeadList = rc.Get<GameObject>("HeadList");
            self.HeadSelf = rc.Get<GameObject>("HeadSelf");
            self.Teammer = rc.Get<GameObject>("Teammer");
            self.Enemyer = rc.Get<GameObject>("Enemyer");
            self.Teammer.SetActive(false);
            self.Enemyer.SetActive(false);
            self.HeadList.SetActive(false);

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
            self.HeadList.transform.localPosition = new Vector2(localPosition.x * -1, localPosition.y * -1);
        }

        public static void OnUpdate(this UIMapMiniComponent self)
        {
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<Unit> allUnit = main.GetParent<UnitComponent>().GetAll();

            int teamNumber = 0;
            int enemNumber = 0;
            int selfCamp_1 = main.GetBattleCamp();
            for (int i = 0; i < allUnit.Count; i++)
            {
                Unit unit = allUnit[i];
                if (unit.Type != UnitType.Player)
                {
                    continue;
                }

                Vector3 vector31 = new Vector3(unit.Position.x, unit.Position.z, 0f);
                Vector3 vector32 = self.GetWordToUIPositon(vector31);
                GameObject headItem = null;
                if (unit.MainHero)
                {
                    headItem = self.HeadSelf;
                }
                else if (selfCamp_1 == unit.GetBattleCamp())
                {
                    headItem = self.GetTeamPointObj(teamNumber);
                    teamNumber++;
                }
                else
                {
                    headItem = self.GetEnemyPointObj(enemNumber);
                    enemNumber++;
                }
                
                headItem.transform.localPosition = new Vector2(vector32.x, vector32.y);
            }

            for (int i = teamNumber; i < self.TeamPointList.Count; i++)
            {
                self.TeamPointList[i].transform.localPosition = self.NoVector3;
            }
            for (int i = enemNumber; i < self.EnemyPointList.Count; i++)
            {
                self.EnemyPointList[i].transform.localPosition = self.NoVector3;
            }
        }

        public static GameObject GetTeamPointObj(this UIMapMiniComponent self, int index)
        {
            if (self.TeamPointList.Count > index)
            {
                return self.TeamPointList[index];
            }
            GameObject go = GameObject.Instantiate(self.Teammer);
            go.transform.SetParent(self.Teammer.transform.parent);
            go.transform.localScale = Vector3.one;
            go.SetActive(true);
            self.TeamPointList.Add(go);
            return go;
        }

        public static GameObject GetEnemyPointObj(this UIMapMiniComponent self, int index)
        {
            if (self.EnemyPointList.Count > index)
            {
                return self.EnemyPointList[index];
            }
            GameObject go = GameObject.Instantiate(self.Enemyer);
            go.transform.SetParent(self.Enemyer.transform.parent);
            go.transform.localScale = Vector3.one;
            go.SetActive(true);
            self.EnemyPointList.Add(go);
            return go;
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

        public static void BeginChangeScene(this UIMapMiniComponent self, int lastScene)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
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

            self.HeadList.SetActive(true);
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(200, TimerType.MapMiniTimer, self);
        }
    }
}
