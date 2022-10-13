using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIMapBigComponent : Entity, IAwake, IDestroy
    {
        public int SceneId = 1;
        public float ScaleRateX = 1f;
        public float ScaleRateY = 1f;
        public Vector2 localPoint;
        public GameObject MapName;
        public GameObject bossIcon;
        public GameObject chuansong;
        public GameObject ChuanSongName;
        public GameObject TextStall;
        public GameObject RawImage;
        public GameObject Btn_Close;
        public GameObject MainPostion;
        public GameObject NpcPostion;
        public GameObject pathPoint;
        public GameObject NpcNodeList;
        public GameObject ImageSelect;
        public GameObject MapCamera;

        public MoveComponent MoveComponent;
        public List<GameObject> PathPointList = new List<GameObject>();
        public Dictionary<int, GameObject> NpcGameObject = new Dictionary<int, GameObject>();
    }

    [ObjectSystem]
    public class UIMapBigComponentDestroySystem : DestroySystem<UIMapBigComponent>
    {
        public override void Destroy(UIMapBigComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.MainHeroPosition, self);
        }
    }


    [ObjectSystem]
    public class UIMapBigComponentAwakeSystem : AwakeSystem<UIMapBigComponent>
    {

        public override void Awake(UIMapBigComponent self)
        {
            self.PathPointList.Clear();
            self.NpcGameObject.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextStall = rc.Get<GameObject>("TextStall");
            self.TextStall.SetActive(false);
            self.chuansong = rc.Get<GameObject>("chuansong");
            self.ChuanSongName = rc.Get<GameObject>("ChuanSongName");
            self.chuansong.SetActive(false);
            self.MapName = rc.Get<GameObject>("MapName");
            self.bossIcon = rc.Get<GameObject>("bossIcon");
            self.bossIcon.SetActive(false);

            self.NpcNodeList = rc.Get<GameObject>("NpcNodeList");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageSelect.SetActive(false);

            self.MainPostion = rc.Get<GameObject>("mainPostion");
            self.NpcPostion = rc.Get<GameObject>("npcPostion");
            self.pathPoint = rc.Get<GameObject>("pathPoint");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseMiniMap(); });

            ButtonHelp.AddEventTriggers(self.RawImage, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);

            self.MoveComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<MoveComponent>();

            self.OnAwake().Coroutine();
            self.InitNpcList().Coroutine();

            DataUpdateComponent.Instance.AddListener(DataType.MainHeroPosition, self);
        }
    }

    public static class UIMapBigComponentSystem
    {
        public static async ETTask OnAwake(this UIMapBigComponent self)
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
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.MainCityScene
                || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
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

            self.OnChangePosition();
            self.MainPostion.transform.Find("Text").GetComponent<Text>().text = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Name;

            await TimerComponent.Instance.WaitAsync(200);
            camera.enabled = false;
        }

        public static void ShowStallArea(this UIMapBigComponent self)
        {
            int[] stallArea = SceneConfigCategory.Instance.Get(self.SceneId).StallArea;
            if (stallArea != null && stallArea.Length == 4 && self.NpcPostion != null)
            {
                Vector3 stallPosition = new Vector3(stallArea[0] * 0.01f * self.ScaleRateX, stallArea[2] * 0.01f * self.ScaleRateY, 0);
                self.TextStall.SetActive(true);
                self.TextStall.transform.SetParent(self.NpcPostion.transform.parent);
                self.TextStall.transform.localPosition = stallPosition;
            }
        }

        public static void ShowChuansong(this UIMapBigComponent self)
        {
            int[] transfers = DungeonConfigCategory.Instance.Get(self.SceneId).TransmitPos;
            if (transfers == null || transfers.Length == 0)
            {
                return;
            }
            for (int i = 0; i < transfers.Length; i++)
            {
                if (transfers[i] == 0)
                {
                    continue;
                }
                DungeonTransferConfig npcConfig = DungeonTransferConfigCategory.Instance.Get(transfers[i]);
                Vector3 npcPos = self.GetWordToUIPositon(new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[2] * 0.01f, 0));

                GameObject gameObject = GameObject.Instantiate(self.chuansong);
                gameObject.SetActive(true);
                gameObject.transform.SetParent(self.chuansong.transform.parent);
                gameObject.transform.localScale = Vector3.one;
                gameObject.transform.localPosition = npcPos;
                gameObject.transform.Find("Text").GetComponent<Text>().text = npcConfig.Name;
            }
        }

        public static void ShowBossList(this UIMapBigComponent self)
        {
            DungeonConfig chapterSonConfig = DungeonConfigCategory.Instance.Get(self.SceneId);
            self.CreateMonsterList(chapterSonConfig.CreateMonster);

            if (chapterSonConfig.MonsterGroup != 0)
            {
                MonsterGroupConfig monsterGroupConfig = MonsterGroupConfigCategory.Instance.Get(chapterSonConfig.MonsterGroup);
                self.CreateMonsterList(monsterGroupConfig.CreateMonster);
            }
        }

        public static void CreateMonsterList(this UIMapBigComponent self, string createMonster)
        {
            string[] monsters = createMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] == "0")
                {
                    continue;
                }
                //1;37.65,0,3.2;70005005;1
                string[] mondels = monsters[i].Split(';');
                string[] mtype = mondels[0].Split(',');
                string[] position = mondels[1].Split(',');
                string[] monsterid = mondels[2].Split(',');
                string[] mcount = mondels[3].Split(',');

                if (mtype[0] != "1" && mtype[0] != "2")   
                {
                    continue;
                }
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(int.Parse(monsterid[0]));
                if (monsterConfig.MonsterType != (int)MonsterTypeEnum.Boss)
                {
                    continue;
                }
                Vector3 vector3 = new Vector3(float.Parse(position[0]),  float.Parse(position[2]), 0);
                Vector3 npcPos = self.GetWordToUIPositon(vector3);

                GameObject gameObject = GameObject.Instantiate(self.bossIcon);
                gameObject.SetActive(true);
                gameObject.transform.SetParent(self.bossIcon.transform.parent);
                gameObject.transform.localScale = Vector3.one;
                gameObject.transform.localPosition = npcPos;
                gameObject.transform.Find("Text").GetComponent<Text>().text = monsterConfig.MonsterName;
            }
        }

        public static async ETTask InitNpcList(this UIMapBigComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            int[] npcList = null;

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.MainCityScene)
            {
                npcList = SceneConfigCategory.Instance.Get(self.SceneId).NpcList;
                self.MapName.GetComponent<Text>().text = SceneConfigCategory.Instance.Get(self.SceneId).Name;
                self.ShowStallArea();
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                npcList = DungeonConfigCategory.Instance.Get(self.SceneId).NpcList;
                self.MapName.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(self.SceneId).ChapterName;
                self.ShowChuansong();
                self.ShowBossList();
            }

            if (npcList == null)
            {
                return;
            }
            var path = ABPathHelper.GetUGUIPath("Main/MiniMap/UIMapBigNpcItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject mapCamera = self.MapCamera;
            for (int i = 0; i < npcList.Length; i++)
            {
                if (!NpcConfigCategory.Instance.Contain(npcList[i]))
                {
                    Log.ILog.Debug($"找不到npcid {npcList[i]}");
                    continue;
                }
                NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcList[i]);
                Vector3 npcPos = Vector3.zero;

                npcPos = self.GetWordToUIPositon(new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[2] * 0.01f, 0));

                GameObject gameObject = GameObject.Instantiate(self.NpcPostion);
                gameObject.SetActive(true);
                gameObject.transform.SetParent(self.NpcPostion.transform.parent);
                gameObject.transform.localScale = Vector3.one;
                gameObject.transform.localPosition = npcPos;

                gameObject.transform.Find("Text").GetComponent<Text>().text = npcConfig.Name;

                GameObject npcGo = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(npcGo, self.NpcNodeList);
                UI uI = self.AddChild<UI, string, GameObject>( "IMapBigNpcItem", npcGo);
                UIMapBigNpcItemComponent uIItemComponent = uI.AddComponent<UIMapBigNpcItemComponent>();
                uIItemComponent.SetClickHandler(npcList[i], (int npcid) => { self.OnClickNpcItem(npcid); });
                self.NpcGameObject.Add(npcList[i], npcGo);
            }
        }

        public static void OnClickNpcItem(this UIMapBigComponent self, int npcid)
        {
            self.ImageSelect.SetActive(true);
            UICommonHelper.SetParent(self.ImageSelect, self.NpcGameObject[npcid]);
            self.ImageSelect.transform.SetSiblingIndex(0);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!unit.GetComponent<StateComponent>().CanMove())
                return;

            self.ZoneScene().CurrentScene().GetComponent<OperaComponent>().OnClickNpc(npcid);
        }

        public static void PointerDown(this UIMapBigComponent self, PointerEventData pdata)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            GameObject mapCamera = self.MapCamera;
            RectTransform canvas = self.RawImage.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.localPoint);

            Quaternion rotation = Quaternion.Euler(0,  mapCamera.transform.eulerAngles.y, 0);
          
            Vector3 wordpos = new Vector3(self.localPoint.x / self.ScaleRateX, 100f, self.localPoint.y / self.ScaleRateY);
            wordpos = rotation * wordpos;

            wordpos.x += (mapCamera.transform.position.x);
            wordpos.z += (mapCamera.transform.position.z );

            RaycastHit hit;
            int mapMask = (1 << LayerMask.NameToLayer(LayerEnum.Map.ToString()));
            Physics.Raycast(wordpos, Vector3.down, out hit, 1000, mapMask);

            if (hit.collider != null)
            {
                UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                uI.GetComponent<UIMainComponent>().OnMoveStart();
                unit.MoveToAsync2(hit.point, false).Coroutine();
            }
        }

        public static Vector3 GetWordToUIPositon(this UIMapBigComponent self, Vector3 vector3)
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

        public static void OnCloseMiniMap(this UIMapBigComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIMapBig);
        }

        public static void OnChangePosition(this UIMapBigComponent self)
        {
            Vector3 vector3 = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).Position;
            Vector3 vector31 = new Vector3(vector3.x, vector3.z, 0f);
            self.MainPostion.transform.localPosition = self.GetWordToUIPositon(vector31);

            self.UpdatePathPoint();
        }

        public static GameObject GetPathPointObj(this UIMapBigComponent self, int index)
        {
            if (self.PathPointList.Count > index)
            {
                return self.PathPointList[index];
            }
            GameObject go = GameObject.Instantiate(self.pathPoint);
            go.transform.SetParent(self.pathPoint.transform.parent);
            go.transform.localScale = Vector3.one;
            self.PathPointList.Add(go);
            return go;
        }

        public static void UpdatePathPoint(this UIMapBigComponent self)
        {
            int N = self.MoveComponent.N;
            List<Vector3> target = self.MoveComponent.Targets;
            Vector3 lastVector = new Vector3(-1000,-1000,0);
            int showNumber = 0;
            for (int i = target.Count - 1; i >= N; i--)
            {
                Vector3 temp = target[i];
                Vector3 vector31 = new Vector3(temp.x, temp.z, 0f);
                vector31 = self.GetWordToUIPositon(vector31);

                if (Vector3.Distance(vector31, lastVector) > 20f)
                {
                    GameObject go = self.GetPathPointObj(showNumber);
                    showNumber++;
                    go.SetActive(true);
                    go.transform.localPosition = vector31;
                    go.transform.localScale = Vector3.one * 2f;
                    lastVector = vector31;
                }
            }
            for (int i = showNumber; i < self.PathPointList.Count; i++)
            {
                self.PathPointList[i].SetActive(false);
            }
        }

    }
}