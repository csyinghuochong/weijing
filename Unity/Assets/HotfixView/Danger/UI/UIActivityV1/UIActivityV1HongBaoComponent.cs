using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1HongBaoComponent: Entity, IAwake
    {
        public GameObject DiSet;
        public GameObject JiaGeSet;
        public GameObject HongBaoNumText;
        public GameObject RewardItemListNode;
        public GameObject OpenBtn;
    }

    public class UIActivityV1HongBaoComponentAwake: AwakeSystem<UIActivityV1HongBaoComponent>
    {
        public override void Awake(UIActivityV1HongBaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.DiSet = rc.Get<GameObject>("DiSet");
            self.JiaGeSet = rc.Get<GameObject>("JiaGeSet");
            self.HongBaoNumText = rc.Get<GameObject>("HongBaoNumText");
            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");
            self.OpenBtn = rc.Get<GameObject>("OpenBtn");

            self.OpenBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenBtn().Coroutine(); });

            self.GetInfo().Coroutine();
        }
    }

    public static class UIActivityV1HongBaoComponentSystem
    {
        public static async ETTask GetInfo(this UIActivityV1HongBaoComponent self)
        {
            C2M_ActivityInfoRequest request = new C2M_ActivityInfoRequest();
            M2C_ActivityInfoResponse response =
                    (M2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            string[] items = ActivityConfigHelper.HongBaoRewardPool.Split('@');
            for (int i = 0; i < items.Length; i++)
            {
                string[] item = items[i].Split(';');
                if (!ItemConfigCategory.Instance.Contain(int.Parse(item[0])))
                {
                    continue;
                }

                var path = ABPathHelper.GetUGUIPath("Main/Role/UITreasureItem");
                var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                GameObject itemSpace = UnityEngine.Object.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, self.RewardItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = int.Parse(item[0]), ItemNum = int.Parse(item[1]) }, ItemOperateEnum.None);
                // uIItemComponent.Label_ItemName.SetActive(false);
                // uIItemComponent.Label_ItemNum.SetActive(false);
                itemSpace.transform.localScale = Vector3.one * 1f;
            }

            self.UpdateInfo();
        }

        public static void UpdateInfo(this UIActivityV1HongBaoComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int hongbaoNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1HongBaoNumber);
            long v1rechargeNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1RechageNumber);
            self.HongBaoNumText.GetComponent<Text>().text = (v1rechargeNumber / 98 - hongbaoNumber).ToString();
        }

        public static async ETTask OnOpenBtn(this UIActivityV1HongBaoComponent self)
        {
            self.DiSet.SetActive(true);
            self.JiaGeSet.SetActive(false);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int hongbaoNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1HongBaoNumber);
            long v1rechargeNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.V1RechageNumber);
            int totalHongBa0 = (int)(v1rechargeNumber / 98);
            if (hongbaoNumber >= totalHongBa0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取完了");
                return;
            }

            List<RewardItem> rewardItems = new List<RewardItem>();
            DropHelper.DropIDToDropItem_2(ActivityConfigHelper.HongBaoDropId, rewardItems);
            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() < rewardItems.Count)
            {
                FloatTipManager.Instance.ShowFloatTip("背包已满");
                return;
            }

            C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest() { ActivityType = ActivityConfigHelper.ActivityV1_HongBao };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UpdateInfo();
            self.DiSet.SetActive(false);
            self.JiaGeSet.SetActive(true);
        }
    }
}