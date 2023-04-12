using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UIPaiMaiStallItemComponent : Entity, IAwake
    {

        public GameObject TextName;
        public GameObject TextPrice;
        public GameObject ItemNodeSet;
        public GameObject ImageButton;
        public GameObject ImageSelect;

        public UIItemComponent UIItemComponent;
        public PaiMaiItemInfo PaiMaiItemInfo;
        public Action<PaiMaiItemInfo> ClickHandler;
    }



    public class UIPaiMaiStallItemComponentAwakeSystem : AwakeSystem<UIPaiMaiStallItemComponent>
    {
        public override void Awake(UIPaiMaiStallItemComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextName = rc.Get<GameObject>("TextName");
            self.TextPrice = rc.Get<GameObject>("TextPrice");

            self.ItemNodeSet = rc.Get<GameObject>("ItemNodeSet");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.ClickHandler(self.PaiMaiItemInfo); });

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageSelect.SetActive(false);
            self.UIItemComponent = null;
        }
    }

    public static class UIPaiMaiStallItemComponentSystem
    {

        public static async ETTask OnInitUI(this UIPaiMaiStallItemComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.ItemNodeSet);
            UI uiItem = self.AddChild<UI, string, GameObject>("XiLianItem", go);
            self.UIItemComponent = uiItem.AddComponent<UIItemComponent>();
            self.UIItemComponent.Label_ItemName.SetActive(false);
        }

        public static async ETTask OnUpdateUI(this UIPaiMaiStallItemComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.PaiMaiItemInfo = paiMaiItemInfo;
            if (self.UIItemComponent == null)
            {
                await self.OnInitUI();
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            self.TextName.GetComponent<Text>().text = itemConfig.ItemName;
            self.TextPrice.GetComponent<Text>().text = paiMaiItemInfo.Price.ToString();
            self.UIItemComponent.UpdateItem(paiMaiItemInfo.BagInfo, ItemOperateEnum.None);
        }

        public static void SetSelected(this UIPaiMaiStallItemComponent self, long paimaiId )
        {
            self.ImageSelect.SetActive(paimaiId == self.PaiMaiItemInfo.Id);
        }

        public static void SetClickHandler(this UIPaiMaiStallItemComponent self, Action<PaiMaiItemInfo> action)
        {
            self.ClickHandler = action;
        }
    }
}
