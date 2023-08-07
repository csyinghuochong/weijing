using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIFashionSuitComponent : Entity, IAwake
    {
        public GameObject RawImage;
        public GameObject Btn_Suit_1;
        public GameObject BuildingList;

        public UIModelShowComponent UIModelShowComponent;

        public Dictionary<int, GameObject> ButtonList = new Dictionary<int, GameObject>();
        public List<UIFashionSuitItemComponent> FashionSuitList = new List<UIFashionSuitItemComponent> { };
    }

    public class UIFashionSuitComponentAwake : AwakeSystem<UIFashionSuitComponent >
    {
        public override void Awake(UIFashionSuitComponent self)
        {
            self.ButtonList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.Btn_Suit_1 = rc.Get<GameObject>("Btn_Suit_1");
            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.RawImage.SetActive(true);
            self.OnInitModelShow();

            self.OnInitUI();
        }
    }

    public static class UIFashionSuitComponentSystem
    {

        public static void OnInitModelShow(this UIFashionSuitComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.UIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 40, 250f);
            gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 35;
        }

        public static void OnClicSuitButton(this UIFashionSuitComponent self, int suitid)
        {
            EquipSuitConfig fashionSuitConfig = EquipSuitConfigCategory.Instance.Get(suitid);

            var path = ABPathHelper.GetUGUIPath("Main/Fashion/UIFashionSuitItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            int[] NeedEquipID = fashionSuitConfig.NeedEquipID;
            for (int i = 0; i < NeedEquipID.Length; i++)
            {
                if (NeedEquipID[i] == 0)
                {
                    continue;
                }

                UIFashionSuitItemComponent uiitem = null;
                if (i < self.FashionSuitList.Count)
                {
                    uiitem = self.FashionSuitList[i];
                    uiitem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList);
                    uiitem = self.AddChild<UIFashionSuitItemComponent, GameObject>(go);
                    self.FashionSuitList.Add(uiitem);
                }
                uiitem.OnUpdateUI(NeedEquipID[i]);
            }

            for (int i = NeedEquipID.Length; i < self.FashionSuitList.Count; i++)
            {
                self.FashionSuitList[i].GameObject.SetActive(false);
            }

            self.ShowSuitModel(suitid);
        }

        public static void ShowSuitModel(this UIFashionSuitComponent self, int suitid)
        {
            EquipSuitConfig fashionSuitConfig = EquipSuitConfigCategory.Instance.Get( suitid );

            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            List<int> fashionids = new List<int>() { } ;

            EquipSuitConfig equipSuitConfig = EquipSuitConfigCategory.Instance.Get(suitid   );
            for (int i = 0; i < equipSuitConfig.NeedEquipID.Length; i++)
            {
                fashionids.Add(equipSuitConfig.NeedEquipID[i]);
            }

            ////////把拼装后的模型显示在RawImages
            BagInfo bagInfo = new BagInfo()
            {
                ItemID = self.ZoneScene().GetComponent<BagComponent>().GetWuqiItemID()
            };
            self.UIModelShowComponent.ShowPlayerPreviewModel(bagInfo, fashionids, occ);
        }

        public static void OnInitUI(this UIFashionSuitComponent self)
        {
            List<int> suitlist = new List<int>();
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;

            Dictionary<int, EquipSuitConfig> keyValuePairs = EquipSuitConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.Occ != occ)
                {
                    continue;
                }
                suitlist.Add(item.Key);
            }

            for (int i = 0; i < suitlist.Count; i++)
            {
                int suitid = suitlist[i];   
                GameObject button = GameObject.Instantiate( self.Btn_Suit_1 );
                UICommonHelper.SetParent( button, button.transform.gameObject );
                button.GetComponent<Button>().onClick.AddListener(() => { self.OnClicSuitButton(suitid);  }   );
            }

            if (suitlist.Count > 0)
            {
                self.OnClicSuitButton(suitlist[0]);
            }
        }
    }
}