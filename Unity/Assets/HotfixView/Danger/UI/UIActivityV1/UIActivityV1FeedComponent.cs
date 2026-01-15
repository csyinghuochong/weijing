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
        public GameObject UICommonItem3;
        public GameObject Feed3Btn;

        public UIItemComponent UIItem1Component;
        public UIItemComponent UIItem2Component;
        public UIItemComponent UIItem3Component;

        public GameObject ButtonStageDesc;
        public GameObject UIStageDesc;
        public GameObject StageButtonClose;
        public GameObject UIStageDescList;
        public GameObject UIStageDescItem;
        public Text Text_Growth;
        public Image ImageGrowthValue;
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
            self.UICommonItem3 = rc.Get<GameObject>("UICommonItem3");
            self.Feed3Btn = rc.Get<GameObject>("Feed3Btn");

            self.Feed1Btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnFeedBtn(ActivityConfigHelper.FeedItemReward.Keys.ToList()[0]).Coroutine();
            });
            self.Feed2Btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnFeedBtn(ActivityConfigHelper.FeedItemReward.Keys.ToList()[1]).Coroutine();
            });
            self.Feed3Btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnFeedBtn(ActivityConfigHelper.FeedItemReward.Keys.ToList()[2]).Coroutine();
            });

            self.UIItem1Component = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem1);
            self.UIItem2Component = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem2);
            self.UIItem3Component = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem3);

            self.UIStageDesc = rc.Get<GameObject>("UIStageDesc");
            self.StageButtonClose = rc.Get<GameObject>("StageButtonClose");
            self.StageButtonClose.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIStageDesc.SetActive(false);
            });
            self.UIStageDescList = rc.Get<GameObject>("UIStageDescList");
            self.UIStageDescItem = rc.Get<GameObject>("UIStageDescItem");
            self.UIStageDescItem.SetActive(false);
            self.UIStageDesc.SetActive(false);
            self.ButtonStageDesc = rc.Get<GameObject>("ButtonStageDesc");
            self.ButtonStageDesc.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIStageDesc.SetActive(true);
            });

            self.Text_Growth = rc.Get<GameObject>("Text_Growth").GetComponent<Text>();
            self.ImageGrowthValue = rc.Get<GameObject>("ImageGrowthValue").GetComponent<Image>();

            self.InitUIStageDescList();
            self.UpdateInfo();
        }
    }

    public static class UIActivityV1FeedComponentSystem
    {

        public static void InitUIStageDescList(this UIActivityV1FeedComponent self)
        {
            foreach (var costitem in ActivityConfigHelper.Feed1RewardList)
            {
                GameObject itemSpace = GameObject.Instantiate(self.UIStageDescItem);

                Text text = itemSpace.transform.Find("TextGrowValue").GetComponent<Text>();
                string baoshidu = GameSettingLanguge.LoadLocalization("饱食度");
                text.text = $"{costitem.Key}{baoshidu}";

                GameObject ItemRewardList = itemSpace.transform.Find("ItemRewardList").gameObject;
                UICommonHelper.ShowItemList(costitem.Value, ItemRewardList, self);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.UIStageDescList);
            }
        }

        public static void UpdateInfo(this UIActivityV1FeedComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;

            self.NumText.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("饱食度：{0}"), activityV1Info.BaoShiDu);

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

            self.UIItem3Component.UpdateItem(new BagInfo() { ItemID = items[2] }, ItemOperateEnum.None);
            havedNum = (int)bagComponent.GetItemNumber(items[2]);
            self.UIItem3Component.Label_ItemNum.GetComponent<Text>().text = $"{havedNum}/1";
            self.UIItem3Component.Label_ItemNum.GetComponent<Text>().color =
                    havedNum >= 1 ? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);


            int nextvalue = 0;
            int? result = ActivityConfigHelper.Feed1RewardList.Keys.FirstOrDefault(n => n > activityV1Info.BaoShiDu);

            if (result.HasValue && result != 0)
            {
                nextvalue = result.Value;   
            }
            else
            {
                // 获取最大key的键值对
                nextvalue = ActivityConfigHelper.Feed1RewardList.Keys.OrderByDescending(x => x).First();
            }
            

            float baoshiduprogress = activityV1Info.BaoShiDu * 1f / nextvalue;
            baoshiduprogress = Mathf.Min(1f, baoshiduprogress);
            self.Text_Growth.text = $"{activityV1Info.BaoShiDu}/{nextvalue}";
            self.ImageGrowthValue.fillAmount = baoshiduprogress;
        }

        public static async ETTask OnFeedBtn(this UIActivityV1FeedComponent self, int itemId)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("背包空间不足"));
                return;
            }

            if (bagComponent.GetItemNumber(itemId) < 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("道具不足！"));
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