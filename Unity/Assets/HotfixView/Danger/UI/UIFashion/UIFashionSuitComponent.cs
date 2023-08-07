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

            self.OnInitUI();
        }
    }

    public static class UIFashionSuitComponentSystem
    {

        public static void OnClicSuitButton(this UIFashionSuitComponent self, int suitid)
        {
            EquipSuitConfig fashionSuitConfig = EquipSuitConfigCategory.Instance.Get(suitid);

            var path = ABPathHelper.GetUGUIPath("Main/Fashion/UIFashionSuitItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            string[] NeedEquipID = fashionSuitConfig.NeedEquipID.Split(';');
            for (int i = 0; i < NeedEquipID.Length; i++)
            {
                if (ComHelp.IfNull(NeedEquipID[i]))
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
                uiitem.OnUpdateUI(int.Parse(NeedEquipID[i]));
            }

            for (int i = NeedEquipID.Length; i < self.FashionSuitList.Count; i++)
            {
                self.FashionSuitList[i].GameObject.SetActive(false);
            }
        }

        public static void ShowSuitModel(this UIFashionSuitComponent self, int suitid)
        {
            EquipSuitConfig fashionSuitConfig = EquipSuitConfigCategory.Instance.Get( suitid );

 
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