using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UITreasureSelectComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
        public GameObject BuildingList;

        public List<UIItemComponent> UIItems = new List<UIItemComponent> ();
    }

    [ObjectSystem]
    public class UITreasureSelectComponentAwake : AwakeSystem<UITreasureSelectComponent>
    {
        public override void Awake(UITreasureSelectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITreasureSelect);
            });

            self.BuildingList = rc.Get<GameObject>("BuildingList");
        }
    }

    public static class UITreasureSelectComponentSystem
    {
        public static void OnInitUI(this UITreasureSelectComponent self, int shouiId)
        {
            ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(shouiId);
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> allInfos = new List<BagInfo>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Equipment));

            for (int i = 0; i < allInfos.Count; i++)
            {
                if (allInfos[i].ItemID != shouJiItemConfig.ItemID)
                {
                    continue;
                }

                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList);
                go.transform.localScale = Vector3.one;

                UIItemComponent uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                uI_1.SetEventTrigger(false);
                uI_1.SetClickHandler(self.OnSelectItem);
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.Label_ItemName.SetActive(true);
                uI_1.Image_XuanZhong.SetActive(false);
                self.UIItems.Add(uI_1);
            }
        }


        public static void OnSelectItem(this UITreasureSelectComponent self, BagInfo bagInfo)
        {
            for (int i = 0; i < self.UIItems.Count; i++)
            {
                if (self.UIItems[i].Baginfo.BagInfoID == bagInfo.BagInfoID)
                {
                    self.UIItems[i].Image_XuanZhong.SetActive(true);
                }
            }

            
        }
    }
}