using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1FeedComponent: Entity, IAwake
    {
        public GameObject NumText;
        public GameObject UICommonItem1;
        public GameObject Feed1Btn;
        public GameObject UICommonItem2;
        public GameObject Feed2Btn;

        public UIItemComponent UIItem1Component;
        public UIItemComponent UIItem2Component;
    }

    public class UIActivityV1FeedComponentAwake: AwakeSystem<UIActivityV1FeedComponent>
    {
        public override void Awake(UIActivityV1FeedComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NumText = rc.Get<GameObject>("NumText");
            self.UICommonItem1 = rc.Get<GameObject>("UICommonItem1");
            self.Feed1Btn = rc.Get<GameObject>("Feed1Btn");
            self.UICommonItem2 = rc.Get<GameObject>("UICommonItem2");
            self.Feed2Btn = rc.Get<GameObject>("Feed2Btn");

            self.Feed1Btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnFeedBtn(ActivityConfigHelper.FeedItemReward.Keys.ToList()[0]).Coroutine();
            });
            self.Feed2Btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnFeedBtn(ActivityConfigHelper.FeedItemReward.Keys.ToList()[1]).Coroutine();
            });

            self.UIItem1Component = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem1);
            self.UIItem2Component = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem2);

            self.UpdateInfo();
        }
    }

    public static class UIActivityV1FeedComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1FeedComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;

            self.NumText.GetComponent<Text>().text = $"饱食度：{activityV1Info.BaoShiDu}";

            List<int> items = ActivityConfigHelper.FeedItemReward.Keys.ToList();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int havedNum = 0;
            self.UIItem1Component.UpdateItem(new BagInfo() { ItemID = items[0] }, ItemOperateEnum.None);
            havedNum = (int)bagComponent.GetItemNumber(items[0]);
            self.UIItem1Component.Label_ItemNum.GetComponent<Text>().text = $"{havedNum}/1";
            self.UIItem1Component.Label_ItemNum.GetComponent<Text>().color =
                    havedNum >= 1? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);

            self.UIItem2Component.UpdateItem(new BagInfo() { ItemID = items[1] }, ItemOperateEnum.None);
            havedNum = (int)bagComponent.GetItemNumber(items[1]);
            self.UIItem2Component.Label_ItemNum.GetComponent<Text>().text = $"{havedNum}/1";
            self.UIItem2Component.Label_ItemNum.GetComponent<Text>().color =
                    havedNum >= 1? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);
        }

        public static async ETTask OnFeedBtn(this UIActivityV1FeedComponent self, int itemId)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足");
                return;
            }

            if (bagComponent.GetItemNumber(itemId) < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足");
                return;
            }

            C2M_ActivityFeedRequest request = new C2M_ActivityFeedRequest() { ItemID = itemId };
            M2C_ActivityFeedResponse response =
                    (M2C_ActivityFeedResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;
            self.UpdateInfo();
        }
    }
}