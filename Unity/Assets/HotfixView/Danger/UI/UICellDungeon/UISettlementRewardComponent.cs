using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettlementRewardComponent : Entity, IAwake<GameObject>
    {
        public GameObject Image_bg;
        public GameObject ImageButton;
        public GameObject Image_bgOpen;

        public RewardItem RewardItem;
        public Action<int> ClickHandler;
        public bool IsSelect;
        public UI UiItem;
        public int Index = -1;

        public GameObject ItemNode;
        public GameObject GameObject;
    }

    [ObjectSystem]
    public class UISettlementRewardComponentAwakeSystem : AwakeSystem<UISettlementRewardComponent, GameObject>
    {
        public override void Awake(UISettlementRewardComponent self, GameObject rc)
        {
            self.IsSelect = false;
            self.UiItem = null;
            self.RewardItem = null;
            self.GameObject = rc;
            self.Image_bgOpen = rc.transform.Find("Image_bgOpen").gameObject;
            self.Image_bgOpen.SetActive(false);

            self.Image_bg = rc.transform.Find("Image_bg").gameObject;

            self.ImageButton = rc.transform.Find("ImageButton").gameObject;
            ButtonHelp.AddListenerEx(self.ImageButton, self.OnClickItem);

            self.ItemNode = rc.transform.Find("UIItem").gameObject;
            self.ItemNode.SetActive(false);
            self.OnInitUI().Coroutine();
        }
    }

    public static class UISettlementRewardComponentSystem
    {
        public static  void OnInitUI(this UISettlementRewardComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject UIItem = GameObject.Instantiate(bundleGameObject);
            UI ui_1 = self.AddChild<UI, string, GameObject>("item_reward", UIItem);
            ui_1.AddComponent<UIItemComponent>();
            UICommonHelper.SetParent(UIItem, self.ItemNode);
            self.UiItem = ui_1;
            if (self.RewardItem != null)
            {
                self.UiItem.GetComponent<UIItemComponent>().UpdateItem(new BagInfo() { ItemID = self.RewardItem.ItemID, ItemNum = self.RewardItem.ItemNum }, ItemOperateEnum.None);
            }
        }

        public static  void OnUpdateData(this UISettlementRewardComponent self, RewardItem rewardItem)
        {
            self.RewardItem = rewardItem;
            if (self.UiItem != null)
            {
                self.UiItem.GetComponent<UIItemComponent>().UpdateItem(new BagInfo() { ItemID = self.RewardItem.ItemID, ItemNum = self.RewardItem.ItemNum }, ItemOperateEnum.None);
            }
        }

        public static void SetClickHandler(this UISettlementRewardComponent self, Action<int> action, int index)
        {
            self.Index = index;
            self.ClickHandler = action;
        }

        public static void ShowRewardItem(this UISettlementRewardComponent self)
        {
            if (self.ItemNode.activeSelf)
            {
                return;
            }

            self.ItemNode.SetActive(true);
            self.Image_bgOpen.SetActive(true);
            self.Image_bg.SetActive(false);
            self.DisableClick();
        }

        public static bool IsCanClicked(this UISettlementRewardComponent self)
        {
            return self.ImageButton.activeSelf;
        }

        public static void DisableClick(this UISettlementRewardComponent self)
        {
            self.ImageButton.SetActive(false);
        }

        public static void OnClickItem(this UISettlementRewardComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (self.Index >= 3 && !unit.IsYueKaStates())
            {
                FloatTipManager.Instance.ShowFloatTip("月卡用户才能开启！");
                return;
            }

            if (self.ItemNode.activeSelf)
                return;

            self.ShowRewardItem();
            self.ClickHandler(self.Index);
        }
    }
}
