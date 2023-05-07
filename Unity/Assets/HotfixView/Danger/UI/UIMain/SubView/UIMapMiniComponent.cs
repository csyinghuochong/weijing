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
        public int Lab_TimeIndex = 0;
        public GameObject Lab_Time;
        public GameObject GameObject;
        public GameObject Lab_TianQi;
        public GameObject Lab_MapName;
        public GameObject MiniMapButton;
        public GameObject RawImage;
        public GameObject MainCityShow;
        public GameObject HeadList;
        public GameObject HeadItem;


        public GameObject MapCamera;
        public float ScaleRateX;
        public float ScaleRateY;
        public int SceneId;
        public long Timer;

        public List<GameObject> AllPointList = new List<GameObject>();
        public Vector3 NoVector3 = new Vector3(-10000, -10000, 0);
    }

    public class UIMapMiniComponentDestroySystem : DestroySystem<UIMapMiniComponent>
    {
        public override void Destroy(UIMapMiniComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }


    public class UIMapMiniComponentAwakeSystem : AwakeSystem<UIMapMiniComponent, GameObject>
    {
        public override void Awake(UIMapMiniComponent self, GameObject a)
        {
            self.GameObject = a;
            self.AllPointList.Clear();
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Lab_Time = rc.Get<GameObject>("Lab_Time");
            self.Lab_MapName = rc.Get<GameObject>("Lab_MapName");
            self.Lab_TianQi = rc.Get<GameObject>("Lab_TianQi");
            self.MiniMapButton = rc.Get<GameObject>("MiniMapButton");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.MainCityShow = rc.Get<GameObject>("MainCityShow");
            self.HeadList = rc.Get<GameObject>("HeadList");
            self.HeadItem = rc.Get<GameObject>("HeadItem");
            self.HeadItem.SetActive(false);
            self.HeadList.SetActive(false);
        }
    }

    public static class UIMapMiniComponentSystem
    {

        public static void UpdateTianQi(this UIMapMiniComponent self, string tianqi)
        {
            switch (tianqi)
            {
                case "1":
                    self.Lab_TianQi.GetComponent<Text>().text = "晴";
                    break;
                case "2":
                    self.Lab_TianQi.GetComponent<Text>().text = "雨";
                    break;
                default:
                    self.Lab_TianQi.GetComponent<Text>().text = "晴";
                    break;
            }
        }

        public static void OnMainHeroMove(this UIMapMiniComponent self)
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
            int selfCamp_1 = main.GetBattleCamp();
            for (int i = 0; i < allUnit.Count; i++)
            {
                Unit unit = allUnit[i];
                if (unit.Type != UnitType.Player && unit.Type!=UnitType.Monster)
                {
                    continue;
                }

                Vector3 vector31 = new Vector3(unit.Position.x, unit.Position.z, 0f);
                Vector3 vector32 = self.GetWordToUIPositon(vector31);
                GameObject headItem = self.GetTeamPointObj(teamNumber);

                //1自己 2敌对 3队友  4主城
                string showType ="4";
                if (main.IsCanAttackUnit(unit))
                {
                    showType = "2";
                }
                if (main.IsSameTeam(unit))
                {
                    showType = "3";
                }
                if (unit.MainHero)
                {
                    showType = "1";
                }

                teamNumber++;
                headItem.transform.Find("1").gameObject.SetActive(showType == "1");
                headItem.transform.Find("2").gameObject.SetActive(showType == "2");
                headItem.transform.Find("3").gameObject.SetActive(showType == "3");
                headItem.transform.Find("4").gameObject.SetActive(showType == "4");
                headItem.transform.localPosition = new Vector2(vector32.x, vector32.y);
            }

            for (int i = teamNumber; i < self.AllPointList.Count; i++)
            {
                self.AllPointList[i].transform.localPosition = self.NoVector3;
            }

            self.Lab_TimeIndex++;
            if (self.Lab_TimeIndex >= 300)
            {
                self.Lab_TimeIndex = 0;
                DateTime serverTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                self.Lab_Time.GetComponent<Text>().text = $"{serverTime.Hour}:{serverTime.Minute}";
            }
        }

        public static GameObject GetTeamPointObj(this UIMapMiniComponent self, int index)
        {
            if (self.AllPointList.Count > index)
            {
                return self.AllPointList[index];
            }
            GameObject go = GameObject.Instantiate(self.HeadItem);
            go.transform.SetParent(self.HeadItem.transform.parent);
            go.transform.localScale = Vector3.one;
            go.SetActive(true);
            self.AllPointList.Add(go);
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
            if(SceneConfigHelper.UseSceneConfig(mapComponent.SceneTypeEnum)
               && SceneConfigHelper.ShowMiniMap(mapComponent.SceneTypeEnum, mapComponent.SceneId))
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

            self.OnMainHeroMove();
        }

        public static void BeginChangeScene(this UIMapMiniComponent self, int lastScene)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void ShowMapName(this UIMapMiniComponent self, string mapname)
        {
            self.Lab_MapName.GetComponent<Text>().text = mapname;
        }

        public static void OnEnterScene(this UIMapMiniComponent self)
        {
            self.LoadMapCamera().Coroutine();

            int sceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            int difficulty = self.ZoneScene().GetComponent<MapComponent>().FubenDifficulty;
            int sceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            self.MainCityShow.SetActive(true);

            //显示地图名称
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.CellDungeon:
                    self.Lab_MapName.GetComponent<Text>().text = ChapterConfigCategory.Instance.Get(sceneId).ChapterName;
                    break;
                case (int)SceneTypeEnum.LocalDungeon:
                    string str = "";
                    if (difficulty == FubenDifficulty.Normal)
                    {
                        str = "(普通)";
                    }
                    if (difficulty == FubenDifficulty.TiaoZhan)
                    {
                        str = "(挑战)";
                    }
                    if (difficulty == FubenDifficulty.DiYu)
                    {
                        str = "(地狱)";
                    }
                    self.Lab_MapName.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(sceneId).ChapterName + str;
                    break;
                case (int)SceneTypeEnum.TeamDungeon:
                    str = "";
                    if (difficulty == TeamFubenType.XieZhu)
                    {
                        str = "(协助)";
                    }
                    if (difficulty == TeamFubenType.ShenYuan)
                    {
                        str = "(深渊)";
                    }
                    self.Lab_MapName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(sceneId).Name + str;
                    break;
                default:
                    //显示地图名称
                    self.Lab_MapName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(sceneId).Name;
                    break;
            }

            self.HeadList.SetActive(true);
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(200, TimerType.MapMiniTimer, self);

            DateTime serverTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
            self.Lab_Time.GetComponent<Text>().text = $"{serverTime.Hour}:{serverTime.Minute}";
        }
    }
}
