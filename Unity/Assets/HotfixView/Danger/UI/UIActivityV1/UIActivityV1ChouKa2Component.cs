using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1ChouKa2Component: Entity, IAwake
    {
        public GameObject RewardItemListNode;
        public GameObject NumText;
        public GameObject OpenBtn;
        public GameObject RefreshBtn;

        public List<UIItemComponent> UIItemComponents = new List<UIItemComponent>();
    }

    public class UIActivityV1ChouKa2ComponentAwake: AwakeSystem<UIActivityV1ChouKa2Component>
    {
        public override void Awake(UIActivityV1ChouKa2Component self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");
            self.NumText = rc.Get<GameObject>("NumText");
            self.OpenBtn = rc.Get<GameObject>("OpenBtn");
            self.RefreshBtn = rc.Get<GameObject>("RefreshBtn");

            self.OpenBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenBtn().Coroutine(); });
            self.RefreshBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnRefreshBtn().Coroutine(); });

            self.UpdateInfo();
        }
    }

    public static class UIActivityV1ChouKa2ComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1ChouKa2Component self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            string[] items = activityV1Info.ChouKa2ItemList.Split('@');
            int num = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string[] item = items[i].Split(';');
                if (!ItemConfigCategory.Instance.Contain(int.Parse(item[0])))
                {
                    continue;
                }

                if (i >= self.UIItemComponents.Count)
                {
                    var path = ABPathHelper.GetUGUIPath("Main/Role/UITreasureItem");
                    var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                    GameObject itemSpace = UnityEngine.Object.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(itemSpace, self.RewardItemListNode);
                    UIItemComponent uIItem = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                    self.UIItemComponents.Add(uIItem);
                }

                UIItemComponent uIItemComponent = self.UIItemComponents[i];
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = int.Parse(item[0]), ItemNum = int.Parse(item[1]) }, ItemOperateEnum.None);
                if (activityV1Info.ChouKa2RewardIds.Contains(i))
                {
                    uIItemComponent.Label_ItemName.GetComponent<Text>().text = "已抽取";
                }

                //uIItemComponent.Label_ItemName.SetActive(false);
                // uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.GameObject.transform.localScale = Vector3.one * 1f;
                uIItemComponent.GameObject.SetActive(true);
                num++;
            }

            for (int i = num; i < self.UIItemComponents.Count; i++)
            {
                self.UIItemComponents[i].GameObject.SetActive(false);
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.NumText.GetComponent<Text>().text = $"消耗幸运卷轴:{bagComponent.GetItemNumber(ActivityConfigHelper.Chou2CostItem)}/1";
        }

        public static async ETTask OnOpenBtn(this UIActivityV1ChouKa2Component self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetItemNumber(ActivityConfigHelper.Chou2CostItem) < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("道具数量不足");
                return;
            }

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.ChouKa2RewardIds.Count >= activityV1Info.ChouKa2ItemList.Split('@').Length)
            {
                FloatTipManager.Instance.ShowFloatTip("已经抽完");
                return;
            }

            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest() { ActivityType = ActivityConfigHelper.ActivityV1_ChouKa2 };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;
            self.UpdateInfo();
        }

        public static async ETTask OnRefreshBtn(this UIActivityV1ChouKa2Component self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.ChouKa2RewardIds.Count < activityV1Info.ChouKa2ItemList.Split('@').Length / 2)
            {
                FloatTipManager.Instance.ShowFloatTip("未达刷新条件");
                return;
            }

            C2M_ChouKa2RefreshRequest request = new C2M_ChouKa2RefreshRequest();
            M2C_ChouKa2RefreshResponse response =
                    (M2C_ChouKa2RefreshResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;
            self.UpdateInfo();
        }
    }
}