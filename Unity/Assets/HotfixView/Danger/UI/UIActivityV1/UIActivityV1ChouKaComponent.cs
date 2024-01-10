using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1ChouKaComponent: Entity, IAwake
    {
        public GameObject NumText;
        public GameObject UIActivityV1ChouKaListNode;
        public GameObject UIActivityV1ChouKaItem;
        public GameObject RewardItemListNode;
        public GameObject CostItemListNode;
        public GameObject OpenBtn;

        public List<UIActivityV1ChouKaItemComponent> UIActivityV1ChouKaItemComponents = new List<UIActivityV1ChouKaItemComponent>();
        public List<UIItemComponent> UIItemComponents = new List<UIItemComponent>();
    }

    public class UIActivityV1ChouKaComponentAwake: AwakeSystem<UIActivityV1ChouKaComponent>
    {
        public override void Awake(UIActivityV1ChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NumText = rc.Get<GameObject>("NumText");
            self.UIActivityV1ChouKaListNode = rc.Get<GameObject>("UIActivityV1ChouKaListNode");
            self.UIActivityV1ChouKaItem = rc.Get<GameObject>("UIActivityV1ChouKaItem");
            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");
            self.CostItemListNode = rc.Get<GameObject>("CostItemListNode");
            self.OpenBtn = rc.Get<GameObject>("OpenBtn");

            self.UIActivityV1ChouKaItem.SetActive(false);
            self.OpenBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenBtn().Coroutine(); });

            self.InitInfo();
        }
    }

    public static class UIActivityV1ChouKaComponentSystem
    {
        public static async ETTask OnOpenBtn(this UIActivityV1ChouKaComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftSpace() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足");
                return;
            }

            if (!bagComponent.CheckNeedItem(ActivityConfigHelper.ChouKaCostItem))
            {
                FloatTipManager.Instance.ShowFloatTip("所需道具不足");
                return;
            }

            C2M_ActivityChouKaRequest request = new C2M_ActivityChouKaRequest();
            M2C_ActivityChouKaResponse response =
                    (M2C_ActivityChouKaResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UpdateInfo();
        }

        public static void InitInfo(this UIActivityV1ChouKaComponent self)
        {
            foreach (int key in ActivityConfigHelper.ChouKaNumberReward.Keys)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1ChouKaItem);
                UIActivityV1ChouKaItemComponent component = self.AddChild<UIActivityV1ChouKaItemComponent, GameObject>(go);
                component.OnUpdateData(key);
                UICommonHelper.SetParent(go, self.UIActivityV1ChouKaListNode);
                go.SetActive(true);
            }

            List<RewardItem> rewardItems =
                    DropHelper.DropIDToShowItem(self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info.ChouKaDropId);
            for (int i = 0; i < rewardItems.Count; i++)
            {
                if (!ItemConfigCategory.Instance.Contain(rewardItems[i].ItemID))
                {
                    continue;
                }

                var path = ABPathHelper.GetUGUIPath("Main/Role/UITreasureItem");
                var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                GameObject itemSpace = UnityEngine.Object.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, self.RewardItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = rewardItems[i].ItemID, ItemNum = rewardItems[i].ItemNum }, ItemOperateEnum.None);
                //uIItemComponent.Label_ItemName.SetActive(false);
                // uIItemComponent.Label_ItemNum.SetActive(false);
                itemSpace.transform.localScale = Vector3.one * 1f;
                self.UIItemComponents.Add(uIItemComponent);
            }

            UICommonHelper.ShowItemList(ActivityConfigHelper.ChouKaCostItem, self.CostItemListNode, self, 0.8f);
            self.UpdateInfo();
        }

        public static void UpdateInfo(this UIActivityV1ChouKaComponent self)
        {
            self.NumText.GetComponent<Text>().text =
                    $"抽奖次数：{UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.V1ChouKaNumber)}";
        }
    }
}