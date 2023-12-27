using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GuessComponent: Entity, IAwake, IDestroy
    {
        public GameObject NewYearItemListNode;
        public GameObject NewYearItem;
        public GameObject UIActivityV1GuessItemListNode;
        public GameObject UIActivityV1GuessItem;

        public List<GameObject> NewYearItems = new List<GameObject>();
        public List<GameObject> UIActivityV1GuessItems = new List<GameObject>();
        public List<string> AssetPath = new List<string>();
    }

    public class UIActivityV1GuessComponentAwake: AwakeSystem<UIActivityV1GuessComponent>
    {
        public override void Awake(UIActivityV1GuessComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NewYearItemListNode = rc.Get<GameObject>("NewYearItemListNode");
            self.NewYearItem = rc.Get<GameObject>("NewYearItem");
            self.UIActivityV1GuessItemListNode = rc.Get<GameObject>("UIActivityV1GuessItemListNode");
            self.UIActivityV1GuessItem = rc.Get<GameObject>("UIActivityV1GuessItem");
            self.NewYearItem.SetActive(false);
            self.UIActivityV1GuessItem.SetActive(false);

            self.GetInfo().Coroutine();
        }
    }

    public class UIActivityV1GuessComponentDestroy: DestroySystem<UIActivityV1GuessComponent>
    {
        public override void Destroy(UIActivityV1GuessComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UIActivityV1GuessComponentSystem
    {
        public static async ETTask GetInfo(this UIActivityV1GuessComponent self)
        {
            C2M_ActivityInfoRequest request = new C2M_ActivityInfoRequest();
            M2C_ActivityInfoResponse response =
                    (M2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            self.InitNewYearItems();
            self.InitGuess();
            self.UpdateInfo();
        }

        public static void InitNewYearItems(this UIActivityV1GuessComponent self)
        {
            List<string> YearItemPath = new List<string>()
            {
                "10030011",
                "10030012",
                "10030013",
                "10030016",
                "10030014",
                "10030015",
            };
            self.NewYearItems.Clear();
            for (int i = 0; i < ActivityConfigHelper.GuessNumber; i++)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.NewYearItem);
                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, YearItemPath[i]);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }

                ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("IconImg").GetComponent<Image>().sprite = sp;
                rc.Get<GameObject>("OutLineImg").SetActive(false);
                int i1 = i;
                rc.Get<GameObject>("ClickBtn").GetComponent<Button>().onClick.AddListener(() => { self.OnNewYearItem(i1).Coroutine(); });
                UICommonHelper.SetParent(go, self.NewYearItemListNode);
                self.NewYearItems.Add(go);
                go.SetActive(true);
            }
        }

        public static async ETTask OnNewYearItem(this UIActivityV1GuessComponent self, int index)
        {
            Log.Debug($"选中新年数字{index}");

            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.GuessIds.Contains(index))
            {
                FloatTipManager.Instance.ShowFloatTip("已经竞猜");
                return;
            }

            string costItem = ActivityConfigHelper.GetGuessCostItem(activityV1Info.GuessIds.Count);
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(costItem))
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足");
                return;
            }

            if (string.IsNullOrEmpty(costItem))
            {
                C2M_ActivityGuessRequest request = new C2M_ActivityGuessRequest() { GuessId = index };
                M2C_ActivityGuessResponse response =
                        (M2C_ActivityGuessResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                activityV1Info.GuessIds.Add(index);

                self.UpdateInfo();
            }
            else
            {
                string[] item = costItem.Split(';');
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "竞猜",
                    $"是否是否花费{item[1]}{ItemConfigCategory.Instance.Get(int.Parse(item[0])).ItemName}开启新选项？",
                    async () =>
                    {
                        C2M_ActivityGuessRequest request = new C2M_ActivityGuessRequest() { GuessId = index };
                        M2C_ActivityGuessResponse response =
                                (M2C_ActivityGuessResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                        activityV1Info.GuessIds.Add(index);

                        self.UpdateInfo();
                    }, null).Coroutine();
            }
        }

        public static void InitGuess(this UIActivityV1GuessComponent self)
        {
            self.UIActivityV1GuessItems.Clear();
            foreach (KeyValuePair<int, string> keyValuePair in ActivityConfigHelper.GuessRewardList)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1GuessItem);
                ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("TimeText").GetComponent<Text>().text = $"{keyValuePair.Key}点开奖";
                UICommonHelper.ShowItemList(keyValuePair.Value, rc.Get<GameObject>("RewardListNode"), self, 0.8f);
                UICommonHelper.SetParent(go, self.UIActivityV1GuessItemListNode);
                self.UIActivityV1GuessItems.Add(go);
                go.SetActive(true);
            }
        }

        public static void UpdateInfo(this UIActivityV1GuessComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;

            // 刷新上方选中的竞猜数字
            for (int i = 0; i < ActivityConfigHelper.GuessNumber; i++)
            {
                ReferenceCollector rc1 = self.NewYearItems[i].GetComponent<ReferenceCollector>();
                rc1.Get<GameObject>("OutLineImg").SetActive(activityV1Info.GuessIds.Contains(i));
            }

            // 刷新下方竞猜
            int index = 0;
            foreach (int key in ActivityConfigHelper.GuessRewardList.Keys)
            {
                if (key <= TimeHelper.DateTimeNow().Hour)
                {
                    ReferenceCollector rc = self.UIActivityV1GuessItems[index].GetComponent<ReferenceCollector>();
                    rc.Get<GameObject>("NewYearImg").SetActive(true);

                    // 显示开奖的图片------------

                    if (activityV1Info.LastGuessReward.Contains(key))
                    {
                        rc.Get<GameObject>("GuessText").GetComponent<Text>().text = "中奖";
                    }
                    else
                    {
                        rc.Get<GameObject>("GuessText").GetComponent<Text>().text = "未中";
                    }

                    index++;
                }
            }

            for (int i = index; i < self.UIActivityV1GuessItems.Count; i++)
            {
                ReferenceCollector rc = self.UIActivityV1GuessItems[i].GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("NewYearImg").SetActive(false);
                rc.Get<GameObject>("GuessText").GetComponent<Text>().text = "未开奖";
            }
        }
    }
}