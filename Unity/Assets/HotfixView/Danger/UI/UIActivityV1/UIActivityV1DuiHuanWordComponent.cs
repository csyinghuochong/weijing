using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1DuiHuanWordComponent: Entity, IAwake, IDestroy
    {
        public GameObject UIActivityV1DuiHuanWordItemListNode;
        public GameObject UIActivityV1DuiHuanWordItem;
        public GameObject SingleRewardListNode;
        public GameObject SingleBtn;
        public GameObject MultipleRewardListNode;
        public GameObject MultipleBtn;

        public List<GameObject> UIActivityV1DuiHuanWordItems = new List<GameObject>();
        public int YearItemId;
        public List<string> AssetPath = new List<string>();
    }

    public class UIActivityV1DuiHuanWordComponentAwake: AwakeSystem<UIActivityV1DuiHuanWordComponent>
    {
        public override void Awake(UIActivityV1DuiHuanWordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIActivityV1DuiHuanWordItemListNode = rc.Get<GameObject>("UIActivityV1DuiHuanWordItemListNode");
            self.UIActivityV1DuiHuanWordItem = rc.Get<GameObject>("UIActivityV1DuiHuanWordItem");
            self.SingleRewardListNode = rc.Get<GameObject>("SingleRewardListNode");
            self.SingleBtn = rc.Get<GameObject>("SingleBtn");
            self.MultipleRewardListNode = rc.Get<GameObject>("MultipleRewardListNode");
            self.MultipleBtn = rc.Get<GameObject>("MultipleBtn");

            self.UIActivityV1DuiHuanWordItem.SetActive(false);

            self.SingleBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnSingleBtn().Coroutine(); });
            self.MultipleBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnMultipleBtn().Coroutine(); });

            self.InitInfo();
        }
    }

    public class UIActivityV1DuiHuanWordComponentDestroy: DestroySystem<UIActivityV1DuiHuanWordComponent>
    {
        public override void Destroy(UIActivityV1DuiHuanWordComponent self)
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

    public static class UIActivityV1DuiHuanWordComponentSystem
    {
        public static void InitInfo(this UIActivityV1DuiHuanWordComponent self)
        {
            List<int> allword = ActivityConfigHelper.DuiHuanWordReward.Keys.ToList();
            foreach (int i in allword)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1DuiHuanWordItem);
                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, i.ToString());
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }

                ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
                rc.Get<GameObject>("IconImg").GetComponent<Image>().sprite = sp;
                rc.Get<GameObject>("OutLineImg").SetActive(false);
                rc.Get<GameObject>("IconImg").GetComponent<Button>().onClick
                        .AddListener(() => { self.OnActivityV1DuiHuanWordItem(i); });
                UICommonHelper.SetParent(go, self.UIActivityV1DuiHuanWordItemListNode);
                self.UIActivityV1DuiHuanWordItems.Add(go);
                go.SetActive(true);
            }

            UICommonHelper.ShowItemList(ActivityConfigHelper.GroupsWordReward, self.MultipleRewardListNode, self, 0.8f, true);
            self.UpdateInfo();
        }

        public static void UpdateInfo(this UIActivityV1DuiHuanWordComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<int> allword = ActivityConfigHelper.DuiHuanWordReward.Keys.ToList();
            for (int i = 0; i < allword.Count; i++)
            {
                int havedNum = (int)bagComponent.GetItemNumber(allword[i]);
                ReferenceCollector rc = self.UIActivityV1DuiHuanWordItems[i].GetComponent<ReferenceCollector>();
                UICommonHelper.SetImageGray(rc.Get<GameObject>("IconImg"), havedNum == 0);
                rc.Get<GameObject>("NumText").GetComponent<Text>().text = $"拥有数量：{havedNum}";
            }
        }

        public static void  OnActivityV1DuiHuanWordItem(this UIActivityV1DuiHuanWordComponent self, int key)
        {
            self.YearItemId = key;
            List<int> allword = ActivityConfigHelper.DuiHuanWordReward.Keys.ToList();
            int index = allword.IndexOf(key);
            for (int i = 0; i < self.UIActivityV1DuiHuanWordItems.Count; i++)
            {
                ReferenceCollector rc = self.UIActivityV1DuiHuanWordItems[i].GetComponent<ReferenceCollector>();
                if (i == index)
                {
                    rc.Get<GameObject>("OutLineImg").SetActive(true);
                    UICommonHelper.DestoryChild(self.SingleRewardListNode);
                    UICommonHelper.ShowItemList(ActivityConfigHelper.DuiHuanWordReward[self.YearItemId], self.SingleRewardListNode, self, 0.8f, true);
                }
                else
                {
                    rc.Get<GameObject>("OutLineImg").SetActive(false);
                }
            }
        }

        public static async ETTask OnSingleBtn(this UIActivityV1DuiHuanWordComponent self)
        {
            if (self.YearItemId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择用于兑换的字");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            if (bagComponent.GetLeftSpace() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足");
                return;
            }

            int havedNum = (int)bagComponent.GetItemNumber(self.YearItemId);
            if (havedNum <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("该字数量不足");
                return;
            }

            C2M_ActivityRewardRequest request =
                    new C2M_ActivityRewardRequest() { ActivityType = ActivityConfigHelper.ActivityV1_DuiHuanWord, RewardId = self.YearItemId };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UpdateInfo();
        }

        public static async ETTask OnMultipleBtn(this UIActivityV1DuiHuanWordComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<int> allword = ActivityConfigHelper.DuiHuanWordReward.Keys.ToList();
            foreach (int i in allword)
            {
                int havedNum = (int)bagComponent.GetItemNumber(i);
                if (havedNum > 0)
                {
                    continue;
                }

                FloatTipManager.Instance.ShowFloatTip("没有完整的一套字");
                return;
            }

            C2M_ActivityRewardRequest request =
                    new C2M_ActivityRewardRequest() { ActivityType = ActivityConfigHelper.ActivityV1_DuiHuanWord };
            M2C_ActivityRewardResponse response =
                    (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UpdateInfo();
        }
    }
}