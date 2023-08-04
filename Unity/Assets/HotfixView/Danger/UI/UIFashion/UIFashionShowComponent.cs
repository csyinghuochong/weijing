using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{

    public class UIFashionShowComponent : Entity, IAwake
    {
        public GameObject RawImage;
        public GameObject Image_Select;
        public GameObject BuildingList;
      
       
        public Dictionary<int, GameObject> ButtonList = new Dictionary<int, GameObject>();
        public List<UIFashionShowItemComponent> FashionItemList = new List<UIFashionShowItemComponent>();
    }

    public class UIFashionShowComponentAwake : AwakeSystem<UIFashionShowComponent>
    {
        public override void Awake(UIFashionShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Image_Select = rc.Get<GameObject>("Image_Select");

            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.FashionItemList.Clear();

            List<int> keys = UICommonHelper.FashionBaseTemplate.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                int keyid = keys[i];
                GameObject Button_key = rc.Get<GameObject>($"Button_{keyid}");
                Button_key.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSubButton(keyid); });
                self.ButtonList.Add(keyid, Button_key);
            }

            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            self.OnClickSubButton(occupationConfig.FashionBase[0]);
        }
    }

    public static class UIFashionShowComponentSystem
    {

        public static void OnClickSubButton(this UIFashionShowComponent self, int subType)
        {
            UICommonHelper.SetParent(self.Image_Select, self.ButtonList[subType]);
            self.Image_Select.transform.SetAsFirstSibling();

            self.OnUpdateFashionList(  subType);
        }

        public static void OnUpdateFashionList(this UIFashionShowComponent self, int subType)
        {
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            List<int> occfashionids = FashionConfigCategory.Instance.GetOccFashionList( occ, subType );

            var path = ABPathHelper.GetUGUIPath("Main/Fashion/UIFashionShowItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);


            for (int i = 0; i < occfashionids.Count; i++)
            {
                UIFashionShowItemComponent uiitem = null;
                if (i < self.FashionItemList.Count)
                {
                    uiitem = self.FashionItemList[i];
                    uiitem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList);
                    uiitem = self.AddChild<UIFashionShowItemComponent, GameObject>(go);
                    self.FashionItemList.Add(uiitem);
                }
                uiitem.OnUpdateUI(occfashionids[i]);
            }

            for (int i = occfashionids.Count; i < self.FashionItemList.Count; i++)
            {
                self.FashionItemList[i].GameObject.SetActive(false);
            }
        }


    }
}